using MODUL8;

class Program
{
    static void Main(string[] args)
    {
        int biaya, uang;
        if(config.lang == "en")
        {
            Console.WriteLine("Please Insert The Amount of Money");
        } else if (config.lang == "id")
        {
            Console.WriteLine("Masukan jumlah uang yang akan di transfer");

        }
         uang = Convert.ToInt32(Console.ReadLine());

        if (uang <= config.threshold) {
             biaya = config.low_fee;
        
        }
        else
        {
             biaya = config.high_fee;
        }
        int total = uang + biaya;
        if(config.lang == "en")
        {
            Console.WriteLine("Transfer Fee =" + biaya + "Total Amount =" + total);
        }
        else if (config.lang == "id")
        {
            Console.WriteLine("Biaya Transfer = " + biaya + "total biaya = " + total);   
        }
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
            Console.WriteLine(i + $"Metode {Config.methods}");
        }



    }
}