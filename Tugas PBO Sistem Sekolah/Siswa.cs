using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    public class Siswa : Orang
    {
        public string Kelas { get; set; }

        public Siswa(string nama, int umur, string kelas) : base(nama, umur)
        {
            Kelas = kelas;
        }

        public void Belajar()
        {
            Console.WriteLine($"{Nama} sedang fokus belajar di kelas {Kelas}.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} beraktivitas sebagai siswa, yaitu menuntut ilmu.");
        }
    }
    public class SiswaSD : Siswa
    {
        public SiswaSD(string nama, int umur, string kelas) : base(nama, umur, kelas) { }
        public void Main()
        {
            Console.WriteLine($"{Nama} sedang main kejar-kejaran saat jam istirahat SD.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} adalah Siswa SD yang aktif bermain dan belajar membaca.");
        }
    }

    public class SiswaSMA : Siswa
    {
        public SiswaSMA(string nama, int umur, string kelas) : base(nama, umur, kelas) { }

        public void UjianNasional()
        {
            Console.WriteLine($"{Nama} sedang tegang mengikuti ujian akhir.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} adalah Siswa SMA yang sibuk persiapan ujian akhir dan kuliah.");
        }
    }
}
