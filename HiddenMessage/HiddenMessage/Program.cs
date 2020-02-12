using System;

namespace HiddenMessage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ShowMenu();
            }
        }

        static bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("## Hidden Words ###");
            Console.WriteLine("1 - Encryption");
            Console.WriteLine("2 - Decryption");
            Console.WriteLine("3 - EXIT");

            Console.WriteLine("Please select > ");

            var selection = Console.ReadLine();

            if (string.IsNullOrEmpty(selection) || selection.Equals("3"))
                return false;

            switch (selection)
            {
                case "1":
                    EncryptText();
                    return false;
                case "2":
                    DecryptText();
                    return false;
                default:
                    return true;
            }
        }

        static void EncryptText()
        {
            WordOperations wo = new WordOperations();

            Console.WriteLine("Please type a message to encrypt > ");
            var text = Console.ReadLine();

            wo.WordWitoutEncrytion = text;

            Console.WriteLine("Encrypted message > " + wo.EncryptWord());
        }

        static void DecryptText()
        {
            WordOperations wo = new WordOperations();

            Console.WriteLine("Please type a message to decrypt > ");
            var text = Console.ReadLine();

            wo.WordWitoutEncrytion = text;

            Console.WriteLine("Decrypted message > " + wo.DecryptWord());
        }

    }
}
