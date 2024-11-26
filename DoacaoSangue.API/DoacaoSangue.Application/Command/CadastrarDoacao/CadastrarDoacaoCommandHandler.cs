using DoacaoSangue.Application.InputModel;
using DoacaoSangue.Core.Entitys;
using DoacaoSangue.Core.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Command.CadastrarDoacao
{
    public class CadastrarDoacaoCommandHandler : IRequestHandler<CadastrarDoacaoCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CadastrarDoacaoCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CadastrarDoacaoCommand request, CancellationToken cancellationToken)
        {
            var doacao = new Doacao(request.Id, request.QuantidadeMl, request.IdDoador);
            await _unitOfWork.Doacao.AdicionarDoacao(doacao);
            await _unitOfWork.CompleteAsync();
            return Unit.Value;
        }
    }
}
