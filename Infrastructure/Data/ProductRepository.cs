using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Data
{

	public class ProductRepository : IProductRepository
	{
		private readonly StoreContext _context;

		public ProductRepository(StoreContext context)
		{
			_context = context;
		}

		//public void DeleteAsync(int id)
		//{
		//	var item = _context.Products
		//			.Include(p => p.ProductType)
		//		.Include(P => P.DietType)
		//		.FirstOrDefaultAsync(p => p.Id == id);

		//	_context.Remove(item);
		//	_context.SaveChangesAsync();
		//}

		public async Task<IReadOnlyList<DietType>> GetDietTypeAsync()
		{
			return await _context.DietTypes.ToListAsync();
		}

		public async Task<Product> GetProductByIdAsync(int id)
		{
			return await _context.Products
				.Include(p => p.ProductType)
				.Include(P => P.DietType)
				.FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<IReadOnlyList<Product>> GetProductsAsync()
		{
			return await _context.Products
				.Include(p => p.ProductType)
				.Include(P => P.DietType)
				.ToListAsync();
		}

		public async Task<IReadOnlyList<ProductType>> GetProductTypeAsync()
		{
			return await _context.ProductTypes.ToListAsync();
		}

		//public void PostAsync(Product product)
		//{
		//	_context.Add<Product>(product);
		//	_context.SaveChanges();
		//}
	}
}
