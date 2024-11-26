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
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly DoacaoSangueContext _dbContext;

        public EnderecoRepository(DoacaoSangueContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AdicionarEndereco(Endereco endereco)
        {
            await _dbContext.Enderecos.AddAsync(endereco);
        }

        public async Task AlterarEndereco(Endereco endereco)
        {
            var buscarId = await _dbContext.Enderecos.SingleOrDefaultAsync(p => p.Id == endereco.Id);
             _dbContext.Update(buscarId);
        }

        public async Task<Endereco> BuscarEnderecoId(int Id)
        {
            var buscarId = await _dbContext.Enderecos.SingleOrDefaultAsync(p => p.Id == Id);
            return buscarId;
        }

        public async void DeletarEndereco(int Id)
        {
            var buscarId = await _dbContext.Enderecos.SingleOrDefaultAsync(p => p.Id == Id);
             _dbContext.Remove(buscarId);
        }

        public async Task<List<Endereco>> ListarTodosEndereco()
        {
            return await _dbContext.Enderecos.AsNoTracking().ToListAsync();
        }

        public async Task Savechanges()
        {
             await _dbContext.SaveChangesAsync();
        }
    }
}
