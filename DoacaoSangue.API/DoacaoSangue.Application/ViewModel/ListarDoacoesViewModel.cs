using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.ViewModel
{
    public class ListarDoacoesViewModel
    {
        public ListarDoacoesViewModel(int id, int doadorId, DateTime dataDoacao)
        {
            Id = id;
            DoadorId = doadorId;
            DataDoacao = dataDoacao;
        }

        public int Id { get;  set; }
        public int DoadorId { get;  set; }
        public DateTime DataDoacao { get;  set; }
    }
}
