using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    class ListAssignment
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> studentScore = new List<int>();
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("Please enter the student's score (0 to 100): ");
                studentScore.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(studentScore.Count);

            foreach(int counter in studentScore)
            {
                sum += counter;
            }

            Console.WriteLine("The sum of all the test scores is: " + sum);
            Console.WriteLine("The average of all the test scores is: " + sum / studentScore.Count);

            Console.ReadLine();
        }
    }
}
