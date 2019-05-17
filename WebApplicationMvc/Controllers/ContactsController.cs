using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Collections.Generic;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    public class ContactsController  :BaseController
    {
        private readonly ContactServices _service;
        public ContactsController(IGenericService<Contact> service, IMapper mapper) :base(mapper)  
        {
            _service = (ContactServices)service;
        }
        public IActionResult Index(int id)
        {
            var addressBook = _service.UnitOfWork.AddressBooks.Get(id);
            var list = _service.UnitOfWork.Contacts.Find( c => c.AddressBookId == id);
            var model = new ContactListViewModel
            {
                AddressBookId = addressBook.Id,
                AddressBookName = addressBook.Name,
                Contacts = _mapper.Map<IEnumerable<ContactDetailViewModel>>(list)
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var contact = _service.Get(id);
            var model = _mapper.Map<ContactDetailViewModel>(contact);

            return View(model);
        }
    }
}