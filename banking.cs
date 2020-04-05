using System;
using System.Collections.Generic;
using System.Text;

namespace cash_counter
{
  
   class banking
    {

        /*if user deposit mony 
         * then add mony in that person account
         */
        public int depositCash(int cash, int ubalance)//user deposit cash
        {

            ubalance += cash;
            return ubalance;
        }
        /*if withdraw money then reduce particular person account mony
         * if withdraw cash is more than account balance then shows massage
         * insufficient balance
         */
        public int withdrawCash(int cash, int ubalance)//user withdraw cash
        {
            if (ubalance <= 0)
            {
                Console.WriteLine("cash is not available");
                return 0;
            }
            else
            {
                ubalance -= cash;
                return ubalance;
            }
        }

    }

}
