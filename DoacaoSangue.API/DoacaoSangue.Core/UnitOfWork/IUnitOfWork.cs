using DoacaoSangue.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Core.UnitOfWork
{
    public interface IUnitOfWork 
    {
        IDoadoresRepository Doadores { get; }
        IDoacaoRepository Doacao { get; }
        Task<int> CompleteAsync();
    }
}
