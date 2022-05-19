using KursSepeti.Shared.Dtos;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace KursSepeti.Services.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;

        public DiscountService(IConfiguration configuration)
        {
            _configuration = configuration;

            _dbConnection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreSql"));
        }

        public Task<Response<NoContent>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<Models.Discount>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Response<Models.Discount>> GetByCodeAndUserId(string code, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Models.Discount>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> Save(Models.Discount discount)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> Update(Models.Discount discount)
        {
            throw new NotImplementedException();
        }
    }
}
