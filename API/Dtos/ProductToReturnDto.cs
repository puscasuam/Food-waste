using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductToReturnDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal NetWeigh { get; set; }

        public int Valability { get; set; }

        public string PictureUrl { get; set; }

        public string Description { get; set; }

        public string ProductType { get; set; }

        public string DietType { get; set; }

    }
}
