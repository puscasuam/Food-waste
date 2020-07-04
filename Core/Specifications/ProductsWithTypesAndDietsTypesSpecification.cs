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

        public ProductsWithTypesAndDietsTypesSpecification(string sort, int? dietId, int? typeId) 
            : base ( x => 
                (!dietId.HasValue || x.DietTypeId == dietId) &&
                (!typeId.HasValue || x.ProductTypeId == typeId)
            )
        {
            AddInclude(x => x.DietType);
            AddInclude(x => x.ProductType);
            AddOrderBy(x => x.Name);

            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }
    } 
}
