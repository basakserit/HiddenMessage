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
            //Console.Clear();
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
                    return EncryptText();
                case "2":
                    return DecryptText();
                default:
                    return true;
            }
        }

        static bool EncryptText()
        {
            WordOperations wo = new WordOperations();

            Console.WriteLine("Please type a message to encrypt > ");
            var text = Console.ReadLine();

            wo.WordWitoutEncrytion = text;

            Console.WriteLine("Encrypted message > " + wo.EncryptWord());

            return ShowExitMenu();
        }

        static bool DecryptText()
        {
            WordOperations wo = new WordOperations();

            Console.WriteLine("Please type a message to decrypt > ");
            var text = Console.ReadLine();

            wo.WordWitoutEncrytion = text;

            Console.WriteLine("Decrypted message > " + wo.DecryptWord());

            return ShowExitMenu();
        }

        static bool ShowExitMenu()
        {
            Console.WriteLine("\nDo you want to exit? (y|n) > ");

            var choice = Console.ReadLine();
            var isExit = choice.ToLower().Equals("y") ? false : true;

            return isExit;
        }

    }
}
