﻿using Shane.Maravillo.Web.Infrastructure.Data.Helpers;
using Shane.Maravillo.Web.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shane.Maravillo.Web.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}

