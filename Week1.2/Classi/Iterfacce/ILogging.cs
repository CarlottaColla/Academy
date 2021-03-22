using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.Classi.Iterfacce
{
    public interface ILogging
    {
        void LogInfo(string messaggio);
        void LogWarning(string messaggio);
        void LogError(string messaggio);
    }
}
