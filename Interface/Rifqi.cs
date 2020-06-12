using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Rifqi : IKeluargaMargono
    {
        public void tampilkan()
        {
            Console.WriteLine("Biasa dipanggil rifqi, dan menjadi anak pertama dari pasangan Margono dan Anis.");
            Console.WriteLine("Lahir di Yogyakarta, 3 Desember 1994.");
            Console.WriteLine("Kuliah S2 di Universitas Ahmad Dahlan Yogyakarta dan mengambil prodi magister psikologi.");
        }
    }
}
