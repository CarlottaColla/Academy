using System;
using Week1._2.FormeGeometriche;

namespace Week1._2
{
    class Program
    {
        //Definizione delegate
        delegate int Somma(int primoNumero, int secondoNumero);
        static void Main(string[] args)
        {
            //Funzionalta.EserciziSulTipo();
            //Funzionalta.FormeGeometriche();
            //Funzionalta.Interf();
            //Funzionalta.FormeGeometriche2();

            //La uso come classe e le passo una funzione con la stessa firma
            Somma somma = new Somma(Funzionalta.MySum);
            //Somma somma2 = new Somma(Funzionalta.MySum3); da errore perchè ha tre parametri

            int risultato = somma(1, 2);
            int risultato2 = Funzionalta.MySum(1, 2);
        }
    }
}
