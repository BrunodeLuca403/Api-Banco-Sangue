using DoacaoSangue.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Core.Repository
{
    public interface IEstoqueSangueRepository
    {
        Task GravarEstoque(EstoqueSangue estoque);

        Task DeletarEstoque(int id);

        Task AlterarEstoque(EstoqueSangue estoque);

        Task<List<EstoqueSangue>> ListarEstoque();

        Task<EstoqueSangue> ListarEstoquePorId(int Id);
    }
}
