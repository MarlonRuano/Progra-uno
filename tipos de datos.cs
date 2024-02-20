using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_de_datos
{
    internal class Program
    {
        
        
         public static void Main(string[] args)
         {
            {
                sbyte byteConSigno = sbyte.MaxValue;
                byte byteSinSingo = byte.MaxValue;
                short shortConSingo = short.MaxValue;
                ushort shortSinSingo = ushort.MaxValue;
                int intConSingo = int.MaxValue;
                uint intSinSingo = uint.MaxValue;
                long longConSingo = long.MaxValue;
                ulong longSinSingo = ulong.MaxValue;
                float floatValor = float.MaxValue;
                double doubleValor = double.MaxValue;
                decimal decimalValor = decimal.MaxValue;

                Console.WriteLine("Max[sbyte]: {0} ", byteConSigno);
                Console.WriteLine("Max[byte]: {0} ", byteSinSingo);
                Console.WriteLine("Max[short]: {0} ", shortConSingo);
                Console.WriteLine("Max[ushort]: {0} ", shortSinSingo);
                Console.WriteLine("Max[int]: {0} ", intConSingo);
                Console.WriteLine("Max[uint]: {0} ", intSinSingo);
                Console.WriteLine("Max[long]: {0} ", longConSingo);
                Console.WriteLine("Max[ulong]: {0} ", longSinSingo);
                Console.WriteLine("Max[float]: {0} ", floatValor);
                Console.WriteLine("Max[double]: {0} ", doubleValor);
                Console.WriteLine("Max[decimal]: {0} ", decimalValor);
                Console.ReadLine();
            }
        }
    }
}
