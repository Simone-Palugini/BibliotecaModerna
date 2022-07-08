using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaModerna
{
    public class Biblioteca
    {
        public static IUtente[] utenti;

        public static void StampaUtente()
        {
            foreach(IUtente u in utenti)
            {
                Console.WriteLine(u.Denominazione);
            }           
        }
    }
}
