﻿using AutomapperTest.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomapperTest.Models.ViewModel
{
    public class StudentViewModel : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}