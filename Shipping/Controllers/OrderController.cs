using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Shiping.Services;
using Shiping.Services.Enum;
using Shiping.Services.Models.Order;
using Shiping.Services.Services;
using Shipping.Models;
using Spire.Xls;
using ClosedXML;
using DocumentFormat.OpenXml.Spreadsheet;
namespace Shipping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController
    {
        private readonly AuthService authService;
        private readonly OrderService _orderService;
        private readonly FirebaseHttpClientService firebaseHttpClientService;
        private readonly LookupsService _lookupsService;
        public OrderController(AuthService authService, IHttpContextAccessor httpContextAccessor, OrderService orderService, FirebaseHttpClientService firebaseHttpClientService, LookupsService lookupsService) : base(authService, httpContextAccessor)
        {
            this.authService = authService;
            _orderService = orderService;
            this.firebaseHttpClientService = firebaseHttpClientService;
            _lookupsService = lookupsService;
        }
        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder(AddOrderVM vM)
        {
            if (authService.CurrentUser == null)
            {
                return Unauthorized();
            }
            if (authService.CurrentUser.IsAdmin && vM.ClientId == null)
            {
                return BadRequest("Client Id Is Required");
            }
            BaseResponse<bool> res = await _orderService.AddOrder(vM);
            return Ok(res);
        }

        [HttpPost("SearchOrder")]
        public async Task<IActionResult> SearchOrder(SearchOrderVM vm, [FromHeader] Language languageId)
        {
            if (authService.CurrentUser?.IsAdmin == false)
            {
                vm.ClietId = authService.CurrentUser.UserId;
            }
            var res = await _orderService.SearchOrder(vm, languageId);
            return Ok(res);
        }

        [HttpGet("OrderById")]
        public async Task<IActionResult> GetOrderById([FromQuery] int id, [FromHeader] Language languageId)
        {
            var res = await _orderService.GetById(id, languageId);
            return Ok(res);
        }

        [HttpPost("ChangeOrderFees")]
        public async Task<IActionResult> ChangeOrderFees(ChangeOrderFeesVM vm, [FromHeader] Language languageId)
        {
            BaseResponse<bool> response = await _orderService.ChangeOrderFees(vm, languageId);
            return Ok(response);
        }
        [HttpPost("DeleteOrder")]
        public async Task<IActionResult> DeleteOrders(DeleteOrdersVM vm)
        {
            BaseResponse<bool> res = await _orderService.DeleteOrders(vm);
            return Ok(res);
        }

        [HttpPost("ChangeOrderStatus")]
        public async Task<IActionResult> ChangeOrderStatus(ChangeOrderStatusVM vm, [FromHeader] Language languageId)
        {

            if (!_orderService.isAllowChangeStatus(vm.StatusId))
            {
                return Ok(new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "Not Allow To Changeto this Status" : "غير مؤهل لتغير الي تلك الحالة"

                });
            }
            BaseResponse<bool> res = await _orderService.ChangeOrderStatus(vm, languageId);
            return Ok(res);
        }

        [HttpPost("GetOrdersFees")]
        public async Task<IActionResult> GetOrdersFees(OrdersVM vm, [FromHeader] Language languageId)
        {
            var res = await _orderService.GetOrdersFees(vm, languageId);
            return Ok(res);
        }

        [HttpPost("PayClientOrders")]
        public async Task<IActionResult> PayClientOrders(OrdersVM vm, [FromHeader] Language languageId)
        {
            try
            {
                var res = await _orderService.PayClientOrders(vm, languageId);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }

        }
        [HttpPost("UpdateOrder")]
        public async Task<IActionResult> UpdateOrder(UpdateOrderVM vm, [FromHeader] Language languageId)
        {
            var res = await _orderService.EditOrder(vm, languageId);
            return Ok(res);
        }
        [HttpPost("AssignOrdersToDrive")]
        public async Task<IActionResult> AssignOrdersToDrive(AssignOrdersToDriveVM vm, [FromHeader] Language languageId)
        {
            var res = await _orderService.AssignOrdersToDrive(vm, languageId);
            return Ok(res);
        }
        [HttpPost("AddOrderFromExcel")]
        public async Task<IActionResult> AddOrderFromExcel([FromForm] AddOrdersFromExcelvm vm, [FromHeader] Language languageId)
        {
            try
            {
                if (vm.ClientId == 0)
                {
                    return Ok(new BaseResponse<bool>()
                    {
                        Status = ResponseStatus.Error,
                        Message = languageId == Language.arabic ? "العميل مطلوب" : "Client is required"
                    });
                }
                var res = await _orderService.AddOrderFromExcel(vm, languageId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
                return Ok(ex.Message + "\n" + ex.InnerException);
            }
        }

        //[HttpGet("DownloadExcelSamble")]
        //public IActionResult DownloadFile()
        //{
        //    var fileName = "Orders.xlsx";
        //    // Define the path to the wwwroot folder
        //    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", fileName);

        //    // Check if the file exists
        //    if (!System.IO.File.Exists(filePath))
        //        return NotFound();
        //    var cities = new string[] { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" };

        //    // Serve the file for download
        //    var fileBytes = System.IO.File.ReadAllBytes(filePath);
        //    var fileType = "application/octet-stream";  // You can specify the file type, e.g., "application/pdf" for PDFs

        //    return File(fileBytes, fileType, fileName);
        //}
        [HttpGet("DownloadExcelSamble")]
        public async Task<IActionResult> DownloadFile()
        {
            Spire.Xls.Workbook workbook = new Spire.Xls.Workbook();

            Spire.Xls.Worksheet worksheet = workbook.Worksheets[0];
            for (int i = workbook.Worksheets.Count - 1; i > 0; i--)
            {
                workbook.Worksheets.RemoveAt(i);
            }
            worksheet.Range["A1"].Text = "Name";
            worksheet.Range["B1"].Text = "MobileNumber";
            worksheet.Range["C1"].Text = "Address";
            worksheet.Range["D1"].Text = "Description";
            worksheet.Range["E1"].Text = "Weight";
            worksheet.Range["F1"].Text = "Amount";
            worksheet.Range["G1"].Text = "City";
            worksheet.Range["H1"].Text = "Distric";
            worksheet.Range["I1"].Text = "Order Type";
            string[] cities = new string[] { };
            var cityres = await _lookupsService.GetCity(Language.english);
            if (cityres.Status == ResponseStatus.Success)
            {
                cities = cityres.Result.Select(e => e.Name).ToArray();
            }
            string[] districts = new string[] { };
            var districtres = await _lookupsService.GetDistrict(null, Language.arabic);
            if (districtres.Status == ResponseStatus.Success)
            {
                districts = districtres.Result.Select(e => e.Name).Where(w => !string.IsNullOrEmpty(w)).ToArray();
            }
            string[] orderTypes = new string[] { };
            var orderTyperes = await _lookupsService.GetOrderType(Language.english);
            if (orderTyperes.Status == ResponseStatus.Success)
            {
                orderTypes = orderTyperes.Result.Select(e => e.Name).ToArray();
            }
            int rowIndex = 3; // Starting from G3


            foreach (string item in districts)
            {
                worksheet.Range["AA" + rowIndex].Text = item;
                rowIndex++;
            }
            int cityrowIndex = 3; // Starting from G3

            foreach (var item in cities)
            {
                worksheet.Range["AB" + cityrowIndex].Text = item;
                cityrowIndex++;
            }
            //worksheet.Range["G2:G200"].DataValidation.Values = cities;
            //worksheet.Range["H2:H100"].DataValidation.Values = districts.Take(24).ToArray();
            //CellRange range = worksheet.Range["H2:H100"].DataValidation.Values= ;
            //CellRange sourceRange = worksheet.Range[$"AA3:AA{rowIndex}"];
            //CellRange validationRange = worksheet.Range["H2:H100"];
            //worksheet.DataValidations.Add(range);

            //worksheet.DataValidations.Add(range);
            //range.DataValidation.AllowType = CellDataType.Formula;
            //range.DataValidation.Formula1 = $"=$AA$4:$AA${rowIndex}";

            worksheet.Range["I2:I200"].DataValidation.Values = orderTypes.ToArray();

            MemoryStream stream = new MemoryStream();

            workbook.SaveToStream(stream, FileFormat.Version2016);  // Adjust the Excel version if necessary
            stream.Position = 0;
            var aa = new XLWorkbook(stream);
            aa.Worksheets.Delete(2);
           var sheeet= aa.Worksheets.FirstOrDefault();
            if (sheeet != null)
            {

                var dataValidationRange = sheeet.Range("H2:H200");
                var sourceRange = $"AA3:AA{rowIndex}"; // Define the source of your data validation

                dataValidationRange.CreateDataValidation().List(sourceRange);
                var dataValidationRange1 = sheeet.Range("G2:G200");
                var sourceRange1 = $"AB3:AB{cityrowIndex}"; // Define the source of your data validation

                dataValidationRange1.CreateDataValidation().List(sourceRange1);
            }
            aa.SaveAs(stream);
            stream.Position = 0;
            // Return the Excel file as a downloadable response
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            var fileName = "AddOrders.xlsx";
            return File(stream.ToArray(), contentType, fileName);

        }

        [HttpPost("GetPaymentOrder")]
        public async Task<IActionResult> GetPaymentOrder(GetPaymentOrderVM vm, [FromHeader] Language languageId)
        {
            if (authService.CurrentUser?.IsAdmin == false)
            {
                vm.ClietId = authService.CurrentUser.UserId;
            }
            var res = await _orderService.GetPaymentOrder(vm, languageId);
            return Ok(res);
        }
        [HttpPost("SendDiscount")]
        public async Task<IActionResult> SendDiscount(SendDiscountVM vm, [FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _orderService.SendDiscount(vm, languageId);
            return Ok(res);
        }
        [HttpGet("generateNotificationToken")]
        public async Task<IActionResult> se()
        {

            var a = await FirebaseHttpClientService.GetAccessTokenAsync();
            await firebaseHttpClientService.SendNotificationToTopicAsync("add_order", "aaa", "aaaaa");

            return Ok(a);
        }
        //[HttpGet("email")]
        //public async Task<IActionResult> se1()
        //{

        //    await _orderService.sendmail();

        //    return Ok();
        //}

        [HttpPost("RemoveCanceldOrder")]
        public async Task<IActionResult> RemoveCanceldOrder([FromQuery] int id, [FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _orderService.RemoveCanceldOrder(id, languageId);
            return Ok(res);
        }
    }
}
