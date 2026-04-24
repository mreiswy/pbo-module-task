using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    public class Orang
    {
        public string Nama { get; set; }
        public int Umur { get; set; }

        public Orang(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }
        public virtual void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas umum.");
        }
        public void InfoOrang()
        {
            Console.WriteLine($"Nama: {Nama} \t| Umur: {Umur} tahun");
        }
    }
}
