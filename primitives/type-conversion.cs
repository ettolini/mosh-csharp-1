using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Type Conversion
            byte b = 1; // 00000001
            int i = b; // 00000000 00000000 00000000 00000001
            // Byte takes a byte of memory, on the other hand, int takes four. So, a byte value can be converted so
            // you can store it inside an int variable. The unused byte space will be filled with 0s.

            // Explicit Type Convertion
            int i2 = 1;
            // byte b2 = i2; won't compile
            // Data loss won't happen here, because 1 is a value that can be stored inside a byte variable. But,
            // the difference in byte capability DOES imply a possible data loss, and thus this operation
            // won't be implicitly allowed by the engine. So you'll have to do it explicitly...
            byte b2 = (byte)i2;

            // Non-compatible Types
            string s = "1";
            int i3 = Convert.ToInt32(s); // Int32 = int (because int uses 4 bytes, and every byte is worth 8 bits [4 * 8 = 32])
            int i4 = int.Parse(s); // The Parse Method takes a string and tries to convert that to the target's data type
            // ToByte() converts to a byte
            // ToInt16() converts to a short
            // ToInt32() converts to an integer
            // ToInt64() converts to a long
        }
    }
}
