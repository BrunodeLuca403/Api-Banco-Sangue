using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Command.DeletarDoador
{
    public class DeletarDoadorCommand : IRequest<Unit>
    {
        public DeletarDoadorCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
