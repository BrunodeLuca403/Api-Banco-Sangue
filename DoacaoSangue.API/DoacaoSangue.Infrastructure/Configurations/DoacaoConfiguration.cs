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
    public class DoacaoConfiguration : IEntityTypeConfiguration<Doacao>
    {
        public void Configure(EntityTypeBuilder<Doacao> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Doador).WithMany(e => e.Doacao).HasForeignKey(e => e.DoadorId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
