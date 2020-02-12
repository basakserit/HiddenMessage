using System;
namespace HiddenMessage
{
    public class WordOperations
    {
        string wordWithoutEncryption, encryptedWord, decryptedWord;

        public WordOperations()
        {
        }

        #region Getters & Setters

        public string WordWitoutEncrytion
        {
            get
            {
                return wordWithoutEncryption;
            }
            set
            {
                this.wordWithoutEncryption = value;
            }
        }

        public string EncryptedWord
        {
            get
            {
                return encryptedWord;
            }
            set
            {
                this.encryptedWord = value;
            }
        }

        public string DecryptedWord
        {
            get
            {
                return decryptedWord;
            }
            set
            {
                this.decryptedWord = value;
            }
        }

        #endregion

        public string EncryptWord()
        {
            encryptedWord = ChangeAsciCode(wordWithoutEncryption, true);
            return encryptedWord;
        }

        public string DecryptWord()
        {
            decryptedWord = ChangeAsciCode(wordWithoutEncryption, false);
            return decryptedWord;
        }

        string ChangeAsciCode(string word, bool isEncrypt)
        {
            var wordArray = word.ToCharArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                
                var charCode = isEncrypt ? GetAsciiCodeFromChar(wordArray[i]) + 1 : GetAsciiCodeFromChar(wordArray[i]) - 1;
                var newChar = GetCharFromAsciiCode(charCode);
                wordArray[i] = newChar;
            }

            var resultString = new string(wordArray);

            return resultString;
        }

        int GetAsciiCodeFromChar(char letter)
        {
            var asciiCode = (int)letter;
            return asciiCode;
        }

        char GetCharFromAsciiCode(int code)
        {
            var letter = (char)code;
            return letter;
        }

    }
}
