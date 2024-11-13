using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shiping.Repository.Models;
using Shiping.Services.Enum;
using Shiping.Services.Models.Lookupa;
using Shiping.Services.Services;
using Shipping.Models;

namespace Shipping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyInfoController : BaseController
    {
        private readonly LookupsService _lookupsService;
        public CompanyInfoController(AuthService authService, IHttpContextAccessor httpContextAccessor, LookupsService lookupsService) : base(authService, httpContextAccessor)
        {
            _lookupsService = lookupsService;
        }
        [HttpGet("AboutUs")]
        public async Task<IActionResult> GetAboutUs([FromHeader] Language LanguageId)
        {
            CompanyInfo Info = await _lookupsService.GetCompanyInfo();

            return Ok(new BaseResponse<string>()
            {
                Status = ResponseStatus.Success,
                Result = (LanguageId == Language.english ? Info?.AboutUs : Info?.AboutUsAR) ?? ""
            });
        }

        [HttpGet("PhoneNumber")]
        public async Task<IActionResult> PhoneNumber([FromHeader] Language LanguageId)
        {
            CompanyInfo Info = await _lookupsService.GetCompanyInfo();

            return Ok(new BaseResponse<string>()
            {
                Status = ResponseStatus.Success,
                Result = Info?.PhoneMumber??""
            });
        }

        [HttpPost("UpdateCompanyInfo")]
        public async Task<IActionResult> UpdateAboutUs(UpdateAboutUsVM vm, [FromHeader] Language LanguageId)
        {
            var Info = await _lookupsService.UpdateAboutUs(vm);

            return Ok(Info);
        }
        [HttpPost("GetCompanyInfo")]
        public async Task<IActionResult> CompanyInfo()
        {
            var Info = await _lookupsService.GetCompanyInfo();

            return Ok(new BaseResponse<CompanyInfo>()
            {
                Status = ResponseStatus.Success,
                Result = Info,
            });
        }
    }
}
