class Program
{
    static void Main(string[] args)
    {
        //Palindrome -- 1. yazim sekli
        string input = Console.ReadLine();
        bool isPalindrome = true;

        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }

        Console.WriteLine("------------------------------------------");

        string str = Console.ReadLine();

        if (IsPalindrome(str))
        {
            Console.WriteLine("{0} is a palindrome.", str);
        }
        else
        {
            Console.WriteLine("{0} is not a palindrome.", str);
        }

        //Palindrome -- 2. yazim sekli 
        static bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;

            while (i < j)
            {
                if (str[i] != str[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }


        Console.WriteLine("---------------------------");

        //Sesli harf sayma fonksiyonu
        Console.WriteLine("Bir cümle giriniz.");
        string sentence = Console.ReadLine();
        int vowelCount = CountVowels(sentence);

        Console.WriteLine("'{0}' cümlesinde {1} adet sesli harf vardır.", sentence, vowelCount);

        static int CountVowels(string str)
        {
            string vowels = "aeiouAEIOU";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}





    







