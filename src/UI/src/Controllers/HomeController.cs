using System.Diagnostics;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Vivendi.UI.Models;

namespace Vivendi.UI.Controllers
{
    internal sealed class HomeController : Controller
    {
        public HomeController(IMediator mediator,
            ILogger<HomeController> logger)
                : base(mediator, logger) { }

        [HttpGet]
        [ResponseCache(Duration = 86400,
                       Location = ResponseCacheLocation.Any)]
        public IActionResult Index() => View();

        [HttpGet]
        [ResponseCache(Duration = 0,
                       Location = ResponseCacheLocation.None,
                       NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel(Activity.Current?.Id ??
                HttpContext.TraceIdentifier, true));
    }
}

namespace Vivendi.UI.Models
{
    internal sealed record HomeViewModel(Profile? Profile);
    internal sealed record ErrorViewModel(string RequestId, bool DisplayRequestId);
}
