using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Margono : KeluargaMargono
    {
        public override void tampilkan()
        {
            Console.WriteLine("Margono adalah kepala keluarga dari Keluarga Margono.");
            Console.WriteLine("Margono lahir di Klaten , 26 Maret 1962.");
            Console.WriteLine("Pekerjaan sehari-hari adalah bengkel.");
        }
    }
}
