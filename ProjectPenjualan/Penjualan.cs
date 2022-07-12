using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        // PERINTAH: lengkapi property class penjualan, sesuai petunjuk soal
        public string nota
        {
            get; set;
        }
        public string tanggal
        {
            get; set;
        }
        public string nama
        {
            get; set;
        }
        public string jenisPembayaran
        {
            get; set;
        }
        public int total
        {
            get; set;
        }

        public Penjualan(string nota, string tanggal, string nama, string jenisPembayaran, int total)
        {
            this.nota = nota;
            this.nama = nama;
            this.tanggal = tanggal;
            this.jenisPembayaran = jenisPembayaran;
            this.total = total;
            Console.WriteLine("Data Berhasil ditambahkan !");
            Console.WriteLine();
        }
    }
}

