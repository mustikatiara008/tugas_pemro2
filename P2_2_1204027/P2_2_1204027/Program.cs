using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204027
{
    class Program
    {
        static void Main(string[] args)
        {
            Hewan kucing = new Hewan();

            kucing.jenisHewan = "Kucing Persia";
            kucing.tinggiRatarata = 30;
            kucing.jumlahKaki = 4;
            kucing.warnaBulu = "Coklat";

            kucing.TampilkanJenisHewan();
            Console.WriteLine("Jumlah Pasang Kaki : " + kucing.DapatkanJumlahPasanganKaki());
            Console.WriteLine("Tinggi rata-rata : " + kucing.tinggiRatarata + " CM");
            Console.WriteLine("Warna bulu : " + kucing.warnaBulu);
            Console.ReadKey();
        }
    }
}
