using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.Methods
{
    public interface IEventLogger
    {
        void LogEvent(string message);
    }
}
