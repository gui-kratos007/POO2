using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica a = new AgendaTelefonica("Guilherme");

            a.inserir("Guilherme", "3524536");
        }
    }
}
