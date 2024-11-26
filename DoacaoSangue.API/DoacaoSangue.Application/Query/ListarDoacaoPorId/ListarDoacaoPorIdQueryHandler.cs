using DoacaoSangue.Application.ViewModel;
using DoacaoSangue.Core.Entitys;
using DoacaoSangue.Core.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Query.ListarDoacaoPorId
{
    public class ListarDoacaoPorIdQueryHandler : IRequestHandler<ListarDoacaoPorIdQuery, BuscarDoacaoPorIdViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ListarDoacaoPorIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BuscarDoacaoPorIdViewModel> Handle(ListarDoacaoPorIdQuery request, CancellationToken cancellationToken)
        {
            var doacao = await _unitOfWork.Doacao.BuscarDoacaoId(request.Id);

            var doacaoViewModel = new BuscarDoacaoPorIdViewModel(doacao.Id, doacao.DataDoacao, doacao.QuantidadeMl, doacao.IdDoador);

            return doacaoViewModel;
        }
    }
}
