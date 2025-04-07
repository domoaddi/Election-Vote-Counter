using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddisonMidTerm
{
    internal class ElectionUI
    {
        private Election theElection;

        public ElectionUI()
        {
            theElection = new Election();
        }

        public void MainMethod()
        {
            Console.WriteLine("************************************************************************************************\n");

            Console.WriteLine("Name: Domeneak Addison");

            Console.WriteLine("Course: ITDEV-115-501");

            Console.WriteLine("Instructor: Mr. Menzl");

            Console.WriteLine("Assignment: Midterm");

            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());

            Console.WriteLine("***********************************************************************************************\n");

            for (int i = 0; i < Election.NUMOFCANDIDATES; i++)
            {
                Console.WriteLine("\n");
                Console.Write($"Please enter candidate {i + 1}'s name: ");
                string name = Console.ReadLine();
                theElection.SetCandidateName(name, i);

                Console.WriteLine("\n");
                Console.Write($"Now enter {name}'s vote count: ");
                int votes = int.Parse(Console.ReadLine());
                theElection.SetCandidateVotes(votes, i);
                
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine("\n");

            Console.WriteLine("Name\tVotes\tPercentage");

            for (int i = 0; i < Election.NUMOFCANDIDATES; i++)
            {
                string name = theElection.GetCandidateName(i);
                int votes = theElection.GetCandidateVotes(i);
                double percentage = (votes / (double)theElection.TotalVotes()) * 100;

                Console.WriteLine($"{name}\t{votes}\t{percentage:F1}%");
            }

            string winner = theElection.FindWinner();
            Console.WriteLine("\n");
            Console.WriteLine($"The winner is {winner}!!");
            Console.ReadLine();
        }
    }
}

