using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.FormeGeometriche
{
    public class Triangolo : Forme
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        //Metodi
        
        public override double CalcolaArea()
        {
            return (Base * Altezza) / 2;
        }

        public override void DisegnaForma()
        {
            Console.WriteLine($"Questo è un {Nome} con base = {Base}, altezza = {Altezza} e area = {CalcolaArea()}");
        }

        public override void SaveToFile(string fileName)
        {
            Console.WriteLine("SaveToFile di triangolo: " + fileName);
        }

        public override void LoadFromFile(string fileName)
        {
            Console.WriteLine("LoadFromFile di triangolo: " + fileName);
        }
    }
}
