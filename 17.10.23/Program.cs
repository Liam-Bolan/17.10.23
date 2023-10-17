using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._10._23_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader questions = new StreamReader("questions.txt");
            string username;
            int score = 0;
            while (!questions.EndOfStream)
            {
                string qstions = questions.ReadLine();
                
                Console.WriteLine(qstions);
               
                
                
                string a1 = questions.ReadLine();   
                Console.WriteLine($"A){a1}");
                string a2 = questions.ReadLine();
                Console.WriteLine($"B){a2}");
                string a3 = questions.ReadLine();
                Console.WriteLine($"C){a3}");
                string a4 = questions.ReadLine();
                Console.WriteLine($"D){a4}");
                string correct = questions.ReadLine();
                string useranswer = " ";
                
                while (!"ABCD".Contains(useranswer[0]))
                {
                    Console.Write("Enter the answer: A) B) C) D)");
                    useranswer = Console.ReadLine().ToUpper();
                    
                }
                if (useranswer == correct)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
                
                
            }
            Console.WriteLine($"You scored: {score}");
            Console.WriteLine("Please Enter your name");
            username = questions.ReadLine();

        }
    }
}
