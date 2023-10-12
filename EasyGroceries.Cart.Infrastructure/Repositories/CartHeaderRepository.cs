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
        public Task<CartHeader> Add(CartHeader cartHeader)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CartHeader cartHeader)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<CartHeader>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CartHeader> GetCartHeaderByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public Task Update(CartHeader cartHeader)
        {
            throw new NotImplementedException();
        }
    }
}
