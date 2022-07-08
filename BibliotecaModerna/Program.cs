using System;

namespace BibliotecaModerna
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Id = "1234";
            p.AnnoIscrizione = 2022;
            p.Nome = "Simone";
            p.Cognome = "Palugini";

            Organizzazione org = new Organizzazione();
            org.Id = "5678";
            org.AnnoIscrizione = 2003;
            org.RagioneSociale = "sss";

            Biblioteca.utenti = new IUtente[] { p, org };

            Biblioteca.StampaUtente();
            Console.ReadLine();
        }       
    }
}
