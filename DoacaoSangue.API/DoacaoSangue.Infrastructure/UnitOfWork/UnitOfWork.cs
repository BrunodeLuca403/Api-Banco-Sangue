using DoacaoSangue.Core.Repository;
using DoacaoSangue.Core.UnitOfWork;
using DoacaoSangue.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDoacaoRepository _DoacaoRepository;
        private readonly IDoadoresRepository _doresRepository;
        private readonly DoacaoSangueContext _context;
        public UnitOfWork(IDoacaoRepository doacaoRepository, IDoadoresRepository doresRepository, DoacaoSangueContext context)
        {
            _DoacaoRepository = doacaoRepository;
            _doresRepository = doresRepository;
            _context = context;
        }

        public IDoadoresRepository Doadores { get; }

        public IDoacaoRepository Doacao { get;  }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
