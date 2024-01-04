using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            CellPhoneBuildercs builder = new CellPhoneBuildercs();
            builder.SetOS("Android");
            builder.SetCamera(20);
            CellPhone phone = builder.GetPhone(); 
            Console.WriteLine(phone);
        }
    }
}
