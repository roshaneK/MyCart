using System.Collections.Generic;

namespace MyCart.Service.Models
{
    public class CartDTO
    {
        public string Name { get; set; }
        public List<ItemDTO> Items { get; set; }
    }
}
