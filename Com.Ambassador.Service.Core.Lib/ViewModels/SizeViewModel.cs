﻿using Com.Ambassador.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Com.Ambassador.Service.Core.Lib.ViewModels
{
    public class SizeViewModel : BasicViewModel
    {
        public string Size { get; set; }
        public int SizeIdx { get; set; }
    }
}