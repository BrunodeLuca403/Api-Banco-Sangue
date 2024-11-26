using DoacaoSangue.Core.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Infrastructure.Configurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
       

        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Doador).WithOne(e => e.Endereco).HasForeignKey<Endereco>(p => p.DoadorId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
