using DoacaoSangue.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Core.Repository
{
    public interface IDoacaoRepository
    {
        Task AdicionarDoacao(Doacao doacao);

        Task AlterarDoacao(Doacao doacao);

        Task<List<Doacao>> ListarTodasDoacao();
        Task<Doacao> BuscarDoacaoId(int id);
        Task DeletarDoacao(int Id);

        Task Savechanges();
    }
}
