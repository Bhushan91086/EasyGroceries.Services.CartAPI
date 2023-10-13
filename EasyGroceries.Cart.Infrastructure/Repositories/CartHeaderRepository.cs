using EasyGroceries.Cart.Application.Contracts.Infrastructure;
using EasyGroceries.Cart.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Cart.Infrastructure.Repositories
{
    public class CartHeaderRepository : ICartHeaderRepository
    {
        private static List<CartHeader> cartHeaderLst = new List<CartHeader>
        {
            new CartHeader(){ CartHeaderId = 101, UserId = 1234, CartTotal = 20, LoyaltyMembershipOpted = true},
            new CartHeader(){ CartHeaderId = 103, UserId = 5678, CartTotal = 50, LoyaltyMembershipOpted = false}
        };

        public async Task Add(CartHeader cartHeader)
        {
            cartHeaderLst.Add(cartHeader);
        }

        public Task Delete(CartHeader cartHeader)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<CartHeader>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<CartHeader> GetCartHeaderByUserId(int userId)
        {
            return cartHeaderLst.FirstOrDefault(x => x.UserId == userId);
        }

        public Task Update(CartHeader cartHeader)
        {
            throw new NotImplementedException();
        }
    }
}
