using EasyGroceries.Cart.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Cart.Application.Contracts.Infrastructure
{
    public interface ICartHeaderRepository
    {
        Task<IReadOnlyList<CartHeader>> GetAll();
        Task<CartHeader> GetCartHeaderByUserId(int userId);
        Task<CartHeader> Add(CartHeader cartHeader);
        Task Update(CartHeader cartHeader);
        Task Delete(CartHeader cartHeader);
    }
}
