﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWusingDbInProject.Models
{
    public class Service
    {
        public int Id { get; set; }
        public int Delay { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}
