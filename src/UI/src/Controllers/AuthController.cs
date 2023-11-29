using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Vivendi.UI.Controllers
{
    internal sealed class AuthController : Controller
    {
        public AuthController(IMediator mediator,
            ILogger<AuthController> logger)
                : base(mediator, logger) { }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpGet]
        public IActionResult Register() => View();
    }
}

namespace Vivendi.UI.Models
{
    internal sealed record LoginEditModel(string Email, string Password);

    internal sealed record RegisterEditModel(
        string FirstName, string LastName, string Email, string Password);
}
