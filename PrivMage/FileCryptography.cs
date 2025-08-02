using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrImage
{
    partial class FormMain : Form
    {

        public string EncryptStringToBase64(string input, byte[] key, byte[] iv)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (var ms = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                        cryptoStream.FlushFinalBlock();
                    }

                    byte[] encryptedBytes = ms.ToArray();
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
        }
        public string DecryptBase64ToString(string base64Input, byte[] key, byte[] iv)
        {
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(base64Input);

                using (var aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (var ms = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(new MemoryStream(encryptedBytes), aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            cryptoStream.CopyTo(ms);
                        }

                        byte[] decryptedBytes = ms.ToArray();
                        return Encoding.UTF8.GetString(decryptedBytes);
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
            
        }
    }
}
