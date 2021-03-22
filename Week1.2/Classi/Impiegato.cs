using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.Classi
{
    public class Impiegato : Persona
    {
        public string Dettagli()
        {
            return Cognome + "(" + NFigli + ")";
        }

        public override string FullName(string titolo)
        {
            return "[Impiegato] " + Nome + " " + Dettagli();
        }
    }
}
