using Business;
using Businness.DTOs.Category.Request;
using Businness.DTOs.Category.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Services.Abstraction
{
    public interface ICategoryService
    {
        Task<Response<CategoryResponseDTO>> GetAllAsync();
        Task<Response<CategoryItemResponseDTO>> GetAsync(int id);
        Task<Response> CreateAsync(CategoryCreateDTO model);
        Task<Response> UpdateAsync(CategoryUpdateDTO model);
        Task<Response> DeleteAsync(int id);
    }
}
