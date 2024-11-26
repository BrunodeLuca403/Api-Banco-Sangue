using DoacaoSangue.Core.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Infrastructure.Configurations
{
    public class DoadorConfiguration : IEntityTypeConfiguration<Doador>
    {
        public void Configure(EntityTypeBuilder<Doador> builder)
        {

            builder.HasKey(e => e.Id);
            builder.HasMany(e => e.Doacao)
                .WithOne(e => e.Doador)
                .HasForeignKey(e => e.IdDoador)
                .OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(e => e.Endereco)
                .WithOne(e => e.Doador)
                .HasForeignKey<Doador>(e => e.IdEndereco)
                .OnDelete(DeleteBehavior.Restrict);



          
        }
    }
}
