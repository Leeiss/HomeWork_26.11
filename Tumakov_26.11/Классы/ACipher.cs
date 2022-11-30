using System;
using Tumakov10;

namespace Tumakov10
{
    class ACipher : ICipher
    {
        private string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public string Encode(string str, int k)
        {
            string all_alphabet = alphabet + alphabet.ToLower();
            int len_alphabet = all_alphabet.Length;
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                char simb = str[i];
                int index = all_alphabet.IndexOf(simb);
                if (index > 0)
                {
                    int index_code = (len_alphabet + index + k) % len_alphabet;
                    result += all_alphabet[index_code];
                }
                else
                {
                    result += simb.ToString();
                }
            }
            return result;
        }
        public string Encoding(string text, int k)
        {
            return Encode(text, k);
        }
        public string Decoding(string text, int k)
        {
            return Encode(text, -k);
        }
    }
}