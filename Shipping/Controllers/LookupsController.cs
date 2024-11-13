using Microsoft.AspNetCore.Mvc;
using Shiping.Services.Enum;
using Shiping.Services.Models.Lookupa;
using Shiping.Services.Models.Lookupa.City;
using Shiping.Services.Models.Lookupa.Material;
using Shiping.Services.Services;
using Shipping.Models;

namespace Shipping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupsController : BaseController
    {
        private readonly LookupsService _lookupsService;
        public LookupsController(AuthService authService, IHttpContextAccessor httpContextAccessor, LookupsService lookupsService) : base(authService, httpContextAccessor)
        {
            _lookupsService = lookupsService;
        }
        [HttpGet("GetCities")]
        public async Task<IActionResult> GetCities([FromHeader] Language languageId)
        {
            var res = await _lookupsService.GetCity(languageId);
            return Ok(res);
        }
        [HttpPost("AddCity")]
        public async Task<IActionResult> AddCity( AddCityVM vm,[FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _lookupsService.AddCity(vm,languageId);
            return Ok(res);
        }
        [HttpPost("UpdateCity")]
        public async Task<IActionResult> UpdateCity(UpdateCityVM vm, [FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _lookupsService.UpdateCity(vm, languageId);
            return Ok(res);
        }


        [HttpGet("GetDistricts")]
        public async Task<IActionResult> GetDistricts([FromQuery] int? cityId, [FromHeader] Language languageId)
        {
            var res = await _lookupsService.GetDistrict(cityId, languageId);
            return Ok(res);
        }
        [HttpPost("AddDistrict")]
        public async Task<IActionResult> AddDistrict(AddDistrictVM vm, [FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _lookupsService.AddDistrict(vm, languageId);
            return Ok(res);
        }
        [HttpPost("UpdateDistrict")]
        public async Task<IActionResult> UpdateDistrict(UpdateDistrictVM vm, [FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _lookupsService.UpdateDistrict(vm, languageId);
            return Ok(res);
        }
        [HttpGet("GetPermissions")]
        public async Task<IActionResult> GetPermission([FromHeader] Language languageId)
        {
            var res = await _lookupsService.GetPermission(languageId);
            return Ok(res);
        }
        [HttpGet("GetEmployeeTypes")]
        public async Task<IActionResult> GetEmployeeTypes([FromHeader] Language languageId)
        {
            var res = await _lookupsService.GetEmployeeTypes(languageId);
            return Ok(res);
        }
        [HttpPost("AddEmployeeType")]
        public async Task<IActionResult> AddEmployeeType(AddLoockupVM vm, [FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _lookupsService.AddEmployeeType(vm);
            return Ok(res);
        }

        [HttpGet("GetOrderStatus")]
        public async Task<IActionResult> GetOrderStatus([FromHeader] Language languageId)
        {
            var res = await _lookupsService.GetOrderStatus(languageId);
            return Ok(res);
        }

        [HttpGet("GetMaterial")]
        public async Task<IActionResult> GetMaterial([FromHeader] Language languageId)
        {
            var res = await _lookupsService.GetMaterial(languageId);
            return Ok(res);
        }
        [HttpPost("AddMaterial")]
        public async Task<IActionResult> AddMaterial(AddMaterialVM vm, [FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _lookupsService.AddMaterial(vm, languageId);
            return Ok(res);
        }

        [HttpPost("UpdateMaterial")]
        public async Task<IActionResult> UpdateMaterial(UpdateMaterialVM vm, [FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _lookupsService.UpdateMaterial(vm, languageId);
            return Ok(res);
        }

        [HttpGet("GetOrderType")]
        public async Task<IActionResult> GetOrderType([FromHeader] Language languageId)
        {
            var res = await _lookupsService.GetOrderType(languageId);
            return Ok(res);
        }
        [HttpPost("AddOrderType")]
        public async Task<IActionResult> AddOrderType(AddLoockupVM vm, [FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _lookupsService.AddOrderType(vm, languageId);
            return Ok(res);
        }

    }
}
