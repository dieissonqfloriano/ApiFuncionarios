using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFuncionarioService
    {
        Task<List<FuncionarioOutputDto>> GetAllAsync();

        Task<FuncionarioOutputDto?> GetByIdAsync(int id);

        Task<FuncionarioOutputDto> CreateAsync(FuncionarioInputDto dto);

        Task<FuncionarioOutputDto> UpdateAsync(int id, FuncionarioInputDto dto);

        Task DeleteAsync(int id);
    }
}
