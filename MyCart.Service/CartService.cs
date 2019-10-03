using AutoMapper;
using MyCart.Repository.Contracts;
using MyCart.Repository.Models;
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

        public CartMessages SaveCart(CartDTO cartDto)
        {
            try
            {
                if (cartDto.Items != null && cartDto.Items.Count > 0)
                {
                    var cart = mapper.Map<Cart>(cartDto);
                    cartRepository.Create(cart);
                    cartRepository.Save();

                    return CartMessages.CartSaved;
                }
                else
                {
                    return CartMessages.CartNotSaved;
                }
            }
            catch (Exception ex)
            {
                return CartMessages.ErrorSaveCart;
            }
            
        }
    }
}
