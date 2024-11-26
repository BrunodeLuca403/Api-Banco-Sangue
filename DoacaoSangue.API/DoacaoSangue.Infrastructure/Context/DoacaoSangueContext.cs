using DoacaoSangue.Core.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoSangue.Infrastructure.Context
{
    public class DoacaoSangueContext : DbContext
    {
        public DoacaoSangueContext(DbContextOptions<DoacaoSangueContext> options) : base(options)
        {
                
        }


        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<Endereco> Enderecos {  get; set; }
        public DbSet<EstoqueSangue> EstoqueSangue { get; set; }


        public void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

           
        }
    }
}
