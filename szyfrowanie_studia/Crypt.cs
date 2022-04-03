using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace szyfrowanie_studia
{
    class Crypt
    {
        byte[] key = { 145, 12, 32, 245, 98, 132, 98, 214, 6, 77, 131, 44, 221, 3, 9, 50 };
        byte[] iv = { 15, 122, 132, 5, 93, 198, 44, 31, 9, 39, 241, 49, 250, 188, 80, 7 };
        public byte[] EncryptRSA(byte[] msg, CspParameters csp)
        {
            using (var RSA = new RSACryptoServiceProvider(csp))
            {
                return RSA.Encrypt(msg, false);
            }
        }
        //metoda deszyfrująca
        public byte[] DecryptRSA(byte[] msg, CspParameters csp)
        {
            using (var RSA = new RSACryptoServiceProvider(csp))
            {
                return RSA.Decrypt(msg, false);
            }
        }
        //szyfrowanie wiadomości
        public byte[] Encrypt(SymmetricAlgorithm symmetricAlgorithm, string text)
        {
            ICryptoTransform encryptor = symmetricAlgorithm.CreateEncryptor(key, iv);

            using (var msEncrypt = new MemoryStream())
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (var swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(text);
                    }
                    return msEncrypt.ToArray();
                }
            }
        }
        //deszyfrowanie wiadomości
        public string Decrypt(SymmetricAlgorithm symmetricAlgorithm, byte[] msg)
        {
            ICryptoTransform decryptor = symmetricAlgorithm.CreateDecryptor(key, iv);
            using (var msDecrypt = new MemoryStream(msg))
            {
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}
