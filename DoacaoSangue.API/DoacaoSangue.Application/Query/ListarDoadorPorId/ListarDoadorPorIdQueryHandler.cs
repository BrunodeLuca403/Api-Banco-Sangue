using DoacaoSangue.Application.ViewModel;
using DoacaoSangue.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Query.ListarDoadorPorId
{
    public class ListarDoadorPorIdQueryHandler : IRequestHandler<ListarDoadorPorIdQuery, BuscarDoadorPorIdViewModel>
    {
        private readonly IDoadoresRepository _repository;

        public ListarDoadorPorIdQueryHandler(IDoadoresRepository repository)
        {
            _repository = repository;
        }

        public async Task<BuscarDoadorPorIdViewModel> Handle(ListarDoadorPorIdQuery request, CancellationToken cancellationToken)
        {
            var doador = await _repository.BuscarDoadorId(request.Id);

            var doadorViewModel = new BuscarDoadorPorIdViewModel(doador.Id, doador.Nome, doador.Email, doador.DataNascimento, doador.Genero, doador.Peso, doador.TipoSanguineo, doador.FatorRh, doador.IdEndereco);

            return doadorViewModel;
        }
    }
}