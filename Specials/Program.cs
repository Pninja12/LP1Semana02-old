using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sbyte Max Value = {sbyte.MaxValue} and Min Value = {sbyte.MinValue}");
            Console.WriteLine($"Short Max Value = {short.MaxValue} and Min Value = {short.MinValue}");
            Console.WriteLine($"Int Max Value = {int.MaxValue} and Min Value = {int.MinValue}");
            Console.WriteLine($"Long Max Value = {long.MaxValue} and Min Value = {long.MinValue}");
            Console.WriteLine($"Byte Max Value = {byte.MaxValue} and Min Value = {byte.MinValue}");
            Console.WriteLine($"Ushort Max Value = {ushort.MaxValue} and Min Value = {ushort.MinValue}");
            Console.WriteLine($"Uint Max Value = {uint.MaxValue} and Min Value = {uint.MinValue}");
            Console.WriteLine($"Ulong Max Value = {ulong.MaxValue} and Min Value = {ulong.MinValue}");
            Console.WriteLine($"Char Max Value = {char.MaxValue} and Min Value = {char.MinValue}");
            Console.WriteLine($"Positive infinity = {double.PositiveInfinity} and negative infinity = {double.NegativeInfinity}");
            Console.WriteLine($"Nan = {double.PositiveInfinity / double.PositiveInfinity}");
            int i = short.MaxValue;
            Console.WriteLine($"{i} + 1 = {(short)(i + 1)}");
            float f1 , f2 ;
            f1 = f2 = 10000.0f;
            Console.WriteLine(f1 == f2 + 0.000009f);
        }
    }
}
