using DoacaoSangue.Core.Entitys;
using DoacaoSangue.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.ViewModel
{
    public class BuscarDoadorPorIdViewModel
    {
        public BuscarDoadorPorIdViewModel(int id, string nome, string email, DateTime dataNascimento, char genero, decimal peso, TipoSanguineo tipoSanguineo, FatorRh fatorRh, int idEndereco)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Genero = genero;
            Peso = peso;
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            IdEndereco = idEndereco;
        }

        public int Id { get;  set; }
        public string Nome { get;  set; }
        public string Email { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public char Genero { get;  set; }
        public decimal Peso { get;  set; }
        public TipoSanguineo TipoSanguineo { get;  set; }
        public FatorRh FatorRh { get;  set; }
        public int IdEndereco { get;  set; }
    }
}
