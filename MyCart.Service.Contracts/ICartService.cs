using MyCart.Resources;
using MyCart.Service.Models;

namespace MyCart.Service.Contracts
{
    public interface ICartService
    {
        ResultObject SaveCart(CartDTO cart);
    }
}
