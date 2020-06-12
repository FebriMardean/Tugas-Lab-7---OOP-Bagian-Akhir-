using Abstraction.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract Class
//namespace AbstractionAbstractClass

//Abstraction Interface
namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class
            //IKeluargaMargono keluarga;

            //Abstraction Interface
            IKeluargaMargono Keluarga;
            Console.WriteLine("Profil Keluarga Margono");
            Console.WriteLine("1. Margono");
            Console.WriteLine("2. Anis");
            Console.WriteLine("3. Rifqi");
            Console.WriteLine("4. Febri");
            Console.WriteLine("5. Laras\n");


            Console.WriteLine("Pilih Prof [1..5]: ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            if (pilihan == 1)
                Keluarga = new Margono();
            else if (pilihan == 2)
                Keluarga = new Anis();
            else if (pilihan == 3)
                Keluarga = new Rifqi();
            else if (pilihan == 4)
                Keluarga = new Febri();
            else 
                Keluarga = new Laras();

            Keluarga.tampilkan();

            Console.ReadKey();
        }
    }
}
