using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.FormeGeometriche
{
    public class Rettangolo : Forme
    {
        public double Larghezza { get; set; }
        public double Altezza { get; set; }

        //Metodi

        public override double CalcolaArea()
        {
            return Larghezza * Altezza;
        }

        public override void DisegnaForma()
        {
            Console.WriteLine($"Questo è un {Nome} con larghezza = {Larghezza}, altezza = {Altezza} e area = {CalcolaArea()}");
        }

        public override void SaveToFile(string fileName)
        {
            Console.WriteLine("SaveToFile di rettangolo: " + fileName);
        }

        public override void LoadFromFile(string fileName)
        {
            Console.WriteLine("LoadFromFile di rettangolo: " + fileName);
        }
    }
}
