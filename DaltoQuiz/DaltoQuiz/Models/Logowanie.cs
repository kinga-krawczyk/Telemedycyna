using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.SqlServer;
using System.Data.SqlClient;
using System;
using System.Data.Entity;


namespace MvcLoginRegistration.Models
{

    public class Logowanie
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Podanie nazwy użytkownika jest konieczne")]
        [Display(Name = "Imie")]
        public string Nazwa_uzytkownika { get; set; }
        [Required(ErrorMessage = "Podanie wieku jest konieczne")]
        public int Wiek { get; set; }
        // płeć osoby rozwiązującej
        [Required(ErrorMessage = "Podanie płci jest konieczne")]
        [Display(Name = "Płeć")]
        public char Plec { get; set; }
        // wynik quizu-na ile odpowiedzi osoba poprawnie odpowiedziała?
        public int Wynik { get; set; }
        //maksymalna ilość punktów
        public int Calosc { get; set; }
     
        public void DodajOsobe()
        {
            //wiek = this.Wiek;
            //nazwa = this.Nazwa_uzytkownika;
            SqlConnection dalton = new SqlConnection(@"Data Source=LAPTOP-8130R9Q0\SQLEXPRESS;Initial Catalog=DaltoQuiz;Integrated Security=True");
            dalton.Open();
            SqlCommand dodaj = new SqlCommand("INSERT INTO Osoby(Nazwa_uzytkownika, Data_rozwiazania, Wiek) VALUES ('" + this.Nazwa_uzytkownika + "', GETDATE(),'" + this.Wiek + "')", dalton);
            SqlDataAdapter adpater = new SqlDataAdapter(dodaj);
            dodaj.ExecuteNonQuery();
            dalton.Close();
        }

        public void DodajWynik()
        {
            SqlConnection dalton = new SqlConnection(@"Data Source=LAPTOP-8130R9Q0\SQLEXPRESS;Initial Catalog=DaltoQuiz;Integrated Security=True");
            dalton.Open();
            SqlCommand dodaj = new SqlCommand("INSERT INTO Wyniki(Plec, Wynik, Calosc) VALUES ('" + this.Plec + "'," +this.Wynik+ ",'" + 10 + "')", dalton);
            SqlDataAdapter adpater = new SqlDataAdapter(dodaj);
            dodaj.ExecuteNonQuery();
            dalton.Close();
        }
    }
}

