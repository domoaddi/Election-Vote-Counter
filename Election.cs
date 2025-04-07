using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddisonMidTerm
{
    class Election
    {
        private string[] candidateNames;
        private int[] votes;
        public const int NUMOFCANDIDATES = 5;

        public Election()
        {
            candidateNames = new string[NUMOFCANDIDATES];
            votes = new int[NUMOFCANDIDATES];
        }

        public string GetCandidateName(int index)
        {
            if (index < 0 || index >= NUMOFCANDIDATES)
                throw new IndexOutOfRangeException("Invalid candidate index");

            return candidateNames[index];
        }

        public void SetCandidateName(string name, int index)
        {
            if (index < 0 || index >= NUMOFCANDIDATES)
                throw new IndexOutOfRangeException("Invalid candidate index");

            candidateNames[index] = name;
        }

        public int GetCandidateVotes(int index)
        {
            if (index < 0 || index >= NUMOFCANDIDATES)
                throw new IndexOutOfRangeException("Invalid candidate index");

            return votes[index];
        }

        public void SetCandidateVotes(int votesCount, int index)
        {
            if (index < 0 || index >= NUMOFCANDIDATES)
                throw new IndexOutOfRangeException("Invalid candidate index");

            votes[index] = votesCount;
        }

        public string FindWinner()
        {
            int maxVotes = votes.Max();
            int winnerIndex = Array.IndexOf(votes, maxVotes);

            return candidateNames[winnerIndex];
        }

        public int TotalVotes()
        {
            return votes.Sum();
        }
    }
}

