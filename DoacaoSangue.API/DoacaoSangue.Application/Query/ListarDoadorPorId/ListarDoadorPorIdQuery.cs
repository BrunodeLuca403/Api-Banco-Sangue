using DoacaoSangue.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Query.ListarDoadorPorId
{
    public class ListarDoadorPorIdQuery : IRequest<BuscarDoadorPorIdViewModel>
    {
        public ListarDoadorPorIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
