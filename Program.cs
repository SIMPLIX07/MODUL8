using MODUL8;

class Program
{
    static void Main(string[] args)
    {
        int biaya, uang;
        //Pengechekan bahasa dari config
        if(config.lang == "en")
        {
            Console.WriteLine("Please Insert The Amount of Money");
        } else if (config.lang == "id")
        {
            Console.WriteLine("Masukan jumlah uang yang akan di transfer");

        }
         uang = Convert.ToInt32(Console.ReadLine());
        //Pengechekan jumlah uang untuk menentukan biaya
        if (uang <= config.threshold) {
             biaya = config.low_fee;
        
        }
        else
        {
             biaya = config.high_fee;
        }
        int total = uang + biaya;
        //Pengechekan bahasa untuk writeline
        if(config.lang == "en")
        {
            Console.WriteLine("Transfer Fee =" + biaya + "Total Amount =" + total);
        }
        else if (config.lang == "id")
        {
            Console.WriteLine("Biaya Transfer = " + biaya + "total biaya = " + total);   
        }
        //Pengechekan bahasa untuk writeline

        if (config.lang == "en")
        {
            Console.WriteLine("Select Transfer Method");
        }
        else if (config.lang == "id")
        {
            Console.WriteLine("Pilih metode transfer");

        }
        Console.WriteLine("Metode Pembayaran");
        for (int i = 0; i < 4; i++)
        {
            //memanggil method pada config
            Console.WriteLine(i + $"Metode {Config.methods}");
        }

        if (config.lang == "en")
        {
            //mengeprint config confirmation
            Console.WriteLine($"Please type {Config.confirmation} to confirm the transaction");
        }
        else if (config.lang == "id")
        {
            Console.WriteLine($"Ketik {Config.confirmation} untuk mengkonfirmasi transaksi");

        }
        string masukan = Console.ReadLine();
        //pemgechekan masukan yang sesuai
        if (masukan == "RTO" || masukan == "SKN" || masukan == "RTGS" || masukan == "BI FAST")
        {
            if (config.lang == "en")
            {
                Console.WriteLine("The transfer is completed");
            }
            else if (config.lang == "id")
            {
                Console.WriteLine("transfer berhasil");

            }
        }else
        {
            //Pengechekan bahasa untuk writeline

            if (config.lang == "en")
            {
                Console.WriteLine("The transfer is canceled");
            }
            else if (config.lang == "id")
            {
                Console.WriteLine("transfer dibatalkan");

            }
        }

    }
}