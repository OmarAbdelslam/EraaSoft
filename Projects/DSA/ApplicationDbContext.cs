using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DSA
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }

        public virtual DbSet<Employee> employees { get; set; }

        public virtual DbSet<Departement> departements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-E0A8L3Q;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
