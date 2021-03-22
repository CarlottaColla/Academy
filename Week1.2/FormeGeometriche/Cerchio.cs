using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.FormeGeometriche
{
    public class Cerchio : Forme
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Raggio { get; set; }

        //Metodi
        public override double CalcolaArea()
        {
            return Math.PI * Raggio * Raggio;
        }

        public override void DisegnaForma()
        {
            Console.WriteLine($"Questo è un {Nome} con raggio = {Raggio}, area = {CalcolaArea()} e centro in ({X},{Y})");
        }

        public override void SaveToFile(string fileName)
        {
            Console.WriteLine("SaveToFile di cerchio: " + fileName);
        }

        public override void LoadFromFile(string fileName)
        {
            Console.WriteLine("LoadFromFile di cerchio: " + fileName);
        }

    }
}
