using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaModerna
{
    public interface IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }

        public string Denominazione { get; }
    }
}
