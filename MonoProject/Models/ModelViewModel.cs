﻿using MonoProject.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonoProject.Models
{
    public class ModelViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public Make Make { get; set; }
    }
}