using MyCart.Repository.Contracts;
using MyCart.Repository.Models;

namespace MyCart.Repository
{
    public class CartRepository : RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(MyCartDbContext myCartDbContext)
            : base(myCartDbContext)
        {
        }
    }
}
