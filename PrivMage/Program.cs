using Newtonsoft.Json;
using PrImage.JsonBlueprints;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PrivMage
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new FormMain());
            }
            catch(System.ObjectDisposedException)
            {
                // Dont do shit
            }
            
        }
        // WEBP NOT SUPPORTED YET
        public static string ComputeMD5Hash(byte[] input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(input);

                // Optional: Konvertiere das Ergebnis in einen Hex-String
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2")); // Zweistelliges Hex, mit führender 0

                return sb.ToString();
            }
        }
        public static string GetImageFormat(byte[] bytes)
        {
            if (bytes == null || bytes.Length < 12)
                return "unknown";

            // .jpg / .jpeg
            if (bytes[0] == 0xFF && bytes[1] == 0xD8 && bytes[2] == 0xFF)
                return "jpg";

            // .png
            if (bytes[0] == 0x89 && bytes[1] == 0x50 &&
                bytes[2] == 0x4E && bytes[3] == 0x47 &&
                bytes[4] == 0x0D && bytes[5] == 0x0A &&
                bytes[6] == 0x1A && bytes[7] == 0x0A)
                return "png";

            // .bmp
            if (bytes[0] == 0x42 && bytes[1] == 0x4D)
                return "bmp";

            // .webp
            if (bytes[0] == 0x52 && bytes[1] == 0x49 && bytes[2] == 0x46 && bytes[3] == 0x46 &&
                bytes[8] == 0x57 && bytes[9] == 0x45 && bytes[10] == 0x42 && bytes[11] == 0x50)
                return "webp";

            return "Unbekannt";
        }
    }
}
