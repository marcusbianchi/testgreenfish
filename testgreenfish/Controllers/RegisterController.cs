using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using testgreenfish.Models;
using testgreenfish.Services.Interfaces;

namespace testgreenfish.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRegisterServices _registerService;
        public RegisterController(IRegisterServices registerService)
        {
            _registerService = registerService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Email email)
        {
            if (ModelState.IsValid)
            {
                var dbemail = _registerService.getEmail(email.address);
                if (dbemail == null)
                {
                    _registerService.addEmail(email);
                    ViewBag.Message = "E-mail added to mailing list";
                }
                else
                {
                    ViewBag.Message = "This e-mail is already registered to the Database";
                }
            }
            return View();
        }

    }
}
