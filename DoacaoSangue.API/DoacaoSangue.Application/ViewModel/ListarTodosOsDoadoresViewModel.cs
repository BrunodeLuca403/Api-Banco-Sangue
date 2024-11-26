using DoacaoSangue.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.ViewModel
{
    public class ListarTodosOsDoadoresViewModel
    {
        public ListarTodosOsDoadoresViewModel(int id, string nome, string email, DateTime dataNascimento, char genero)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Genero = genero;
        }

        public int Id { get;  set; }
        public string Nome { get;  set; }
        public string Email { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public char Genero { get;  set; }
    }
}
