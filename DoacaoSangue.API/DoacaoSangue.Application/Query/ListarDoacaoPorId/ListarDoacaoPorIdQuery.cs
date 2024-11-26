using DoacaoSangue.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Query.ListarDoacaoPorId
{
    public class ListarDoacaoPorIdQuery : IRequest<BuscarDoacaoPorIdViewModel>
    {
        public ListarDoacaoPorIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
      
    }
}
