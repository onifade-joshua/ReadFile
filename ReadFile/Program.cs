using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to read file using ReadAllText in System.IO; 
            string  FilePath = @"C:\Users\joshua\Documents\sample.txt";
            string text = File.ReadAllText(FilePath);
            Console.WriteLine(text);
        }
    }
}
