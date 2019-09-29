using MyCart.Repository.Contracts;
using MyCart.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
