//17. Menghitung lama waktu download file
using System;

public class HitungWaktuDownload{
    public static void Main(string[] args){
        Console.WriteLine("===MENGHITUNG LAMA WAKTU UNDUH===");
       
        Console.Write("Masukkan besar file (Mb): ");
        double ukuranFile = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Masukkan kecepatan internet (Mbps): ");
        double internetMbps = Convert.ToDouble(Console.ReadLine());
        
        double internetMBps = internetMbps / 8; //konversi Mbps ke MBps (1 byte = 8 bit)
        
        double waktuUnduh = ukuranFile / internetMBps;
        
        int hari = (int)waktuUnduh / 86400;
        int jam = ((int)waktuUnduh % 86400) / 3600;
        int menit = ((int)waktuUnduh % 3600) / 60;
        double detik = waktuUnduh % 60;

        if (hari >= 1){
            Console.WriteLine($"Agar dapat mengunduh file {ukuranFile} Mb dengan kecepatan {internetMbps} Mbps, diperlukan waktu selama {hari} hari {jam} jam {menit} menit {detik} detik.");
        } else if (jam >= 1){
            Console.WriteLine($"Agar dapat mengunduh file {ukuranFile} Mb dengan kecepatan {internetMbps} Mbps, diperlukan waktu selama {jam} jam {menit} menit {detik} detik.");
        } else if (menit >= 1){
            Console.WriteLine($"Agar dapat mengunduh file {ukuranFile} Mb dengan kecepatan {internetMbps} Mbps, diperlukan waktu selama {menit} menit {detik} detik.");
        } else {
            Console.WriteLine($"Agar dapat mengunduh file {ukuranFile} Mb dengan kecepatan {internetMbps} Mbps, diperlukan waktu selama {detik} detik.");
        }

    }
}