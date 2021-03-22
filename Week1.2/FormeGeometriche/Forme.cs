using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.FormeGeometriche
{
    public abstract class Forme : IFileSerializable
    {
        public string Nome { get; set; }
        public virtual double CalcolaArea() { return 0; }
        public virtual void DisegnaForma() { }

        public abstract void LoadFromFile(string fileName);

        public abstract void SaveToFile(string fileName);
    }
}
