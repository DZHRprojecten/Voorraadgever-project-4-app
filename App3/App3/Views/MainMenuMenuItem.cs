﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Views
{

    public class MainMenuMenuItem
    {
        public MainMenuMenuItem()
        {
            TargetType = typeof(MainMenuDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}