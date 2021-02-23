using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools
{
    public static class AssetDecryptor
    {
        private static AesManaged aes;

        static AssetDecryptor()
        {
            aes = new AesManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                Key = Convert.FromBase64String("5Mp78iBLX9gVvDjWGCqfbzRHS7hK3JiR")
            };
        }

        public static byte[] Encrypt(byte[] input)
        {
            byte[] encrypted;

            using(var ms = new MemoryStream())
            {
                using(var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(new byte[16]);
                    cs.Write(input);

                    cs.FlushFinalBlock();

                    encrypted = ms.ToArray();
                }
            }

            return encrypted;
        }

        public static byte[] Decrypt(Stream input)
        {
            byte[] decrypted = new byte[input.Length - 16];

            using (var cs = new CryptoStream(input, aes.CreateDecryptor(), CryptoStreamMode.Read))
            {
                // skip 16 bytes (some unknown checksum or something idk)
                int leftSkip = 16;

                while(leftSkip-- > 0)
                {
                    int b = cs.ReadByte();
                }

                _ = cs.Read(decrypted, 0, (int)input.Length - 16);
            }

            return decrypted;
        }
    }
}
