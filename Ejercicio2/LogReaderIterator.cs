using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    class LogReaderIterator: IEnumerator<LogLine>
    {
        private int counter = 0;
        private int sizeLogLines;
        private int sizeUniqueIps;

        public LogReaderIterator(int sizeLogLines, int sizeUniqueIps)
        {
            this.sizeLogLines = sizeLogLines;
            this.sizeUniqueIps = sizeUniqueIps;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public LogLine Current
        {
            get
            {
                try
                {
                    return new LogLine(this.counter % this.sizeUniqueIps);
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        /*public bool HasNext()
        {
            
        }*/

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            this.counter++;
            return this.counter < this.sizeLogLines;

            /*if (this.HasNext())
            {
                this.counter++;
                return new LogLine(this.counter % this.sizeUniqueIps);
            }
            throw new InvalidOperationException();*/
        }

        public void Reset()
        {
            //throw new NotImplementedException();
        }
    }
}
