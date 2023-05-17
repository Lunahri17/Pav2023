#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void DoWork()
        {
            /*int i = 0;
            Console.WriteLine(i);
            Pass.Value(i);
            Console.WriteLine(i);
            */

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);


            int? i = null;
            int i2 = i ?? 0;

        }

        static void Main(string[] args)
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
