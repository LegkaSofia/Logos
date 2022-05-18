using Library.Core.Models;
using Library.Core.Services;
using Library.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class AuthorizeController : Controller
    {
        private readonly ILogger<AuthorizeController> _logger;
        private readonly UserService _userService;

        public AuthorizeController(ILogger<AuthorizeController> logger, UserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        #region Login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginRequest request)
        {
            _logger.LogTrace("Login");

            var user = _userService.GetByLoginAndPassword(request.Login, request.Password);

            if (user == null)
            {
                _logger.LogError("No user with login and password");
                return View();
            }
            
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, request.Login),
                new Claim(ClaimTypes.Role, string.Join(',', user.Roles))
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity),
                new AuthenticationProperties
                {
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(20),
                    IsPersistent = true,
                });

            return RedirectToAction("Index", "Home");
        }

        #endregion

        #region Register

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterRequest request)
        {
            _logger.LogTrace("Register");
            var user = new User
            {
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                Password = request.Password,
                Phone = request.Phone,
                Login = request.Login
            };

            _userService.AddUser(user);
            return RedirectToAction("Index", "Home");
        }

        #endregion

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
