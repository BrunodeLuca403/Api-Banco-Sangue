using DoacaoSangue.Application.InputModel;
using DoacaoSangue.Core.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Command.AlterarDoador
{
    public class AlterarDoadorCommandHandler : IRequestHandler<AlterarDoadorCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AlterarDoadorCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(AlterarDoadorCommand request, CancellationToken cancellationToken)
        {
            var doador = await _unitOfWork.Doadores.BuscarDoadorId(request.Id);

            if (doador == null)
                throw new KeyNotFoundException("Doador não encontrado.");
              
            await _unitOfWork.Doadores.AlterarDoador(doador);

            return Unit.Value;
        }
    }
}
