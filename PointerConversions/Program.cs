using System;

namespace PointerConversions
{
    class Program
    {
        //C# doesn't allow conversion between pointer types and objects,i.e no boxing and un-boxing. It however supports conversions between the different pointer types and pointer types and integral types.
        unsafe static void Main(string[] args)
        {
            char c = 'R';
            char* pc = &c;
            void* pv = pc; // Implicit conversion  
            int* pi = (int*)pv; // Explicit conversion using casting operator  
        }
    }
}
