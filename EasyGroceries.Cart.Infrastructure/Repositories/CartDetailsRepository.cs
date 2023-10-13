using EasyGroceries.Cart.Application.Contracts.Infrastructure;
using EasyGroceries.Cart.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Cart.Infrastructure.Repositories
{
    public class CartDetailsRepository : ICartDetailsRepository
    {
        private static List<CartDetails> cartDetailsLst = new List<CartDetails>
        {
            new CartDetails(){ CartDetailsId = 201, CartHeaderId = 101, ProductId = 2, Count = 4},
            new CartDetails(){ CartDetailsId = 202, CartHeaderId = 102, ProductId = 1, Count = 2},
            new CartDetails(){ CartDetailsId = 203, CartHeaderId = 103, ProductId = 3, Count = 6},
            new CartDetails(){ CartDetailsId = 204, CartHeaderId = 104, ProductId = 4, Count = 8}
        };

        public async Task AddCartDetails(CartDetails cartDetails)
        {
            cartDetailsLst.Add(cartDetails);
        }

        public Task AddCartDetailsList(List<CartDetails> cartDetails)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CartDetails cartDetails)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<CartDetails>> GetAllCartDetails()
        {
            return cartDetailsLst;
        }

        public Task<CartDetails> GetCartDetailsByCartDetailsId(int cartDetailsId)
        {
            throw new NotImplementedException();
        }

        public Task<CartDetails> GetCartDetailsByHeaderId(int headerId)
        {
            throw new NotImplementedException();
        }

        public async Task Update(CartDetails cartDetails)
        {
            var cartdetailFromDb = cartDetailsLst.FirstOrDefault(x => x.CartDetailsId == cartDetails.CartDetailsId);
        }
    }
}
