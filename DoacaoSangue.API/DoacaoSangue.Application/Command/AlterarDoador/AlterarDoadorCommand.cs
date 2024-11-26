using DoacaoSangue.Application.InputModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Command.AlterarDoador
{
    public class AlterarDoadorCommand : IRequest<Unit>
    {
        public AlterarDoadorCommand(int id, string nome, string email, DateTime dataNascimento, string genero, decimal peso, string tipoSanguineo, string fatorRh, int idEndereco, string endereco)
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
            Endereco = endereco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public decimal Peso { get; set; }
        public string TipoSanguineo { get; set; }
        public string FatorRh { get; set; }
        public int IdEndereco { get; set; }
        public string Endereco { get; set; }
    }
}
