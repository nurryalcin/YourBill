﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
       
        public string ProductName { get; set; }
      
    }
}
