using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcLoginRegistration.Models;
using Microsoft.Extensions.Configuration;


namespace DaltoQuiz.Models
{
    public class LogowanieContext : DbContext
    {
        public LogowanieContext (DbContextOptions<LogowanieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcLoginRegistration.Models.Logowanie> Logowanie { get; set; }
        public virtual DbSet<Quiz> Quiz { get; set; }
       // public virtual DbSet<Logowanie> Logowanie { get; set; }
       public virtual DbSet<DoQuizu> Doquizu { get; set; }
      
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder();
                builder.AddJsonFile("appsettings.json");
                var configuration = builder.Build();
                optionsBuilder.UseSqlServer(configuration["ConnecionStrings : DefaultConnection"]);
            }
        }

        //protected override void OnModelCreating(ModelBuilder model)
        //{
        //    model.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

        //    model.Entity<Quiz>(entity => )
        //}
    }
}
