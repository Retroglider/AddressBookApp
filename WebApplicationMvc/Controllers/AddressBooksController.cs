using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Collections.Generic;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    public class AddressBooksController : BaseController
    {
        private readonly AddressBookServices _service;
        public AddressBooksController(IGenericService<AddressBook> service, IMapper mapper) : base( mapper)
        {
            _service = (AddressBookServices)service;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
  
        public IActionResult Index(int userId)
        {
            var list = _service.UnitOfWork.AddressBooks.Find(a => a.UserId == userId);
  
            var model = new AddressBookListViewModel
            {
                List = _mapper.Map<IEnumerable<AddressBookDetailViewModel>>(list)
            };
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}