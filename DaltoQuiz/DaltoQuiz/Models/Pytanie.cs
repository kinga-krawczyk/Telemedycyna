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
    public class Pytanie
    {
        public List<string> Odpowiedzi { get; set; }
        public string PoprawnaOdpowiedz { get; set; }
    }
}
