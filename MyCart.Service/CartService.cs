using AutoMapper;
using MyCart.Repository.Contracts;
using MyCart.Repository.Models;
using MyCart.Resources;
using MyCart.Resources.Messages;
using MyCart.Service.Contracts;
using MyCart.Service.Models;
using System;

namespace MyCart.Service
{
    public class CartService : ICartService
    {
        private readonly IMapper mapper;
        private ICartRepository cartRepository;      

        public CartService(IMapper mapper, ICartRepository cartRepository)
        {
            this.mapper = mapper;
            this.cartRepository = cartRepository;
        }

        public ResultObject SaveCart(CartDTO cartDto)
        {
            CartMessages message;
            try
            {
                if (cartDto.Items != null && cartDto.Items.Count > 0)
                {
                    var cart = mapper.Map<Cart>(cartDto);
                    cartRepository.Create(cart);
                    cartRepository.Save();

                    message = CartMessages.CartSaved;
                }
                else
                {
                    message = CartMessages.CartNotSaved;
                }
            }
            catch (Exception ex)
            {
                message = CartMessages.ErrorSaveCart;
            }

            var result = new ResultObject
            {
                Message = message,
                Result = cartDto
            };
            return result;
        }
    }
}
