using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsuletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hanphone hp1 = new Hanphone();
            hp1.Hp = "Android";
            hp1.Merk = "Vivo";
            hp1.Emei = "3377-4678-7654";

            Console.WriteLine($"Type Handphone : {hp1.Hp}" + "\n" + $"Merk Handphone : {hp1.Merk}" + "\n" + $"Nomor Emei : {hp1.Emei}");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            Hanphone hp2 = new Hanphone();
            hp2.SetHanphone("Iphone", "Iphone 14 Promax");
            hp2.SetEmei("4873-7765-3246");
            Console.WriteLine(hp2);

            Console.ReadKey();
        }
    }
}
