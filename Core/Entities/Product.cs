using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal NetWeigh { get; set; }

        public int Valability { get; set; }

        public string PictureUrl { get; set; }

        public string Description { get; set; }

        public ProductType ProductType { get; set; }

        public int ProductTypeId { get; set; }

        public DietType DietType {get; set;}

        public int DietTypeId { get; set; }

    }
}
