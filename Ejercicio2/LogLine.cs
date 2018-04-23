using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    class LogLine
    {
        int counter;

        public LogLine(int counter)
        {
            this.counter = counter;
        }

        public String getIP()
        {
            return "ip-" + counter;
        }
    }
}
