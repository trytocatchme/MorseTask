using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MorseTask
{
    public class MorseEncryptor : IEncryptor
    {
        private readonly IReadOnlyDictionary<char, string> _charactersEncoding;

        public MorseEncryptor()
        {
            // standard morse encoding without numbers and special characters.
            _charactersEncoding = new Dictionary<char, string>()
            {
                { 'a', ".-" },
                { 'b', "-..." },
                { 'c', "-.-." },
                { 'd', "-.." },
                { 'e', "." },
                { 'f', "..-." },
                { 'g', "--." },
                { 'h', "...." },
                { 'i', ".." },
                { 'j', ".---" },
                { 'k', "-.-" },
                { 'l', ".-.." },
                { 'm', "--" },
                { 'n', "-." },
                { 'o', "---" },
                { 'p', ".--." },
                { 'q', "--.-" },
                { 'r', ".-." },
                { 's', "..." },
                { 't', "-" },
                { 'u', "..-" },
                { 'v', "...-" },
                { 'w', ".--" },
                { 'x', "-..-" },
                { 'y', "-.--" },
                { 'z', "--.." }
            };
        }

        public MorseEncryptor(Dictionary<char, string> charactersEncoding)
        {
            if (charactersEncoding is null)
                throw new ArgumentNullException("charactersEncoding cannot be null.");

            if (!charactersEncoding.Any())
                throw new ArgumentException("characterEncoding does not contain any element.");

            _charactersEncoding = charactersEncoding;
        }

        public string Encode(string message)
        {
            if (string.IsNullOrEmpty(message))
                throw new ArgumentException("message cannot be null or empty.");

            StringBuilder sb = new StringBuilder();
            message = message.ToLower();
         
            foreach (char letter in message)
            {
                if (letter != ' ')
                    sb.Append(_charactersEncoding[letter]);

                sb.Append(" ");       
            }

            --sb.Length;
            return sb.ToString();
        }
    }
}
