using EasyGroceries.Cart.Application.Contracts.Infrastructure;
using EasyGroceries.Cart.Domain;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace EasyGroceries.Cart.Infrastructure.Repositories
{
    public class CartHeaderRepository : ICartHeaderRepository
    {
        //private static List<CartHeader> cartHeaderLst = new List<CartHeader>
        //{
        //    new CartHeader(){ CartHeaderId = 101, UserId = 1234, CartTotal = 20, LoyaltyMembershipOpted = true},
        //    new CartHeader(){ CartHeaderId = 103, UserId = 5678, CartTotal = 50, LoyaltyMembershipOpted = false}
        //};

        private readonly IConfiguration _configuration;
        public CartHeaderRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Add(CartHeader cartHeader)
        {
            var sql = "Insert into CartHeader (CartHeaderId, UserId, LoyaltyMembershipOpted, CartTotal) values (@CartHeaderId, @UserId, @LoyaltyMembershipOpted, @CartTotal)";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new
                {
                    CartHeaderId = cartHeader.CartHeaderId,
                    UserId = cartHeader.UserId,
                    LoyaltyMembershipOpted = cartHeader.LoyaltyMembershipOpted,
                    CartTotal = cartHeader.CartTotal,
                });

                connection.Close();
            }
        }

        public Task Delete(CartHeader cartHeader)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<CartHeader>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<CartHeader> GetCartHeaderByUserId(int id)
        {
            var sql = "SELECT * FROM CartHeader WHERE UserId = @id";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<CartHeader>(sql, new { id });
                return result;
            }
        }

        public Task Update(CartHeader cartHeader)
        {
            throw new NotImplementedException();
        }
    }
}
