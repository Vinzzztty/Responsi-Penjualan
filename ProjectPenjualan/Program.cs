using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilan Penjualan");
            Console.WriteLine("3. Keluar");
            Console.WriteLine();
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine();
            Console.WriteLine("Nota: ");
            string nota = Console.ReadLine();
            Console.WriteLine("Tanggal: ");
            string tanggal = Console.ReadLine();
            Console.WriteLine("Customer: ");
            string nama = Console.ReadLine();
            Console.WriteLine("Jenis (T/K):");
            string jenisPembayaran = Console.ReadLine();
            if (jenisPembayaran == "t" || jenisPembayaran == "T")
            {
                jenisPembayaran = "Tunai";
            }
            else if (jenisPembayaran == "K" || jenisPembayaran == "k")
            {
                jenisPembayaran = "kredit";
            }
            Console.WriteLine("Total Nota: ");
            int total = Convert.ToInt32(Console.ReadLine());
            daftarPenjualan.Add(new Penjualan(nota, tanggal, nama, jenisPembayaran, total));

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int counter = 1;
            Console.WriteLine("Data Penjualan !\n\n");
            foreach (Penjualan penjualan in daftarPenjualan)
            {

                Console.WriteLine(counter + ". " + penjualan.nota + ", " + penjualan.tanggal + ", " + penjualan.nama + ", " + penjualan.jenisPembayaran + ", " + penjualan.total);
                counter++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
