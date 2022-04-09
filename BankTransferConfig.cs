using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_1302201138
{
    internal class BankTransferConfig
    {

        public class CONFIG { 
            public string CONFIG1 { get; set; } = "en";
            public int CONFIG2 { get; set; } = 25000000;
            public int CONFIG3 { get; set; } = 6500;
            public int CONFIG4 { get; set; } = 15000;
            public string[] CONFIG5 { get; set; } = { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
            public string CONFIG6 { get; set; } = "yes";
            public string CONFIG7 { get; set; } = "ya";
        }

        public void run()
        {
            
            CONFIG c = new CONFIG();
            if(c.CONFIG1 == "en")
            {
                Console.Write("Please insert the amount of money to transfer: ");
            }else if(c.CONFIG1 == "id")
            {
                Console.Write("Masukkan jumlah uang yang akan di-transfer: ");
            }
            int jumlahTf = Convert.ToInt32(Console.ReadLine());

            int biayaTf;
            if (jumlahTf <= c.CONFIG2)
            {
                biayaTf = c.CONFIG3;
            }
            else
            {
                biayaTf = c.CONFIG4;
            }

            int total = jumlahTf + biayaTf;

            if(c.CONFIG1 == "en")
            {
                Console.WriteLine("Transfer fee = "+ biayaTf);
                Console.WriteLine("Total amount = " + total);
            }
            else if(c.CONFIG1 == "id")
            {
                Console.WriteLine("Biaya transfer = "+biayaTf);
                Console.WriteLine("Total biaya    = "+ total);
            }

            Console.WriteLine("Metode transfer: ");

            for (int i = 1; i <= c.CONFIG5.Length; i++)
            {
                Console.WriteLine(i + ". " + c.CONFIG5[i-1]);
            }

            if (c.CONFIG1 == "en")
            {
                Console.Write("Select transfer method: ");
            }
            else if (c.CONFIG1 == "id")
            {
                Console.Write("Pilih metode transfer: ");
            }
            string metode = Console.ReadLine();

            

            if(c.CONFIG1 == "en")
            {
                Console.Write("Please type \""+ c.CONFIG6+ "\" to confirm the transaction: ");
            }else if(c.CONFIG1 == "id")
            {
                Console.Write("Ketik \""+ c.CONFIG7 +"\" untuk menkonfirmasi transaksi: ");
            }
            string konfirm = Console.ReadLine();

            if(c.CONFIG1 == "en")
            {
                if(konfirm == c.CONFIG6)
                {
                    Console.WriteLine("The transfer is completed");
                }
                else
                {
                    Console.WriteLine("Transfer is cancelled");
                }
            }else  if (c.CONFIG1 == "id"){
                if(konfirm == c.CONFIG7)
                {
                    Console.WriteLine("Proses transfer berhasil");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }
        }
    }
}

