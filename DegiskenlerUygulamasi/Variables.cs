using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenlerUygulamasi
{
    public static class Variables
    {
        public static void AnaKod()
        {
            byte minByte = byte.MinValue;
            byte maxByte = byte.MaxValue;

            char minChar = char.MinValue;
            char maxChar = char.MaxValue;

            int minInt16 = Int16.MinValue;
            int maxInt16 = Int16.MaxValue;

            int minUInt16 = UInt16.MinValue;
            int maxUInt16 = UInt16.MaxValue;

            int minInt32 = Int32.MinValue;
            int maxInt32 = Int32.MaxValue;


            UInt32 minUInt32 = UInt32.MinValue;
            UInt32 maxUInt32 = UInt32.MaxValue;

            Int64 minInt64 = Int64.MinValue;
            Int64 maxInt64 = Int64.MaxValue;

            UInt64 minUInt64 = UInt64.MinValue;
            UInt64 maxUInt64 = UInt64.MaxValue;

            IntPtr minIntPtr = IntPtr.MinValue;
            IntPtr maxIntPtr = IntPtr.MaxValue;

            UIntPtr minUIntPtr = UIntPtr.MinValue;
            UIntPtr maxUIntPtr = UIntPtr.MaxValue;

            long minLong = long.MinValue;
            long maxLong = long.MaxValue;

            ulong minULong = ulong.MinValue;
            ulong maxULong = ulong.MaxValue;

            float minFloat = float.MinValue;
            float maxFloat = float.MaxValue;

            double minDouble = double.MinValue;
            double maxDouble = double.MaxValue;

            decimal minDecimal = decimal.MinValue;
            decimal maxDecimal = decimal.MaxValue;

            //Console.WriteLine("Minimum Byte Değer \t: {0} \n\rMaximum Byte Değer \t: {1}\n\r", minByte,maxByte);
            //Console.WriteLine("Minimum Int16 Değer \t: {0} \n\rMaximum Int16 Değer \t: {1}\n\r", minInt16, maxInt16);
            //Console.WriteLine("Minimum Int32 Değer \t: {0} \n\rMaximum Int32 Değer \t: {1}\n\r", minInt32, maxInt32);
            //Console.WriteLine("Minumum Float Değer \t: {0} \n\rMaximum Float Değer \t: {1}\n\r", minFloat, maxFloat);
            //Console.WriteLine("Minumum Double Değer \t: {0} \n\rMaximum Double Değer \t: {1}\n\r", minDouble, maxDouble);
            //Console.WriteLine("Minumum Decimal Değer \t: {0} \n\rMaximum Decimal Değer \t: {1}", minDecimal, maxDescimal);
            Yaz("Byte", minByte, maxByte, minByte.GetType());
            Yaz("Char", minChar, maxChar, minChar.GetType());
            Yaz("Int16", minInt16, maxInt16, maxInt16.GetType());
            Yaz("UInt16", minUInt16, maxUInt16, maxUInt16.GetType());
            Yaz("Int32", minInt32, maxInt32, maxInt32.GetType());
            Yaz("UInt32", minUInt32, maxUInt32, maxUInt32.GetType());
            Yaz("Int64", minInt64, maxInt64, maxInt64.GetType());
            Yaz("UInt64", minUInt64, maxUInt64, maxUInt64.GetType());
            Yaz("IntPtr", minIntPtr, maxIntPtr, maxIntPtr.GetType());
            Yaz("UIntPtr", minUIntPtr, maxUIntPtr, maxUIntPtr.GetType());
            Yaz("Long", minLong, maxLong, maxLong.GetType());
            Yaz("ULong", minULong, maxULong, maxULong.GetType());
            Yaz("Float", minFloat, maxFloat, maxFloat.GetType());
            Yaz("Double", minDouble, maxDouble, maxDouble.GetType());
            Yaz("Decimal", minDecimal, maxDecimal, maxDecimal.GetType());

        }
        static void Yaz(string tur, object min, object max, Type type)
        {
            Console.WriteLine($"Minimum {tur} Değer \t: {min} \n\rMaximum {tur} Değer \t: {max}\n\rTip \t\t\t:{type.FullName}\n\r");
        }

    }
}
