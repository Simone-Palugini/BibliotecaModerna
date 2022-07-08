using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaModerna
{
    public class Organizzazione : IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string RagioneSociale { get; set; }

        public string Denominazione
        {
            get
            {
                return Id + " " + RagioneSociale;
            }
        }
    }
}
