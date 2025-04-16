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
            private void WriteNewConfigFile()
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };
                String jsonString = JsonSerializer.Serialize(config, options);
                File.WriteAllText(filePath, jsonString);
            }
        }
        class UIConfig
        {
            public Config config;
            public const String filePath = @"config.json";
            public UIConfig() { … }
            private Config ReadConfigFile() { … }
            private void SetDefault() { … }
            private void WriteNewConfigFile() { … }
            public UIConfig()
            {
                try
                {
                    ReadConfigFile();
                }
                catch (Exception)
                {
                    SetDefault();
                    WriteNewConfigFile();
                }
            }
        }

    }


   

   
    
}
