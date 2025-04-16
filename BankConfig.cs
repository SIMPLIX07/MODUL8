using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MODUL8
{
    internal class BankConfig
    {
       
        public string lang { get; set; } = "en";
        
        class Transfer
        {
            public int threshold { set; get; } = 25000000;
            public int low_fee { set; get; } = 6500;

            public int high_fee { set; get; } = 15000;
        }
        class confirmation
        {
            public string en { set; get; } = "yes";
            public string id { set; get; } = "ya";
        }
        class method
        {

        }
        class Config
        {
            private Config ReadConfigFile()
            {
                String configJsonData = File.ReadAllText(filePath);
                config = JsonSerializer.Deserialize<Config>(configJsonData);
                return config;
            }
        }

    }


   

   
    
}
