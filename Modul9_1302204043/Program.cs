// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9_1302204043
{
    public class Program
    {
        static void Main()
        {
            int KPK = MatematikaLibraries.Class1.KPK(12,8);
            int FPB = MatematikaLibraries.Class1.FPB(60,45);
            Console.WriteLine(KPK);
            Console.WriteLine(FPB);
        }
    }
}