using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IFuncionarioRepository
    {
        Task<List<Funcionario>> GetAllAsync();

        Task<Funcionario?> GetByIdAsync(int id);

        Task AddAsync(Funcionario funcionario);

        void Update(Funcionario funcionario);

        void Delete(Funcionario funcionario);

        Task SaveChangesAsync();
    }
}
