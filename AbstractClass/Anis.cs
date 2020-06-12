using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Anis : KeluargaMargono
    {
        public override void tampilkan()
        {
            Console.WriteLine("Anis adalah istri dari Margono.");
            Console.WriteLine("Lahir di Yogyakarta, 14 Agustus 1968.");
            Console.WriteLine("Pekerjaan sehari-hari adalah pegawai swasta.");
        }
    }
}
