using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class ProductService
	{
		private readonly TestDbContext _ctx;

        public ProductService(TestDbContext context)
        {
            _ctx = context;
        }

        public GenericList<Product> ListProducts(int page)
		{
			return new GenericList<Product>() {  HasNext=false, TotalCount =page, List = _ctx.Products.Skip(10 * (page - 1)).Take(10).ToList() };
		}

	}
}
