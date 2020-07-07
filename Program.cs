using System;

namespace ResitProjectB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Thanks for watching this movie!*****");
            Console.WriteLine("Would you like to leave a review of this movie?");
            Console.WriteLine("Type 'yes' if you would like to. If not press any key");
            var review = Console.ReadLine();

            if (review == "yes")
            {
                Console.WriteLine("Thank you for choosing to leave a review. Now we are going to ask you a few general questions.");

                Console.WriteLine("Q1: This movie in one word");
                var q1 = Console.ReadLine();

                Console.WriteLine("Q2: What did you like the most of this movie?");
                var q2 = Console.ReadLine();

                Console.WriteLine("Q3: What did you dislike the most of this movie?");
                var q3 = Console.ReadLine();

                Console.WriteLine("Q4: How many stars do you rate this movie from 0-5");
                var q4 = Console.ReadLine();

                Console.WriteLine("Thank you for leaving a review. This review will now be shown at the review section of the movie.\nHere is a summary of your review\n");

                Console.WriteLine("Q1: This movie in one word");
                Console.WriteLine(q1);
                Console.WriteLine("Q2: What did you like the most of this movie?");
                Console.WriteLine(q2);
                Console.WriteLine("Q3: What did you dislike the most of this movie?");
                Console.WriteLine(q3);
                Console.WriteLine("Q4: How many stars do you rate this movie from 0-5");
                Console.WriteLine(q4+" STARS");

                Console.WriteLine("Thank you for choosing us! We look forward to your next visit!");



            }
            else
            {
                Console.WriteLine("Thank you for choosing us! We look forward to your next visit!");
            }

        }
    }
}
