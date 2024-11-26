using DoacaoSangue.Application.ViewModel;
using DoacaoSangue.Core.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Query.ListarDoacao
{
    internal class ListarDoacoesQueryHandler : IRequestHandler<ListarDoacoesQuery, List<ListarDoacoesViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ListarDoacoesQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<ListarDoacoesViewModel>> Handle(ListarDoacoesQuery request, CancellationToken cancellationToken)
        {
            var doacao = await _unitOfWork.Doacao.ListarTodasDoacao();

            var doacaoViewModel = doacao.Select(p => new ListarDoacoesViewModel(p.Id, p.IdDoador, p.DataDoacao)).ToList();

            return doacaoViewModel;
        }
    }
}