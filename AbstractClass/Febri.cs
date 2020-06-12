using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Febri : KeluargaMargono
    {
        public override void tampilkan()
        {
            Console.WriteLine("Biasa dipanggil Febri, dan menjadi anak kedua dari pasangan Margono dan Anis.");
            Console.WriteLine("Lahir di Sleman, 19 Februari 2001");
            Console.WriteLine("Kuliah S1 di Universitas Amikom Yogyakarta dan mengambil prodi Informatika.");
        }
    }
}
