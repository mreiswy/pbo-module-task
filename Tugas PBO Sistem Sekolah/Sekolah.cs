using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    public class Sekolah
    {
        private List<Orang> _daftarOrang;

        public Sekolah()
        {
            _daftarOrang = new List<Orang>();
        }

        public void TambahOrang(Orang orang)
        {
            _daftarOrang.Add(orang);
            Console.WriteLine($"[Sistem] {orang.Nama} berhasil ditambahkan ke daftar sekolah.");
        }
        public void DaftarOrang()
        {
            Console.WriteLine("\n=== DATA WARGA SEKOLAH ===");
            foreach (Orang orang in _daftarOrang)
            {
                orang.InfoOrang();
            }
            Console.WriteLine(" ");
        }
        public List<Orang> GetDaftarOrang()
        {
            return _daftarOrang;
        }
    }
}
