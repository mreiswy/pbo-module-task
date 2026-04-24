# Sistem Manajemen Sekolah (OOP C#)

Sebuah aplikasi *console* interaktif berbasis C# yang mendemonstrasikan implementasi pilar-pilar Pemrograman Berorientasi Objek (OOP) secara terstruktur. Proyek ini mensimulasikan ekosistem sekolah sederhana yang terdiri dari berbagai entitas akademik.

## Konsep OOP yang Diimplementasikan

Proyek ini dibangun untuk mempraktikkan konsep-konsep inti OOP:
* **Inheritance (Pewarisan):** Kelas `Siswa` dan `Guru` mewarisi properti dasar (seperti Nama dan Umur) dari kelas induk `Orang`.
* **Polymorphism (Polimorfisme):** Implementasi *Dynamic Binding* pada metode `Aktivitas()`. Sistem dapat secara dinamis membedakan aktivitas spesifik (belajar, mengajar, bermain, ujian) berdasarkan tipe objek aslinya saat *runtime*.
* **Aggregation (Agregasi):** Relasi *has-a* antara `Sekolah` dan `Orang`. Sekolah menampung koleksi daftar warga sekolah, namun entitas individu tetap independen.
* **Encapsulation (Enkapsulasi):** Penggunaan *access modifiers* secara ketat untuk melindungi data sensitif dan mengekspos fungsi hanya melalui *public methods*.

## Struktur Hierarki Kelas
<img width="300" height="300" alt="image" src="https://github.com/user-attachments/assets/f6e9fdab-a432-472d-b359-6894a4f815b9" />

- `Orang` (Parent Class)
  - `Siswa` (Child Class)
    - `SiswaSD`
    - `SiswaSMA`
  - `Guru` (Child Class)
    - `GuruMatematika`
    - `GuruBahasa`
- `Sekolah` (Aggregator / System Manager)

## Cara Menjalankan Program

1. Pastikan Anda telah menginstal [.NET SDK](https://dotnet.microsoft.com/download) di sistem Anda.
2. *Clone* repositori ini ke mesin lokal Anda:
   ```bash
   git clone https://github.com/mreiswy/pbo-module-task.git
