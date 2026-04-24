using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    class Program
    {
        static void Main(string[] args)
        {
            Sekolah SekolahMuncar = new Sekolah();

            SiswaSD siswa1 = new SiswaSD("Subar", 9, "3A");
            SiswaSMA siswa2 = new SiswaSMA("Subir", 17, "12 IPA");
            GuruMatematika guru1 = new GuruMatematika("Pak Subara", 45);
            GuruBahasa guru2 = new GuruBahasa("Bu Subaru", 38);

            Console.WriteLine("--- Proses Registrasi ---");
            SekolahMuncar.TambahOrang(siswa1);
            SekolahMuncar.TambahOrang(siswa2);
            SekolahMuncar.TambahOrang(guru1);
            SekolahMuncar.TambahOrang(guru2);

            SekolahMuncar.DaftarOrang();

            Console.WriteLine("=== DEMONSTRASI POLIMORFISME (Method Aktivitas) ===");

            foreach (Orang warga in SekolahMuncar.GetDaftarOrang())
            {
                warga.Aktivitas();
            }
            Console.WriteLine();

            Console.WriteLine("=== DEMONSTRASI METHOD KHUSUS ===");

            siswa1.Belajar();
            siswa1.Main();
            Console.WriteLine();

            siswa2.Belajar();
            siswa2.UjianNasional();
            Console.WriteLine();

            guru1.Mengajar();
            guru1.MengajarHitung();
            Console.WriteLine();

            guru2.Mengajar();
            guru2.MengajarBahasa();

            Console.ReadLine();
        }
    }
}