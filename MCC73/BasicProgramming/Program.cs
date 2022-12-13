using System;
public class Program
{
    public static void Main()
    {

        string ulang;
        do
        {
            string nama, jurusan;
            int jalur;
            double NIM;
            float uangkuliah, bayar, pengembalian;
            string[] jalurArr = { "SNMPTN", "SBMPTN", "MANDIRI" };

            Mahasiswa mahasiswa = new Mahasiswa();
            Console.Write("Nama Mahasiswa  : ");
            mahasiswa.nama = (Console.ReadLine());
            Console.Write("NIM  : ");
            mahasiswa.NIM = float.Parse(Console.ReadLine());

            Console.Write("Jurusan (Sistem Informasi/Hukum/Filsafat/Farmasi/Elektro/Komunikasi)  : ");
            mahasiswa.Jurusan = (Console.ReadLine());
            switch (mahasiswa.Jurusan)
            {
                case "Sistem Informasi":
                    break;
                case "Hukum":
                    break;
                case "Filsafat":
                    break;
                case "Farmasi":
                    break;
                case "Elektro":
                    break;
                case "Komunikasi":
                    break;
                default:
                    Console.WriteLine("Tidak terdeteksi");
                    break;
            }

            Console.WriteLine("Pilih Jalur : ");
            for (int i = 0; i < jalurArr.Length; i++)
            {
                int no = i + 1;
                Console.WriteLine(no + ". " + jalurArr[i]);
            }
            jalur = Convert.ToInt32(Console.ReadLine());
            switch (jalur)
            {
                case 1:
                    Console.WriteLine("Jalur Yang Anda Pilih SNMPTN");
                    Console.WriteLine("Uang Kuliah per semester = RP 2000000");
                    uangkuliah = 2000000;
                    Console.Write("Bayar  : ");
                    bayar = float.Parse(Console.ReadLine());
                    payment(uangkuliah, bayar);
                    break;
                case 2:
                    Console.WriteLine("Jalur Yang Anda Pilih SBMPTN");
                    Console.WriteLine("Uang Kuliah per semester = RP 3000000");
                    uangkuliah = 3000000;
                    Console.Write("Bayar  : ");
                    bayar = float.Parse(Console.ReadLine());
                    payment(uangkuliah, bayar);
                    break;
                case 3:
                    Console.WriteLine("Jalur Yang Anda Pilih MANDIRI");
                    Console.WriteLine("Uang Kuliah per semester = RP 5000000");
                    uangkuliah = 5000000;
                    Console.Write("Bayar  : ");
                    bayar = float.Parse(Console.ReadLine());
                    payment(uangkuliah, bayar);
                    break;

                default:
                    Console.WriteLine("Jalur masuk = Salah input");
                    break;
            }


            Console.WriteLine("\n===============================");
            Console.WriteLine("\n===============================");
            Console.WriteLine("Transaksi Berhasil ! Transaksi lagi ? (y/n)");

            ulang = Console.ReadLine();

        }
        while (ulang == "y");
        Biodata biodata = new Biodata();
        Console.WriteLine("Transaksi selesai..");
        Console.ReadLine();

    }
    public static void payment(float uangkuliah, float bayar)
    {
        float pengembalian = bayar - uangkuliah;
        if (bayar < uangkuliah)
        {
            Console.WriteLine("Maaf Uang Anda Tidak Cukup!!");
        }
        else
        {
            Console.WriteLine("Pengembalian : " + pengembalian);
            Console.WriteLine();
        }
    }

}


public class Mahasiswa
{
    public string nama { get; set; }
    public double NIM { get; set; }
    public string Jurusan { get; set; }
    public string Jalur { get; set; }
}

public class Biodata : Mahasiswa
{
    public string allowance;

}