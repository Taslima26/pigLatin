using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pig Latin Translator");
            Console.WriteLine();
            Console.WriteLine("Enter the word");
            string word = Console.ReadLine();
            int vowelPosition = -1;
            foreach (char letter in word)
            {
                vowelPosition = vowelPosition + 1;
                if (letter == 'a' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'e')

                {
                    break;
                }

            }
            string pigLatinWord = "";
            string BeforeLetters = "";
            string AfterLetters = "";

            switch (vowelPosition)
            {
                case 0:
                    pigLatinWord =word+"ay";
                    break;
                case 1:
                    BeforeLetters = word.Substring(0, 1);
                    AfterLetters = word.Substring(1);
                    pigLatinWord =  AfterLetters +BeforeLetters+ "ay";
                    break;
                case 2:
                    BeforeLetters = word.Substring(0, 2);
                    AfterLetters = word.Substring(2);
                    pigLatinWord =  AfterLetters + BeforeLetters+"ay";
                    break;
                default:
                    pigLatinWord = "unable to translate";
                    break;
            }
            //Logic
            //step-1 find the vowel
            //step-2 follow the rule
            Console.WriteLine("Translation :--->"+
                pigLatinWord);
            Console.WriteLine("Enter the key to terminate program");

            Console.ReadKey();

        }
    }
}

