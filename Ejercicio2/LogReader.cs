using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    class LogReader:IEnumerator<LogLine>
    {
        private int sizeLogLines;
        private int sizeUniqueIps;
        private ICollection<String> uniqueIps;

        public LogLine Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public LogReader(int sizeLogLines, int sizeUniqueIps, CollectionType collectionType)
        {
            this.sizeLogLines = sizeLogLines;
            this.sizeUniqueIps = sizeUniqueIps;
            this.uniqueIps = CollectionFactory.getCollection(collectionType);
        }

        public IEnumerator<LogLine> GetEnumerator()
        {
            return new LogReaderIterator(this.sizeLogLines, this.sizeUniqueIps);
        }

        
        public int ReadAllLogs()
        {
            int sizeLogLines = 0;

            foreach (LogLine line in this)                
            {
                String ip = line.getIP();
                sizeLogLines++;
            }
            return sizeLogLines;
        }

        public int GetSizeUniqueIps()
        {
            foreach (LogLine logLine in this)
            {
                String ip = logLine.getIP();
                if (!this.uniqueIps.Contains(ip))
                {
                    this.uniqueIps.Add(ip);
                }
            }

            return this.uniqueIps.Count();           
            
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
