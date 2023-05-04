using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrado
{
    class Program
    {
        static void Main(string[] args)
        {
            long resultM, resultD, resultS, resultR;
            resultS = NachoOperaSyR.Class1.Suma(53,32);
            resultR = NachoOperaSyR.Class1.Resta(12, 4);
            resultM = NachoOperaMyD.Class1.Multiplicacion(3,4);
            resultD = NachoOperaMyD.Class1.Division(10, 2);
            Console.WriteLine(resultS.ToString());
            Console.WriteLine(resultR.ToString());
            Console.WriteLine(resultM.ToString());
            Console.WriteLine(resultD.ToString());
            Console.ReadKey();
        }
    }
}
