using DoacaoSangue.Application.InputModel;
using DoacaoSangue.Core.Entitys;
using DoacaoSangue.Core.Repository;
using DoacaoSangue.Core.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Command.CadastrarDoador
{
    public class AdicionarDoadorCommandHandler : IRequestHandler<AdicionarDoadorCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdicionarDoadorCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(AdicionarDoadorCommand request, CancellationToken cancellationToken)
        {
            var doador = new Doador(request.Id, request.Nome, request.Email, request.DataNascimento, request.Genero, request.Peso, request.TipoSanguineo, request.FatorRh, request.IdEndereco);
            await _unitOfWork.Doadores.AdicionarDoador(doador);
            await _unitOfWork.CompleteAsync();    
            return Unit.Value;  
        }
    }
}