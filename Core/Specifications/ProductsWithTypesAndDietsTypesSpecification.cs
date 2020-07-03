using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Specifications
{
    public class ProductsWithTypesAndDietsTypesSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndDietsTypesSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.DietType);
            AddInclude(x => x.ProductType);
        }

        public ProductsWithTypesAndDietsTypesSpecification()
        {
            AddInclude(x => x.DietType);
            AddInclude(x => x.ProductType);
        }
    }
}
