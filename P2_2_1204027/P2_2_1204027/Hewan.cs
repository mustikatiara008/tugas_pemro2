using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204027
{
    class Hewan
    {
        public string jenisHewan;
        public int tinggiRatarata;
        public int jumlahKaki;
        public string warnaBulu;

        // method yang tidak mengembalikan nilai
        public void TampilkanJenisHewan()
        {
            Console.WriteLine("Jenis Hewan : " + this.jenisHewan);
        }

        // method yang mengembalikan nilai
        public int DapatkanJumlahPasanganKaki()
        {
            int jumlahPasanganKaki = this.jumlahKaki / 2;
            return jumlahPasanganKaki;
        }
    }
}
