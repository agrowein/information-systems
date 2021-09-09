using System;
using System.IO;
using System.Collections;

namespace Task_2
{
    public class FileWorker
    {
        private StreamReader sr;

        public FileWorker(string pathToFile)
        {
            try
            {
                this.sr = new StreamReader(pathToFile, System.Text.Encoding.UTF8);
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new Exception("Could not find file");
            }
        }

        public Array ReadLines()
        {
            ArrayList list = new ArrayList();
            string line;
            while ((line = this.sr.ReadLine()) != null)
            {
                list.Add(line);
            }

            Array output = list.ToArray(typeof(string));
            return output;
        }

        public Result ReduceLines()
        {
            Array array = this.ReadLines();
            double acc = 0;
            int count = 0;
            foreach (var item in array)
            {
                try
                {   var num = ((string)item).Trim();
                    if (num == "") 
                    {
                        continue;
                    }
                    acc += Double.Parse(num);
                    count++;
                }
                catch (System.FormatException)
                {
                    throw new Exception("invalid nubmer value");
                }
                
            }
            return new Result(((int)acc), count);
        }


        // Result contains two variable
        public class Result
        {
            private int accomulator;
            private int count;
            
            public int Accomulator { get { return accomulator; } }
            public int Count { get { return count; } }

            public Result(int acc, int count) {
                this.count = count;
                this.accomulator = acc;
            }
        }
    }
}