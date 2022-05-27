﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revenue_control.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }  

    }
}
