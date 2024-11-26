using DoacaoSangue.Core.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Command.DeletarDoacao
{
    public class DeletarDoacaoCommandHandler : IRequestHandler<DeletarDoacaoCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeletarDoacaoCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeletarDoacaoCommand request, CancellationToken cancellationToken)
        {
            var doador = await _unitOfWork.Doacao.BuscarDoacaoId(request.Id);

            if (doador == null)
                throw new KeyNotFoundException("Doação não encontrada.");

            await _unitOfWork.Doacao.DeletarDoacao(doador.Id);
            _unitOfWork.CompleteAsync();

            return Unit.Value;
        }
    }
}
