using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Byte --> MinValue = {byte.MinValue}, MaxValue = {byte.MaxValue}");
            Console.WriteLine($"SByte --> MinValue = {sbyte.MinValue}, MaxValue = {sbyte.MaxValue}");
            Console.WriteLine($"Short --> MinValue = {short.MinValue}, MaxValue = {short.MaxValue}");
            Console.WriteLine($"UShort --> MinValue = {ushort.MinValue}, MaxValue = {ushort.MaxValue}");
            Console.WriteLine($"Int --> MinValue = {int.MinValue}, MaxValue = {int.MaxValue}");
            Console.WriteLine($"UInt --> MinValue = {uint.MinValue}, MaxValue = {uint.MaxValue}");
            Console.WriteLine($"Long --> MinValue = {long.MinValue}, MaxValue = {long.MaxValue}");
            Console.WriteLine($"ULong --> MinValue = {ulong.MinValue}, MaxValue = {ulong.MaxValue}");
            Console.WriteLine($"Float --> MinValue = {float.MinValue}, MaxValue = {float.MaxValue}");
            Console.WriteLine($"Double --> MinValue = {double.MinValue}, MaxValue = {double.MaxValue}");
            Console.WriteLine($"Decimal --> MinValue = {decimal.MinValue}, MaxValue = {decimal.MaxValue}");
            Console.WriteLine($"Char --> MinValue = {char.MinValue}, MaxValue = {char.MaxValue}");
            Console.WriteLine($"Boolean --> MinValue = {bool.FalseString}, MaxValue = {bool.TrueString}");
            Console.WriteLine($"DateTime --> MinValue = {DateTime.MinValue}, MaxValue = {DateTime.MaxValue}");
            Console.WriteLine($"String --> There's no Min or MaxValue");
            Console.WriteLine($"Object --> There's no Min or MaxValue");
            Console.WriteLine($"Float --> NegativeInfinity = {float.NegativeInfinity}, PositiveInfinity = {float.PositiveInfinity}, NaN = {float.NaN}");
            Console.WriteLine($"Double --> NegativeInfinity = {double.NegativeInfinity}, PositiveInfinity = {double.PositiveInfinity}, NaN = {double.NaN}");
            Console.ReadLine();
        }
    }
}