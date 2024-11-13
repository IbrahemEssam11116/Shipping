using Microsoft.AspNetCore.Mvc;
using Shiping.Repository.Migrations;
using Shiping.Repository.Models;
using Shiping.Services.Enum;
using Shiping.Services.Models.Employee;
using Shiping.Services.Services;
using Shipping.Models;

namespace Shipping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseController
    {
        private readonly AuthService _authService;
        private readonly EmployeeService _employeeService;

        public EmployeeController(AuthService authService, IHttpContextAccessor httpContextAccessor, EmployeeService employeeService) : base(authService, httpContextAccessor)
        {
            _authService = authService;
            _employeeService = employeeService;
        }
        [HttpPost("GetEmployeeDashBord")]
        public async Task<IActionResult> GetEmployeeDashBord([FromHeader] Language LanguageId)
        {
            var res = await _employeeService.GetDashBord(LanguageId);
            return Ok(res);
        }
        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody] AddEmployeeVM vm, [FromHeader] Language LanguageId)
        {
            BaseResponse<bool> res = await _employeeService.AddEmployee(vm, LanguageId);
            return Ok(res);
        }
        [HttpGet("GetEmployee")]
        public async Task<IActionResult> GetEmployee([FromQuery] int EmployeeId, [FromHeader] Language LanguageId)
        {
            var res = await _employeeService.GetEmployee(EmployeeId, LanguageId);
            return Ok(res);
        }
        [HttpPost("SearchEmployee")]

        public async Task<IActionResult> SearchEmployee([FromBody] SearchEmployeeVM vm, [FromHeader] Language LanguageId)
        {
            var res = await _employeeService.SearchEmployee(vm, LanguageId);
            return Ok(res);
        }

        [HttpPost("SearchDriver")]

        public async Task<IActionResult> SearchDriver([FromBody] SearchDriverVM vm, [FromHeader] Language LanguageId)
        {
            var res = await _employeeService.SearchEmployee(new SearchEmployeeVM()
            {
                EmployeeTypeId=(int) EmployeeTypeEnum.Driver,
                Name=vm.Name,
                pageNumber=vm.pageNumber,
                pageSize=vm.pageSize,
                PhoneNumber=vm.PhoneNumber,
                CityId=vm.CityId,
                Title=vm.Title,
            }, LanguageId);
            return Ok(res);
        }
        [HttpPost("AddDriver")]
        public async Task<IActionResult> AddDriver([FromBody] AddDriverVM vm, [FromHeader] Language LanguageId)
        {
            var emp = new AddEmployeeVM()
            {
                EmployeeTypeId = (int)EmployeeTypeEnum.Driver,
                CityId = vm.CityId,
                DistrictId = vm.DistrictId,
                Email = vm.Email,
                Password = vm.Password,
                PhoneNumber = vm.PhoneNumber,
                title = vm.title,
                UserName = vm.UserName,

            };
            
            BaseResponse<bool> res = await _employeeService.AddEmployee(emp, LanguageId);
            return Ok(res);
        }
        [HttpPost("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeVM vm, [FromHeader] Language LanguageId)
        {
            var res = await _employeeService.UpdateEmployee(vm, LanguageId);
            return Ok(res);
        }
        [HttpPost("UpdateDriver")]
        public async Task<IActionResult> UpdateDriver([FromBody] UpdateDriverVM vm, [FromHeader] Language LanguageId)
        {
            var res = await _employeeService.UpdateEmployee(new UpdateEmployeeVM()
            {
                CityId=vm.CityId,
                DistrictId=vm.DistrictId,
                Id=vm.Id,
                Permissions = vm.Permissions,
                EmployeeTypeId= (int)EmployeeTypeEnum.Driver,
                Email=vm.Email,
                PhoneNumber=vm.PhoneNumber,
                title= vm.title,
                UserName = vm.UserName  
            }, LanguageId);
            return Ok(res);
        }

        [HttpDelete("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee([FromQuery] int employeeId, [FromHeader] Language LanguageId)
        {
           var res= await _employeeService.DeleteEmployee(employeeId, LanguageId);
            return Ok(res);
        }

        [HttpPost("PayDrivaryOrderCOD")]
        public async Task<IActionResult> PayDrivaryOrderCOD(AddDriverAmountVM vm, [FromHeader] Language LanguageId)
        {
            BaseResponse<bool> res = await _employeeService.PayDrivaryOrderCOD(vm,LanguageId);

            return Ok(res);
        }

        [HttpGet("GetDriveryCODOrder")]
        public async Task<IActionResult> GetDriveryCODOrder([FromQuery] int driveryId, [FromHeader] Language LanguageId)
        {
            var res = await _employeeService.GetDriverAmount(driveryId, LanguageId);

            return Ok(res);
        }
    }
}
