using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tester
    {
        private Itask task;
        private string path;

        public Tester(Itask task, string path)
        {
            this.task = task;
            this.path = path;
        }

        public void RunTests()
        {
            int nr = 0;
            while (true)
            {
                string inFile = $"{path}\\test.{nr}.in";
                string outFile = $"{path}\\test.{nr}.out";
                if (!System.IO.File.Exists(inFile) ||
                    !System.IO.File.Exists(outFile))
                    break;
                bool result = RunTests(inFile, outFile);
                Console.WriteLine($"Test #{nr} - {result}");
                nr++;
            }
        }

        private bool RunTests(string inFile, string outFile)
        {
            try
            {
                string[] data = System.IO.File.ReadAllLines(inFile);
                string expect = System.IO.File.ReadAllText(outFile).Trim();
                string actual = task.Run(data).Trim();
                Console.WriteLine(expect);
                return expect == actual;
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
