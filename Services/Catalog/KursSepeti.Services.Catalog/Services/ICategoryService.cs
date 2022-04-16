using KursSepeti.Services.Catalog.Dtos;
using KursSepeti.Services.Catalog.Models;
using KursSepeti.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursSepeti.Services.Catalog.Services
{
    internal interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> CreateAsync(Category category);

        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
