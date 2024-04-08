using System;

namespace CeaserCipher
{
    public class CeaserCipher
    {
        private static readonly char[] UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static readonly char[] LOWER = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static readonly char[] NUMBER = "0123456789".ToCharArray();
        private static readonly char[] SYMBOLS = "`~!@#$%^&*()_-=+{}[];:\'\"\\|,<.>/?".ToCharArray();

        public static string Encrypt(string message, int shift)
        {
            string encryptedMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                char[] TYPE = GetTypeArray(message[i]);
                int letterPosition = Array.IndexOf(TYPE, message[i]);
                int newLetterPosition = (letterPosition + shift) % TYPE.Length;
                encryptedMessage += TYPE[newLetterPosition];
            }
            return encryptedMessage;
        }
        public static string Decrypt(string message, int shift)
        {
            string decryptedMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                char[] TYPE = GetTypeArray(message[i]);
                int letterPosition = Array.IndexOf(TYPE, message[i]);
                int newLetterPosition = (TYPE.Length + letterPosition - shift) % TYPE.Length ;
                 decryptedMessage += TYPE[newLetterPosition];
            }
            return decryptedMessage;
        }

        private static char[] GetTypeArray(char character)
        {
            if (char.IsUpper(character))
            {
                return UPPER;
            }
            if (char.IsLower(character))
            {
                return LOWER;
            }
            if (char.IsNumber(character))
            {
                return NUMBER;
            }
            return SYMBOLS;
        }
    }
 }
