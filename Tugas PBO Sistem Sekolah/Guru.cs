using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    public class Guru : Orang
    {
        public string MataPelajaran { get; set; }

        public Guru(string nama, int umur, string mataPelajaran) : base(nama, umur)
        {
            MataPelajaran = mataPelajaran;
        }

        public void Mengajar()
        {
            Console.WriteLine($"{Nama} sedang mengajar mata pelajaran {MataPelajaran}.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} beraktivitas sebagai guru, yaitu mendidik para siswa.");
        }
    }
    public class GuruMatematika : Guru
    {
        public GuruMatematika(string nama, int umur) : base(nama, umur, "Matematika") { }

        public void MengajarHitung()
        {
            Console.WriteLine($"{Nama} mengajarkan trik cepat berhitung aljabar.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} beraktivitas membuat soal-soal logika dan hitungan.");
        }
    }

    public class GuruBahasa : Guru
    {
        public GuruBahasa(string nama, int umur) : base(nama, umur, "Bahasa Indonesia") { }

        public void MengajarBahasa()
        {
            Console.WriteLine($"{Nama} mengajarkan cara menulis puisi dan esai yang baik.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} beraktivitas mengoreksi tugas karangan milik siswa.");
        }
    }
}
