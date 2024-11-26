using DoacaoSangue.Application.InputModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Command.DeletarDoacao
{
    public class DeletarDoacaoCommand :  IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
