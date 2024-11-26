using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.ViewModel
{
    public class BuscarDoacaoPorIdViewModel
    {
        public BuscarDoacaoPorIdViewModel(int id, DateTime dataDoacao, int quantidadeMl, int idDoador)
        {
            Id = id;
            DataDoacao = dataDoacao;
            QuantidadeMl = quantidadeMl;
            IdDoador = idDoador;
        }

        public int Id { get;  set; }
        public DateTime DataDoacao { get;  set; }
        public int QuantidadeMl { get;  set; }
        public int IdDoador { get;  set; }
    }
}
