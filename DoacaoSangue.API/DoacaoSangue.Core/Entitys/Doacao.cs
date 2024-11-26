using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Core.Entitys
{
    public class Doacao
    {
        public Doacao(int id, int quantidadeMl, int idDoador)
        {
            Id = id;
            DataDoacao = DateTime.Now;
            QuantidadeMl = quantidadeMl;
            IdDoador = idDoador;
        }

        public int Id { get; private set; }
        public DateTime DataDoacao { get; private set; }
        public int  QuantidadeMl { get; private set; }
        public int IdDoador { get; private set; }
        public Doador Doador { get; private set; }
    }
}
