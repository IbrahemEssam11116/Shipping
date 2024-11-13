using Microsoft.AspNetCore.Mvc;
using Shiping.Services.Enum;
using Shiping.Services.Models.Client;
using Shiping.Services.Services;
using Shipping.Models;

namespace Shipping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : BaseController
    {
        private readonly ClientSevice _clientSevice;
        private readonly AuthService _authService;
        public ClientController(ClientSevice clientSevice, AuthService authService, IHttpContextAccessor httpContextAccessor) : base(authService, httpContextAccessor)
        {
            _clientSevice = clientSevice;
            _authService = authService;
        }

        [HttpPost("AddClient")]
        public async Task<IActionResult> AddClient(AddClientVM clientVM, [FromHeader] Language LanguageId)
        {

            var isadded = await _clientSevice.AddClient(clientVM, _authService.CurrentUser?.UserType== (int) EmployeeTypeEnum.Admin);
            return Ok(isadded);
        }

        [HttpPost("ClientApproval")]
        public async Task<IActionResult> ClientApproval(SearchClientVM vm, [FromHeader] Language languageId)
        {
            var res = await _clientSevice.SrearchClient(vm, languageId, null);
            return Ok(res);
        }

        [HttpPost("SearchClient")]
        public async Task<IActionResult> SearchClient(SearchClientVM vm, [FromHeader] Language languageId)
        {
            var res = await _clientSevice.SrearchClient(vm, languageId, true);
            return Ok(res);
        }

        [HttpPost("ApproveRejectClient")]
        public async Task<IActionResult> ApproveRejectClient(ApproveRejectClientVM vm, [FromHeader] Language languageId)
        {
            BaseResponse<bool> res = await _clientSevice.ApproveRejectClientVM(vm, languageId);
            return Ok(res);
        }
        [HttpDelete("DeleteClient")]
        public async Task<IActionResult> DeleteClient([FromQuery] int clientId, [FromHeader] Language LanguageId)
        {
            var res = await _clientSevice.DeleteClient(clientId, LanguageId);
            return Ok(res);
        }

        [HttpPost("UpdateClient")]
        public async Task<IActionResult> UpdateClient(EditClientVM vm, [FromHeader] Language LanguageId)
        {
            var res = await _clientSevice.EditClient(vm, LanguageId);
            return Ok(res);
        }

        [HttpGet("GetClient")]
        public async Task<IActionResult> GetClient([FromQuery] int clientId, [FromHeader] Language LanguageId)
        {
            var res = await _clientSevice.GetClient(clientId, LanguageId);
            return Ok(res);
        }
    }
}
