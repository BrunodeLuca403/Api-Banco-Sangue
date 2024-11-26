using DoacaoSangue.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Core.Repository
{
    public interface IDoadoresRepository
    {
        Task AdicionarDoador(Doador doador);

        Task AlterarDoador(Doador doador);

        Task<List<Doador>> ListarTodosDoadores();
        Task<Doador> BuscarDoadorId(int Id);
        void DeletarDoador(int IdDoador);

        Task Savechanges();
    }
}
