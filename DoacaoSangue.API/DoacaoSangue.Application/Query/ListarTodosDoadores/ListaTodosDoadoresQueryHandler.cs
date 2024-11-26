

using DoacaoSangue.Application.ViewModel;
using DoacaoSangue.Core.Repository;
using MediatR;

namespace DoacaoSangue.Application.Query.ListarTodosDoadores
{
    public class ListaTodosDoadoresQueryHandler : IRequestHandler<ListarTodosDoadoresQuery, List<ListarTodosOsDoadoresViewModel>>
    {
        private readonly IDoadoresRepository _repository;

        public ListaTodosDoadoresQueryHandler(IDoadoresRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ListarTodosOsDoadoresViewModel>> Handle(ListarTodosDoadoresQuery request, CancellationToken cancellationToken)
        {
            var doadores = await _repository.ListarTodosDoadores();
            var listaDoadoresViewModel = doadores.Select(p => new ListarTodosOsDoadoresViewModel(p.Id, p.Nome, p.Email, p.DataNascimento, p.Genero)).ToList();
            return listaDoadoresViewModel;
        }
    }

}
