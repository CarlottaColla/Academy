using System;
using System.Collections.Generic;
using System.Text;
using Week1._2.Classi.Iterfacce;

namespace Week1._2.Classi
{
    public class Persona : ILogging
    {
        //Campi
        private string _cf;

        //Proprietà
        public string CF 
        { 
            get { return _cf; } 
            set { _cf = value; } 
        }

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNat { get; set; }
        public int NFigli { get; set; }

        //Metodi
        public virtual string FullName (string titolo)
        {
            return "[" + titolo + "]" + " " + Nome + " " + Cognome;
        }

        public void LogError(string messaggio)
        {
            Console.WriteLine("[ERROR] " + messaggio);
        }

        public void LogInfo(string messaggio)
        {
            Console.WriteLine("[INFO] " + messaggio);
        }

        public void LogWarning(string messaggio)
        {
            Console.WriteLine("[WARNING] " + messaggio);
        }
    }
}
