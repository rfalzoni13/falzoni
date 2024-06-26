﻿using Falzoni.Domain.Entities.Base;
using Falzoni.Domain.Entities.Stock;

namespace Falzoni.Domain.Entities.Register
{
    public class ProductCategory : BaseEntity
    {
        public string Name { get; set; }


        public virtual Product Product { get; set; }
    }
}
