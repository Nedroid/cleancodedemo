﻿using CleanCodeDemo.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Entity
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerType Type { get; set; }
    }
}
