﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMvc.Models
{
    public class AddressBookListViewModel
    {
        public IEnumerable<AddressBookDetailViewModel> List { get; set; }
    }
}
