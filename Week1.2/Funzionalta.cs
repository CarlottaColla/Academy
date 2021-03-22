using System;
using System.Collections.Generic;
using System.Text;
using Week1._2.Classi;
using Week1._2.Classi.Iterfacce;
using Week1._2.FormeGeometriche;

namespace Week1._2
{
    public enum State
    {
        New = 0,
        Open = 1,
        OnHold = 2,
        Closed = 3
    }
    public class Funzionalta
    {
        public static void EserciziSulTipo()
        {
            //Value vs Reference
            //Value:
            bool x = true;
            bool y = false;

            bool z = !x;

            Console.WriteLine($"Il valore di z è: {z}");

            int i = 0;
            int j = 34;

            int numero = 1 * (2 + 3) * 4;

            float f = 1f / 3f;
            double doub = 1d / 3d;
            decimal dec = 1m / 3m;

            Console.WriteLine($"float minimo {float.MinValue} e massimo {float.MaxValue}");

            //Date time
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today; //Data di oggi con orario di default
            DateTime date = new DateTime(2020, 12, 25);

            Console.WriteLine("Date: ");
            Console.WriteLine($"Now: {now}\nToday: {today}\nData: {date}");

            DateTime tomorrow = now.AddDays(1);
            DateTime In5Hours = now.AddHours(5);

            Console.WriteLine($"Tomorrow: {tomorrow}\nPiù 5 ore: {In5Hours}");

            //enum: dichiarato fuori dalla classe
            State myState = State.New;

            if (myState == State.New)
                Console.WriteLine("è uguale a new");

            //Reference
            string nome = " Carlotta Colla ";
            int count = nome.Length;
            string trim = nome.Trim(); //toglie gli spazi all'inizio e alla fine
            string sub = nome.Substring(0, 5);

            //classi
            Console.Clear();

            Persona persona1 = new Persona();
            persona1.Nome = "Mario";
            persona1.Cognome = "Rossi";
            persona1.CF = "MRARSS97D57G337F";
            persona1.DataNat = new DateTime(1997, 04, 17);

            Persona persona2 = new Persona()
            {
                Nome = "Anna",
                Cognome = "Bianchi",
                CF = "NNABNC98D45G445G"
            };

            Console.WriteLine(persona1.FullName("Sig.") + "\n" + persona2.FullName("Sig.ra"));

            Impiegato impiegato1 = new Impiegato()
            {
                Nome = "Luca",
                Cognome = "Verdi",
                CF = "VRDLCA78F28H883H",
                DataNat = new DateTime(1978, 11, 12),
                NFigli = 1
            };

            Console.WriteLine(impiegato1.FullName(""));

            Persona impiegato2 = new Impiegato()
            {
                Nome = "Alessia",
                Cognome = "Neri",
                CF = "NRELSS90F45J793L",
                DataNat = new DateTime(1989, 09, 2),
                NFigli = 3
            };

            Console.WriteLine(impiegato2.FullName("")); //Prende l'implementazione di impiegato

            Manager manager = new Manager();

        }

        public static void FormeGeometriche()
        {
            Triangolo triangolo = new Triangolo()
            {
                Base = 12,
                Altezza = 4
            };

            Cerchio cerchio = new Cerchio()
            {
                Raggio = 8,
                X = 3,
                Y = 5
            };

            Rettangolo rettangolo = new Rettangolo()
            {
                Larghezza = 7,
                Altezza = 3
            };

            cerchio.DisegnaForma();
            rettangolo.DisegnaForma();
            triangolo.DisegnaForma();
        }

        public static void Interf()
        {
            Persona persona1 = new Persona()
            {
                Nome = "Pio",
                Cognome = "Rossi"
            };

            persona1.LogInfo("Funziona");

            int x = 0;

            try
            {
                double num = 4 / x;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Persona persona2 = new Impiegato()
            {
                Nome = "Alice",
                Cognome = "Colella"
            };

            persona2.LogInfo("Funziona anche con impiegato");

            ILogging[] loggings = { persona2 };
            foreach(ILogging item in loggings)
            {
                item.LogInfo("Prova ciclo");
            }
        }

        public static void FormeGeometriche2()
        {
            //Cosa può fare              //Cos'è
            IFileSerializable cerchio = new Cerchio()
            {
                Nome = "Cerchio",
                Raggio = 2,
                X = 3,
                Y = 6
            };

            IFileSerializable rettangolo = new Rettangolo()
            {
                Nome = "Rettangolo",
                Larghezza = 10,
                Altezza = 3
            };

            IFileSerializable triangolo = new Triangolo()
            {
                Nome = "Triangolo",
                Altezza = 8,
                Base = 4
            };

            cerchio.SaveToFile("Test");
            Cerchio newCerchio = new Cerchio();
            newCerchio.LoadFromFile("Test");
            newCerchio.DisegnaForma();
            newCerchio.Nome = "Cerchio modificato";
            newCerchio.SaveToFile("Test");

            triangolo.SaveToFile("TestTriangolo");
            Triangolo newTriangolo = new Triangolo();
            newTriangolo.LoadFromFile("TestTriangolo");
            newTriangolo.DisegnaForma();
            newTriangolo.Nome = "Triangolo modificato";
            newTriangolo.SaveToFile("TestTriangolo");

            rettangolo.SaveToFile("TestRettangolo");
            Rettangolo newRettangolo = new Rettangolo();
            newRettangolo.LoadFromFile("TestRettangolo");
            newRettangolo.DisegnaForma();
            newRettangolo.Nome = "Rettangolo modificato";
            newRettangolo.SaveToFile("TestRettangolo");

        }

        public static int MySum(int a, int b)
        {
            return a + b;
        }
        public static int MySum3(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
