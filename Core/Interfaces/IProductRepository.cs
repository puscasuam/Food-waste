using Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
	public interface IProductRepository
	{
		Task<Product> GetProductByIdAsync(int id);

		//void PostAsync(Product product);

		//void DeleteAsync(int id);

		Task<IReadOnlyList<Product>> GetProductsAsync();
		Task<IReadOnlyList<ProductType>> GetProductTypeAsync();
		Task<IReadOnlyList<DietType>> GetDietTypeAsync();

	} 	
}
