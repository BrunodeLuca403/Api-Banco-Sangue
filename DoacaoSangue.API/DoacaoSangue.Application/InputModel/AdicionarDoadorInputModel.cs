using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.InputModel
{
    public class AdicionarDoadorInputModel
    {
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public string Email { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public string Genero { get;  set; }
        public decimal Peso { get;  set; }
        public string TipoSanguineo { get;  set; }
        public string FatorRh { get;  set; }
        public int IdEndereco { get;  set; }
    }
}
