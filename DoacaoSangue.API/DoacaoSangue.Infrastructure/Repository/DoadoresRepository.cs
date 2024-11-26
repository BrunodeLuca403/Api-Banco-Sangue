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
    public class DoadoresRepository : IDoadoresRepository
    {
        private readonly DoacaoSangueContext _dbContext;

        public DoadoresRepository(DoacaoSangueContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AdicionarDoador(Doador doador)
        {
            await _dbContext.Doadores.AddAsync(doador);
        }
       
        public async Task AlterarDoador(Doador doador)
        {
            var id = await _dbContext.Doadores.SingleOrDefaultAsync(p => p.Id == doador.Id);

             _dbContext.Doadores.Update(id);
        }

        public async Task<Doador> BuscarDoadorId(int id)
        {
            return await _dbContext.Doadores.SingleOrDefaultAsync(p => p.Id ==id);
        }

        public async void DeletarDoador(int IdDoador)
        {
            var buscarId = await _dbContext.Doadores.SingleOrDefaultAsync(p => p.Id == IdDoador);
            _dbContext.Doadores.Remove(buscarId);
        }

        public async Task<List<Doador>> ListarTodosDoadores()
        {
            return await _dbContext.Doadores.AsNoTracking().ToListAsync();
        }

        public async Task Savechanges()
        {
           await _dbContext.SaveChangesAsync();

            
        }
    }
}
