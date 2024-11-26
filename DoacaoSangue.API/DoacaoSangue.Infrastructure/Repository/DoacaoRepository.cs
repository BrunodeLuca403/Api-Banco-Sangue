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
    public class DoacaoRepository : IDoacaoRepository
    {
        private readonly DoacaoSangueContext _dbContext;

        public DoacaoRepository(DoacaoSangueContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AdicionarDoacao(Doacao doacao)
        {
            await _dbContext.Doacoes.AddAsync(doacao);

        }

        public async Task AlterarDoacao(Doacao doacao)
        {
           var id = await _dbContext.Doacoes.SingleOrDefaultAsync(p => p.Id == doacao.Id);
           _dbContext.Doacoes.Update(id);

        }

        public async Task<Doacao> BuscarDoacaoId(int id)
        {
            return await _dbContext.Doacoes.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task DeletarDoacao(int Id)
        {
            var id = await _dbContext.Doacoes.SingleOrDefaultAsync(p => p.Id == Id);
            _dbContext.Doacoes.Remove(id);

        }

        public async Task<List<Doacao>> ListarTodasDoacao()
        {
           return await _dbContext.Doacoes.AsNoTracking().Include(p => p.Doador).ToListAsync();
        }

        public async Task Savechanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
