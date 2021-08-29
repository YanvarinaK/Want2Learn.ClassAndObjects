using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Want2Learn.Interfaces;

namespace Want2Learn.Services
{
    public class StringAlgorithms : IStringAlgorithms
    {
        const string EngAlphabet = "abcdefghijklmnopqrstuvwxyz";
        const string RusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        const string ValidEmailSymbols = "abcdefghijklmnopqrstuvwxyz0123456789_-.";
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

        private bool IsValidSymbol(char symbol)
        {
            bool isValid = true;
            if (!(RusAlphabet.Contains(symbol)) && !(EngAlphabet.Contains(symbol)) && (symbol != ' '))
            {
                isValid = false;
            }
            return isValid;
        }

        private List<char> GetNotValidSymbols(string text)
        {
            List<char> NotValid = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if ((!IsValidSymbol(text[i])) && (!NotValid.Contains(text[i])))
                {
                    NotValid.Add(text[i]);
                }
            }
            return NotValid;
        }

        private string NormalizeText(string text)
        {
            text = text.ToLower();
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            string NormalText = text.Trim();
            List<char> notValids = GetNotValidSymbols(NormalText);
            foreach (var item in notValids)
            {
                NormalText = NormalText.Replace(item.ToString(), string.Empty);
            }
            return NormalText;
        }

        private List<string> SplitStringToListOfWords(string text)
        {
            List<string> Words = text.Split(' ').ToList();
            return Words;
        }

        public Dictionary<string, int> GetWordStatistic(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return null;
            }
            string NormalText = NormalizeText(text);
            List<string> words = SplitStringToListOfWords(NormalText);
            Dictionary<string, int> StatisticsOfWords = new Dictionary<string, int>();
            for (int i = 0; i < words.Count; i++)
            {
                if (!StatisticsOfWords.ContainsKey(words[i]))
                {
                    StatisticsOfWords.Add(words[i], 1);
                }
                else
                {
                    StatisticsOfWords[words[i]]++;
                }
            }
            return StatisticsOfWords;
        }

        private bool IsValidEmailSymbol(char symbol)
        {
            bool IsValid = true;
            if (!ValidEmailSymbols.Contains(symbol))
            {
                IsValid = false;
            }
            return IsValid;
        }

        private bool IsValidUserName(string email)
        {
            string userName = email.Remove(email.IndexOf('@'));
            if (String.IsNullOrWhiteSpace(userName))
            {
                return false;
            }
            if ((userName.StartsWith(".")) || (userName.EndsWith(".")))
            {
                return false;
            }
            if (userName.Contains(".."))
            {
                return false;
            }
            userName = userName.ToLower();
            for (int i = 0; i < userName.Length; i++)
            {
                if (IsValidEmailSymbol(userName[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidDomen(string email)
        {
            string domen = email.Substring(email.IndexOf('@') + 1);
            domen = domen.ToLower();
            if (String.IsNullOrWhiteSpace(domen))
            {
                return false;
            }
            string domenEnd = domen.Substring(domen.LastIndexOf('.') + 1);
            if (String.IsNullOrWhiteSpace(domenEnd))
            {
                return false;
            }
            for (int i = 0; i < domenEnd.Length; i++)
            {
                if (!EngAlphabet.Contains(domenEnd[i]))
                {
                    return false;
                }
            }
            if (domen.StartsWith("."))
            {
                return false;
            }
            if ((domen.StartsWith("-")) || (domen.EndsWith("-")))
            {
                return false;
            }
            if ((domen.Contains("..")) || (domen.Contains("--")))
            {
                return false;
            }
            for (int i = 0; i < domen.LastIndexOf('.'); i++)
            {
                if (!IsValidEmailSymbol(domen[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsValidEmail(string email)
        {
            if (String.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            if (!email.Contains('@'))
            {
                return false;
            }
            if (!IsValidUserName(email))
            {
                return false;
            }
            if (!IsValidDomen(email))
            {
                return false;
            }
            return true;
        }
    }
}
