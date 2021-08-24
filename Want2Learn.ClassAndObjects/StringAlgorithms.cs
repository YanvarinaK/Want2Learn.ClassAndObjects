using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
{
    public class StringAlgorithms : IStringAlgorithms
    {
        private string GetStringOfKeys(string text, string key)
        {
            string StringOfKeys = String.Join("", Enumerable.Repeat(key, text.Length / key.Length));
            for (int i = 0; i < (text.Length % key.Length); i++)
            {
                StringOfKeys = StringOfKeys + key[i];
            }
            return StringOfKeys;
        }
        public string VigenereEncryption(string text, string key)
        {
            if (String.IsNullOrEmpty(text))
            {
                return String.Empty;
            }
            if (String.IsNullOrEmpty(key))
            {
                return text;
            }

            string StringOfKeys = GetStringOfKeys(text, key);
            string Encryption = String.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                Encryption = Encryption + (char)(text[i] + StringOfKeys[i]);
            }
            return Encryption;
        }

        public string VigenereDecryption(string text, string key)
        {
            if (String.IsNullOrEmpty(text))
            {
                return String.Empty;
            }
            if (String.IsNullOrEmpty(key))
            {
                return text;
            }
            string StringOfKeys = GetStringOfKeys(text, key);
            string Decryption = String.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                Decryption = Decryption + (char)(text[i] - StringOfKeys[i]);
            }
            return Decryption;
        }
    }
}
