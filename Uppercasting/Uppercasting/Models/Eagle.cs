﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uppercasting.Models
{
    public class Eagle : Bird
    {
        public int Age  { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle eating");
        }
    }
}
