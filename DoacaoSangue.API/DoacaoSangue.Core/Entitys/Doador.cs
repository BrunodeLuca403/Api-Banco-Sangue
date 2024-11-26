using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoacaoSangue.Core.Enum;

namespace DoacaoSangue.Core.Entitys
{
    public class Doador
    {
        public Doador(int id, string nome, string email, DateTime dataNascimento, char genero, decimal peso, TipoSanguineo tipoSanguineo, FatorRh fatorRh, int idEndereco)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Genero = genero;
            Peso = peso;
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            Doacao = new List<Doacao>();
            IdEndereco = idEndereco;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public char Genero { get; private set; }
        public decimal Peso { get; private set; }
        public TipoSanguineo TipoSanguineo { get; private set; }
        public FatorRh FatorRh { get; private set; }
        public List<Doacao> Doacao { get; private set; }
        public  int IdEndereco { get; private set; }
        public Endereco Endereco { get; private set; } 
        

    }
}
