using System;

namespace Task3
{
    struct MyStruct
    {
        public decimal a;
        public int b;
        public int c;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№1");
            Console.WriteLine("Size of int = {0}", sizeof(int));
            Console.WriteLine("Size of char = {0}", sizeof(char));
            Console.WriteLine("Size of bool = {0}", sizeof(bool));
            Console.WriteLine("Size of double = {0}", sizeof(double));
            Console.WriteLine("Size of long = {0}", sizeof(long));
            Console.WriteLine("Size of ulong = {0}", sizeof(ulong));
            Console.WriteLine("Size of byte = {0}", sizeof(byte));
            Console.WriteLine("Size of sbyte = {0}", sizeof(sbyte));
            Console.WriteLine("Size of short = {0}", sizeof(short));
            Console.WriteLine("Size of ushort = {0}", sizeof(ushort));
            Console.WriteLine("Size of uint = {0}", sizeof(uint));
            Console.WriteLine("Size of float = {0}", sizeof(float));
            Console.WriteLine("Size of decimal = {0}", sizeof(decimal));

            Console.WriteLine("№2");

            Console.WriteLine("Size of int using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf(1));
            Console.WriteLine("Size of char using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf((char)'a'));
            Console.WriteLine("Size of bool using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf((bool)true));
            Console.WriteLine("Size of double using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf(10.4d));
            Console.WriteLine("Size of long using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf(-101L));
            Console.WriteLine("Size of ulong using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf(10ul));
            Console.WriteLine("Size of byte using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf((byte)1));
            Console.WriteLine("Size of sbyte using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf((sbyte)1));
            Console.WriteLine("Size of short using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf((short)1));
            Console.WriteLine("Size of ushort using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf((ushort)1));
            Console.WriteLine("Size of unit using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf(10u));
            Console.WriteLine("Size of float using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf(-3.4f));
            Console.WriteLine("Size of decimal using class: = {0} ", System.Runtime.InteropServices.Marshal.SizeOf(1.0M));

            Console.WriteLine("№3");
            MyStruct a = new MyStruct();
            Console.WriteLine("Size of my struct:  {0} ", System.Runtime.InteropServices.Marshal.SizeOf(a));
        }
    }
}
