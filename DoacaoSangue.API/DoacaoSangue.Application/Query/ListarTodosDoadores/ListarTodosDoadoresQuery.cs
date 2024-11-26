using DoacaoSangue.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Query.ListarTodosDoadores
{
    public class ListarTodosDoadoresQuery : IRequest<List<ListarTodosOsDoadoresViewModel>>
    {
       
    }
}
