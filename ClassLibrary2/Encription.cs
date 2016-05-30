using System;

using System.Text;
using System.Text.RegularExpressions;  // This is for password validation
using System.Security.Cryptography;  // This is where the hash functions reside


namespace Session
{
    public class Encription
    {
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
