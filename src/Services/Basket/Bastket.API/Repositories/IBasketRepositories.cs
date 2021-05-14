using Bastket.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public interface IBasketRepositories
    {
        Task<ShoppingCart> GetBasket(string userName);
        Task<ShoppingCart> UpdatedBasket(ShoppingCart basket);
        Task DeleteBasket(string userName);

    }
}
