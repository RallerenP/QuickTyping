using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTyping
{
    class FinishClass
    {

        string precision = "0%";

        public void EndGame(double timeSpent)
        {
            
        //    precision = cst.FailPercent().ToString();

            Stats s = new Stats();
            s.Show();
        }

        public string Precision()
        {
            return precision;
        }

    }
}
