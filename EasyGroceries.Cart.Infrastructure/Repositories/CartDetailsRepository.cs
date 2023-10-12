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
        public Task<CartDetails> Add(CartDetails cartDetails)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CartDetails cartDetails)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<CartDetails>> GetAllCartDetails()
        {
            throw new NotImplementedException();
        }

        public Task<CartDetails> GetCartDetailsById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CartDetails cartDetails)
        {
            throw new NotImplementedException();
        }
    }
}
