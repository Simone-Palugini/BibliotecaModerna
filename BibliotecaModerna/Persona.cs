﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaModerna
{
    public class Persona : IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string Denominazione
        {
            get
            {
                return Nome + " " + Cognome;
            }
        }
    }
}
