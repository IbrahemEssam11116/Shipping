using Microsoft.AspNetCore.Mvc;
using Shiping.Services.Services;

namespace Shipping.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly AuthService authService;
        private readonly IHttpContextAccessor httpContextAccessor;

        public BaseController(AuthService authService, IHttpContextAccessor httpContextAccessor)
        {
            this.authService = authService;
            this.httpContextAccessor = httpContextAccessor;
            ReadRokenData();

        }

        private void ReadRokenData()
        {
            string token = null;
            var authHeader = httpContextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            if (authHeader != null && authHeader.StartsWith("Bearer "))
            {
                token = authHeader.Substring("Bearer ".Length).Trim();
            }
            if (authService != null && token != null)
            {
                authService.ConvertTokenToLoginModel(token);
            }
        }
    }
}
