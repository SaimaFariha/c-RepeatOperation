namespace C_RepeatOperation_While_Do_While_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,World");

            string[] wordCollection = { "Level", "hello", "mom", "dad" };
            foreach (var item in wordCollection)
            {
                //for(int i=0;i<item.Length/2;i++)
                //{ if(item[i] !=item[item.Length=1=i])
                bool isPalindrome = item.SequenceEqual(item.Reverse());


                Console.WriteLine($"{item} is {(isPalindrome ? "a palindrome" : "not a palindrome")}");
            }

            //Break&Continue

            for (int counter = 0; counter < 10; counter++)

            {
                Console.WriteLine(counter);
                if (counter == 3) ;
                {
                    Console.WriteLine("Stop at 3");
                    break;
                }

                int number = 123456;
                int reverseNumber = 0;
                while (number != 0)
                {
                    int remainder = number % 10;
                    Console.WriteLine(remainder);
                    reverseNumber = reverseNumber * 10 + remainder;
                    Console.WriteLine(reverseNumber);
                    number /= 10;
                }
                //FizzBuzz
                int num = 1;
                do
                {
                    if (num % 3 == 0 && num % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (num % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }

                    else if (num % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                        Console.WriteLine(num);
                }
                while (num <= 100);

            }
        }
    }
}