using DoacaoSangue.Application.Command.CadastrarDoador;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Application.Validators
{
    public class CadastrarDoadoresCommandValidator : AbstractValidator<AdicionarDoadorCommand>
    {
        public CadastrarDoadoresCommandValidator()
        {
            RuleFor(p => p.Nome).NotEmpty().NotNull().MaximumLength(50).WithMessage("Nome tem um limite de 50 caracteries");

            RuleFor(p => p.Email).NotEmpty().EmailAddress().WithMessage("Email invalido");

            RuleFor(p => p.Peso).NotEmpty().WithMessage("Inserir o peso");

            RuleFor(p => p.DataNascimento).NotEmpty().WithMessage("Inserir a data de nascimento");

            RuleFor(p => p.Genero).NotEmpty().Must(ValidarSexo).WithMessage("O gênero deve ser 'M' para masculino ou 'F' para feminino.");
        }

        private static bool ValidarSexo(char sexo)
        {
            return sexo == 'M' || sexo == 'F';
        }
    }
}
