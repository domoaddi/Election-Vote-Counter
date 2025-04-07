using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddisonMidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectionUI electionUI = new ElectionUI();
            electionUI.MainMethod();
            electionUI.DisplayResults();
        }
    }
}
