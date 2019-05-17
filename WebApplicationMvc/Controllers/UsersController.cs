using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Services;
using System;

namespace WebApplicationMvc.Controllers
{
    public class UsersController:BaseController
    {
        private readonly UserServices _service;
        public UsersController(IGenericService<User> services, IMapper mapper) : base(mapper)
        {
            _service = (UserServices)services;
        }
        public IActionResult Index()
        {
            return View("Authenticate");
        }

        public IActionResult Authenticate(string systemId, string password)
        {
            try
            {
                var user = _service.Authenticate(systemId, password);
                ViewData["User"] = user;
                //return RedirectToAction("Index", "AddressBook");
                return View();

            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View();
            }

        }
    }
}