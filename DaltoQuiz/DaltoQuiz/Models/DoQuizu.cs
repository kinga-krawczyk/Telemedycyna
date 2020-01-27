using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MvcLoginRegistration.Models
{
    public class DoQuizu 
        // z tutoriala OurDbContext
        // przygotowanie użytkownika 
    {
        public DbSet<Logowanie> Osoby { get; set; }
       
    }
}
 