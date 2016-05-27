using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;  // This is for password validation
using System.Security.Cryptography;  // This is where the hash functions reside


namespace AppWeb.Session
{
    public class Encription
    {


        /*
        public string StringToSHA(string plainTextString)
        {
            HashAlgorithm algorithm = new SHA1Managed();
            var saltBytes = GenerateSalt(plainTextString.Length);
            var plainTextBytes = Encoding.ASCII.GetBytes(plainTextString);

            var plainTextWithSaltBytes = AppendByteArray(plainTextBytes, saltBytes);
            var saltedSHA1Bytes = algorithm.ComputeHash(plainTextWithSaltBytes);
            var saltedSHA1WithAppendedSaltBytes = AppendByteArray(saltedSHA1Bytes, saltBytes);

            return Convert.ToBase64String(saltedSHA1WithAppendedSaltBytes);
        }


        private byte[] GenerateSalt(int saltSize)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[saltSize];
            rng.GetBytes(buff);
            return buff;
        }

        private byte[] AppendByteArray(byte[] byteArray1, byte[] byteArray2)
        {
            var byteArrayResult =
                    new byte[byteArray1.Length + byteArray2.Length];

            for (var i = 0; i < byteArray1.Length; i++)
                byteArrayResult[i] = byteArray1[i];
            for (var i = 0; i < byteArray2.Length; i++)
                byteArrayResult[byteArray1.Length + i] = byteArray2[i];

            return byteArrayResult;
        }
        */

        //Encpritacion de contraseña con SHA1
        public string StringToSHA(string StringPassword)
        {
            string HashSHAPassword = string.Empty;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            byte[] tmpHash;

            tmpHash = sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(StringPassword));

            HashSHAPassword = Convert.ToBase64String(tmpHash, 0, tmpHash.Length);

            return HashSHAPassword;

        }

        //Encpritacion de contraseña con MD5
        public string StringToMD5(string StringPassword)
        {
            string HashMD5Password = string.Empty;

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(StringPassword); // Turn password into byte array
            byte[] tmpHash;

            tmpHash = md5.ComputeHash(tmpSource);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            // Set the secret key for the tripleDES algorithm
            tdes.Key = tmpHash;

            // Mode of operation. there are other 4 modes.
            // We choose ECB (Electronic code Book)
            tdes.Mode = CipherMode.ECB;

            // Padding mode (if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();

            // Transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(tmpSource, 0,
              tmpSource.Length);

            // Release resources held by TripleDes Encryptor
            tdes.Clear();
            // Return the encrypted data into unreadable string format
            HashMD5Password = Convert.ToBase64String(resultArray, 0, resultArray.Length);


            return HashMD5Password;


        }

        //Desencpritacion de contraseña MD5
        public string MD5ToStrgin(string stringHash, string stringKey)
        {
            string StringPassword = string.Empty;

            byte[] tmpHash;
            byte[] tmpSource = Convert.FromBase64String(stringHash);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            tmpHash = md5.ComputeHash(Convert.FromBase64String(stringKey));

            // Release any resource held by the MD5CryptoServiceProvider
            md5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            // Set the secret key for the tripleDES algorithm
            tdes.Key = tmpHash;

            // Mode of operation. there are other 4 modes. 
            // We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;

            // Padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                                 tmpSource, 0, tmpSource.Length);

            // Release resources held by TripleDes Encryptor
            tdes.Clear();

            // Return the Clear decrypted TEXT
            StringPassword = ASCIIEncoding.ASCII.GetString(resultArray);


            return StringPassword;
        }



        //Validaciones de campos de texto
        public Boolean isValidString(string thisPassword)
        {
            string newPassword = sanitizeInput(thisPassword);
            Regex regX = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{5,15)");
            return regX.Match(newPassword).Success;
        }

        public string sanitizeInput(string thisInput)
        {
            Regex regX = new Regex(@"([<>""'%;()&])");
            return regX.Replace(thisInput, "");
        }

    }
}
