using DoacaoSangue.Application.InputModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Command.CadastrarDoacao
{
    public class CadastrarDoacaoCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DateTime DataDoacao { get; set; }
        public int QuantidadeMl { get; set; }
        public int IdDoador { get; set; }
    }
}
