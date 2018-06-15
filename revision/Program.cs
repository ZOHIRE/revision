using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    class Program
    {
        static void Main(string[] args)
        {
            float flminvar = float.MinValue;
            float flmaxvar = float.MaxValue;
            Console.WriteLine("     \n\n MinVlue       = {0}     \n MaxVlue = {1}", flminvar, flmaxvar);

            int charmin = char.MinValue;
            int charmax = char.MaxValue;
            char myvar = 'G';
            int myvarvalue = 'G';
            char myvarvalue2 = Convert.ToChar(myvarvalue);

            Console.WriteLine("\n\n\n\n   Min char = {0}  \n   Max char = {1} \n   my character = {2} \n   my variable number = {3}\n   my convert = {4} ", charmin, charmax, myvar, myvarvalue, myvarvalue2);



            string mystring = "this is my variable";
            Console.WriteLine("\n\n my string is {0}", mystring);

            Boolean myboolvar = true;
            Console.WriteLine("\n\n my boolea value is {0}", myboolvar);

            int myvarvalue3 = 'A';
            int myvarvalue4 = 'a';

            string mystringA = "this is my variable A";
            string mystringa = "this is my variable a";
            string _mystring7 = "zohire has said \" i lov you \",and I \fthink so";

            Console.WriteLine("\n\n\n my variable number = {0}\n my variable number = {1}\n\n my string is {2}\n\nmy string is {3}\n\n {4}", myvarvalue3, myvarvalue4, mystringA, mystringa, _mystring7);

            string mystringx = "this is my character A value 65 and this is my character a value 97";
            Console.WriteLine("{0}", mystringx);


            Console.WriteLine("this is my character A value 65 and this is my character a value 97");

            int _myvar = -7;
            uint _myuvar = 8u;
            long myLVar = 1000L;
            ulong myulvar = 1000;
            ulong myulvar1 = 1000UL;
            ulong myulvar2 = 1000LU;
            ulong myulvar3 = 1000Lu;
            ulong myulvar4 = 1000ul;
            ulong myulvar5 = 1000L;



            float flvar = 7.6f;
            float myflvar = 10f / 3;
            double dlvar = 10D / 3;
            double dlvar1 = 1000.5D;
            decimal decvar = 10M / 3;
            decimal decvar1 = 1000.5M;
            Console.WriteLine($"\n{_myvar},\n{_myuvar},\n{myLVar},\n{myulvar},\n{myulvar1},\n{myulvar2},\n{myulvar3},\n{myulvar4},\n{myulvar5},\n{flvar},\n{myflvar},\n{dlvar},\n{dlvar1},\n{decvar},\n{decvar1}");

            int mychar = char.MaxValue;
            int mychar2 = char.MinValue;


            int _myvarvalue = int.MaxValue;
            int _myvarvalue2 = int.MinValue;
            uint myuint1 = uint.MinValue;
            uint myuint2 = uint.MaxValue;


            long _myvar1 = long.MinValue;
            long _myvar2 = long.MaxValue;
            ulong myulong1 = ulong.MaxValue;
            ulong myulong2 = ulong.MinValue;

            short _myshvar = short.MaxValue;
            short myshvar = short.MinValue;
            ushort myushvar1 = ushort.MinValue;
            ushort myushvar2 = ushort.MaxValue;

            byte mybyt1 = byte.MinValue;
            byte mybyt2 = byte.MaxValue;


            sbyte mysmolbyt1 = sbyte.MinValue;
            sbyte mysmolbyt2 = sbyte.MaxValue;


            Console.WriteLine($"\n\nmax char={mychar},\tmin char={mychar2},\n\nmax int={_myvarvalue},\tmin int={_myvarvalue2},min uint={myuint1},\tmax uint={myuint2},\n\nmin long={_myvar1},\tmax long={_myvar2}\n\nmax ulong={myulong1},\tmin ulong={myulong2},\n\nmax short={_myshvar},\tmin short={myshvar}\n\nminushort={myushvar1},\tmax ushort={myushvar2}\n\nmin byte={mybyt1},\tmax byte={mybyt2}\n\nmin smolbyte={mysmolbyt1},\tmax smolbyte{mysmolbyt2}");


            string mystr = " my name is mostafa";
            Console.WriteLine($"{mystr}");


            Console.ReadKey();
        }
    }
}
    

