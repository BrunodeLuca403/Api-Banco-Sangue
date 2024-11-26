using DoacaoSangue.Core.Entitys;
using DoacaoSangue.Core.Repository;
using DoacaoSangue.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Infrastructure.Repository
{
    public class EstoqueSangueRepository : IEstoqueSangueRepository
    {
        private readonly DoacaoSangueContext _dbContext;

        public EstoqueSangueRepository(DoacaoSangueContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AlterarEstoque(EstoqueSangue estoque)
        {
            var buscarId = await _dbContext.EstoqueSangue.SingleOrDefaultAsync(p => p.Id == estoque.Id);
            _dbContext.EstoqueSangue.Update(buscarId);
        }

        public async Task DeletarEstoque(int id)
        {
            var buscarId = await _dbContext.EstoqueSangue.SingleOrDefaultAsync(p => p.Id == id);
             _dbContext.EstoqueSangue.Remove(buscarId);
        }

        public async Task GravarEstoque(EstoqueSangue estoque)
        {
            await _dbContext.EstoqueSangue.AddAsync(estoque);
        }

        public async Task<List<EstoqueSangue>> ListarEstoque()
        {
            return await _dbContext.EstoqueSangue.AsNoTracking().ToListAsync();
        }

        public async Task<EstoqueSangue> ListarEstoquePorId(int Id)
        {
            var buscarId = await _dbContext.EstoqueSangue.SingleOrDefaultAsync(p => p.Id == Id);

            return buscarId;
        }
    }
}
