using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressScraper
{
    public class Config
    {
        // Read api key from file
        public static string GetApiKey()
        {
            string apiKey = null;
            try
            {
                apiKey = System.IO.File.ReadAllText("config.txt");
                return apiKey;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading from config file: " + e.Message.ToString());
            }
            return apiKey;
        }
    }
}
