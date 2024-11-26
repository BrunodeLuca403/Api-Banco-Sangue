using DoacaoSangue.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Core.Repository
{
    public interface IEnderecoRepository
    {
        Task AdicionarEndereco(Endereco endereco);

        Task AlterarEndereco(Endereco endereco);

        Task<List<Endereco>> ListarTodosEndereco();
        Task<Endereco> BuscarEnderecoId(int Id);
        void DeletarEndereco(int Id);

        Task Savechanges();
    }
}
