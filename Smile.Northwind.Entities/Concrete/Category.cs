﻿using Smile.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Northwind.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

    }
}
