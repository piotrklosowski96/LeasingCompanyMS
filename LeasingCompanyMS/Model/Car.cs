﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeasingCompanyMS.Model
{
    public class Car
    {
        public int id {  get; set; }
        public string Registration { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string VIN {  get; set; }

        public override string ToString()
        {
            return String.Join(" ", Year, Mark, Model);
        }
    }
}
