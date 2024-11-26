using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoacaoSangue.Core.Enum;

namespace DoacaoSangue.Core.Entitys
{
    public class EstoqueSangue
    {
        public EstoqueSangue(int id, string tipoSanguinio, FatorRh fatorRh, int quantidadeMl)
        {
            Id = id;
            TipoSanguinio = tipoSanguinio;
            FatorRh = fatorRh;
            QuantidadeMl = quantidadeMl;
        }

        public int Id { get; private set; }
        public string TipoSanguinio { get; private set; }
        public FatorRh FatorRh { get; private set; }
        public int QuantidadeMl { get; private set; }
    }
}
