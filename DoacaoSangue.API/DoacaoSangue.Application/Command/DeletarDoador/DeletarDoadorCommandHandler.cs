using DoacaoSangue.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Command.DeletarDoador
{
    public class DeletarDoadorCommandHandler : IRequestHandler<DeletarDoadorCommand, Unit>
    {
        private readonly IDoadoresRepository _repository;

        public DeletarDoadorCommandHandler(IDoadoresRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeletarDoadorCommand request, CancellationToken cancellationToken)
        {

            var doador = await _repository.BuscarDoadorId(request.Id);

            if (doador == null)
                throw new KeyNotFoundException("Doador não encontrado.");


            _repository.DeletarDoador(doador.Id);
            await _repository.Savechanges();

            return Unit.Value;  
        }
    }
}
