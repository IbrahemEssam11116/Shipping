﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Repository.Models
{
    public class OrderMaterial : BaseModel
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int MaterialId { get; set; }
        public Material Material{ get; set; }

    }
}
