using Microsoft.AspNetCore.Mvc;
using MyCart.Service.Contracts;
using MyCart.Service.Models;

namespace MyCart.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private ICartService cartService;
        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        [HttpPost("SaveCart")]
        public IActionResult SaveBrand(CartDTO cartDto)
        {
            var result = cartService.SaveCart(cartDto);
            return Ok(result);
        }
    }
}