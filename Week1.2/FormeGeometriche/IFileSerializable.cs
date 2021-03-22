using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.FormeGeometriche
{
    public interface IFileSerializable
    {
        void SaveToFile(string fileName);
        void LoadFromFile(string fileName);
    }
}
