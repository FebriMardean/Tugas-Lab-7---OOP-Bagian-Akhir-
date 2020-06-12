using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Laras : KeluargaMargono
    {
        public override void tampilkan()
        {
            Console.WriteLine("Biasa dipanggil Laras, dan menjadi anak ketiga dari pasangan Margono dan Anis.");
            Console.WriteLine("Lahir di Sleman, 9 November 2008.");
            Console.WriteLine("Sekolah Dasar di SD Muhammadiyah Kadisoka kelas 5A.");
        }
    }
}
