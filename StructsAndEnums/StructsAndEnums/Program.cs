#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void DoWork()
        {
            Month first = Month.January;
            Console.WriteLine(first);
            Date weddingAnniversary = new Date(2013, Month.July, 4);
            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");
            weddingAnniversary.AdvanceMonth();
            Console.WriteLine("New value of weddingAnniversary is {0}", weddingAnniversary);
            Console.WriteLine("Value of copy is still {0}", weddingAnniversaryCopy);
        }

        static void Main()
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
