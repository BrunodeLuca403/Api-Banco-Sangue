using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Core.Entitys
{
    public class Endereco
    {
    

        public Endereco(int id, string logadouro, string cidade, string estado, string cep, int idDoador)
        {
            Id = id;
            Logadouro = logadouro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            DoadorId = idDoador;
        }

        public int Id { get; private set; }
        public string Logadouro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Cep { get; private set; }
        public int DoadorId { get; private set; }
        public Doador Doador { get; private set; }
    }
}
