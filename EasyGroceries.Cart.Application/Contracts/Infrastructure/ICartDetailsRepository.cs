using EasyGroceries.Cart.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Cart.Application.Contracts.Infrastructure
{
    public interface ICartDetailsRepository
    {
        Task<IReadOnlyList<CartDetails>> GetAllCartDetails();
        Task<CartDetails> GetCartDetailsById(int id);
        Task<CartDetails> Add(CartDetails cartDetails);
        Task Update(CartDetails cartDetails);
        Task Delete(CartDetails cartDetails);
    }
}
