using Microsoft.AspNetCore.Antiforgery;
using MetroStation.Controllers;

namespace MetroStation.Web.Host.Controllers
{
    public class AntiForgeryController : MetroStationControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
