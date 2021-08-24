using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
{
    public class StringAlgorithms : IStringAlgorithms
    {
        const string EngAlphabet = "abcdefghijklmnopqrstuvwxyz";
        const string RusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
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
    }
}
