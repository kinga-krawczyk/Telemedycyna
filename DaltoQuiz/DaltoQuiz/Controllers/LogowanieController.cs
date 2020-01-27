using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcLoginRegistration.Models;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.SqlServer;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;



namespace MvcLoginRegistration.Models
 {
    
    public class LogowanieController : Controller
    {
        public List<Pytanie> ListaPytan { get; set; }

        public LogowanieController()
        {
            ListaPytan = new List<Pytanie>(){
                new Pytanie()
                {//1
                    Odpowiedzi = new List<string>(){ "16", "45", "15", "nic" },
                    PoprawnaOdpowiedz = "45",

                },
                new Pytanie()
                {//2
                    Odpowiedzi = new List<string>(){ "1", "nic","4","7"},
                    PoprawnaOdpowiedz = "7",
                },
                new Pytanie()
                {//3
                    Odpowiedzi = new List<string>(){ "Kółko", "Nic", "Szlaczek", "Gwiazdka"},
                     PoprawnaOdpowiedz = "gwiazdka",
                },
                   new Pytanie()
                {//4
                       Odpowiedzi = new List<string>(){"5","3","nic","6"},
                     PoprawnaOdpowiedz = "5",
                },
                 new Pytanie()
                {//5
                     Odpowiedzi = new List<string>(){"nic","22","42","12"},
                     PoprawnaOdpowiedz = "42",
                },
                    new Pytanie()
                {//6
                        Odpowiedzi = new List<string>(){"73","13","nic","78"},
                     PoprawnaOdpowiedz = "73",
                },
                       new Pytanie()
                {//7
                           Odpowiedzi = new List<string>(){"17","nic","12","16"},
                     PoprawnaOdpowiedz = "12",
                },
                          new Pytanie()
                {//8
                              Odpowiedzi = new List<string>(){"motyl","szlaczek","nic"},
                     PoprawnaOdpowiedz = "motyl",
                },
                             new Pytanie()
                {//9
                                 Odpowiedzi = new List<string>(){"16", "15", "nic", "45"},
                     PoprawnaOdpowiedz = "45",
                },
                         new Pytanie()
                {//10
                             Odpowiedzi = new List<string>(){"gwiazda","słoń","szlaczek","nic"},
                     PoprawnaOdpowiedz = "słoń",
                },
            };
        }
        [HttpPost]
        public ActionResult Wyswietl()
        {
            List<Logowanie> model = new List<Logowanie>();
            SqlConnection dalton = new SqlConnection(@"Data Source=LAPTOP-8130R9Q0\SQLEXPRESS;Initial Catalog=DaltoQuiz;Integrated Security=True");
            dalton.Open();
            //SqlCommand dodaj = new SqlCommand("SELECT * FROM Wyniki", dalton);
            //SqlDataAdapter adpater = new SqlDataAdapter(dodaj);
            //dodaj.ExecuteReader();
            //dalton.Close();
            SqlCommand dodaj = new SqlCommand("SELECT * FROM Wyniki", dalton);
            SqlDataAdapter wyswietl = new SqlDataAdapter("SELECT * FROM Wyniki", dalton);
            DataTable dt = new DataTable();
            wyswietl.Fill(dt);
            return View(dt);
        }
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Logowanie account)
        {
            if (ModelState.IsValid)
            {
                    
                ModelState.Clear();
                ViewBag.Message = account.Nazwa_uzytkownika + "Rejestracja zakończona sukcesem.";
            }
            return View(); 
        }
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Logowanie nazwaUzytkownika)
        {
            //Logowanie baza = new Logowanie();
            for (int i = 0; i < ListaPytan.Count; i++)
            {
                //if (ListaPytan[i].PoprawnaOdpowiedz )
                //{


                //}
            }
            if (ModelState.IsValid)
            {

                // dodanie do bazy i zalogowanie
                nazwaUzytkownika.DodajWynik();
                nazwaUzytkownika.DodajOsobe();
                return RedirectToAction("Pytania");
            }
            else
            {
                return View(nazwaUzytkownika);
            }  
        }
        
        public ActionResult Pytania()
        {
            
            var pytanie = ListaPytan[0];
            return View(pytanie);
        }

        [HttpGet]
        public ActionResult SprawdzOdpowiedz(string odpowiedz, int pytanieId)
        {
            // zwalidowanie poprawności odpowiedzi

            return RedirectToAction("Pytanie" + (pytanieId+1));
        }

        public ActionResult Pytanie1()
        {
            var pytanie = ListaPytan[1];
            return View(pytanie);
        }


        [HttpGet]
        public ActionResult SprawdzOdpowiedz1(string odpowiedz, int pytanieId)
        {
            // zwalidowanie poprawności odpowiedzi

            return RedirectToAction("Pytanie" + (pytanieId + 2));
        }
        public ActionResult Pytanie2()
        {
            var pytanie = ListaPytan[2];
            return View(pytanie);
        }


        [HttpGet]
        public ActionResult SprawdzOdpowiedz2(string odpowiedz, int pytanieId)
        {
            // zwalidowanie poprawności odpowiedzi

            return RedirectToAction("Pytanie" + (pytanieId + 3));
        }
        public ActionResult Pytanie3()
        {
            var pytanie = ListaPytan[3];
           
            return View(pytanie);
        }


        [HttpGet]
        public ActionResult SprawdzOdpowiedz3(string odpowiedz, int pytanieId)
        {
            // zwalidowanie poprawności odpowiedzi

            return RedirectToAction("Pytanie" + (pytanieId + 4));
        }
        public ActionResult Pytanie4()
        {
            var pytanie = ListaPytan[4];
            return View(pytanie);
        }


        [HttpGet]
        public ActionResult SprawdzOdpowiedz4(string odpowiedz, int pytanieId)
        {
            // zwalidowanie poprawności odpowiedzi

            return RedirectToAction("Pytanie" + (pytanieId + 5));
        }
        public ActionResult Pytanie5()
        {
            var pytanie = ListaPytan[5];
            return View(pytanie);
        }


        [HttpGet]
        public ActionResult SprawdzOdpowiedz5(string odpowiedz, int pytanieId)
        {
            // zwalidowanie poprawności odpowiedzi

            return RedirectToAction("Pytanie" + (pytanieId + 6));
        }
        public ActionResult Pytanie6()
        {
            var pytanie = ListaPytan[6];
            return View(pytanie);
        }


        [HttpGet]
        public ActionResult SprawdzOdpowiedz6(string odpowiedz, int pytanieId)
        {
            // zwalidowanie poprawności odpowiedzi

            return RedirectToAction("Pytanie" + (pytanieId + 7));
        }
        public ActionResult Pytanie7()
        {
            var pytanie = ListaPytan[7];
            return View(pytanie);
        }


        [HttpGet]
        public ActionResult SprawdzOdpowiedz7(string odpowiedz, int pytanieId)
        {
            // zwalidowanie poprawności odpowiedzi

            return RedirectToAction("Pytanie" + (pytanieId + 8));
        }
        public ActionResult Pytanie8()
        {
            var pytanie = ListaPytan[8];
            return View(pytanie);
        }


        [HttpGet]
        public ActionResult SprawdzOdpowiedz8(string odpowiedz, int pytanieId)
        {
            // zwalidowanie poprawności odpowiedzi

            return RedirectToAction("Pytanie" + (pytanieId + 9));
        }
        public ActionResult Pytanie9()
        {
            var pytanie = ListaPytan[9];
            return View(pytanie);
        }

        [HttpGet]
        public ActionResult SprawdzOdpowiedz9(string odpowiedz, int pytanieId)
        {
            // zwalidowanie poprawności odpowiedzi

            return RedirectToAction("Wynik");
        }
        public ActionResult Wynik()
        {
            return View();
        }
    }
}


   