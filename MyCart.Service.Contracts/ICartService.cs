using MyCart.Resources.Messages;
using MyCart.Service.Models;

namespace MyCart.Service.Contracts
{
    public interface ICartService
    {
        CartMessages SaveCart(CartDTO cart);
    }
}
