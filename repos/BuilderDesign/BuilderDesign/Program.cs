using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CellPhone phone = new CellPhoneBuilder().SetOS("Android").SetCamera(20).GetPhone();
           
            Console.WriteLine(phone);
            Console.ReadLine();
        }
    }
}
