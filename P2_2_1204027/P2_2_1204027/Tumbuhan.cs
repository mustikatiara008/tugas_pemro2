using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204027
{
    class Tumbuhan
    {
        public string namaTumbuhan;
        public string jenisAkar;

        // method yang tidak mengembalikan nilai
        public void TampilkanNamaTumbuhan()
        {
            Console.WriteLine("Nama Tumbuhan : " + this.namaTumbuhan);
        }
    }
}