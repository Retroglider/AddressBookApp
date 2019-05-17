using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace WebApplicationMvc.Controllers
{
    public class BaseController:Controller
    {
        protected readonly IMapper _mapper;
        public BaseController(IMapper mapper)
        {
            _mapper = mapper;            
        }
    }
}
