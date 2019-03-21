using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class RatesRepository
    {
        List<Rates> _rates = new List<Rates>();
      
        public decimal CalculateCost(Cost cost)
        {
            decimal totalPremium = 75m;
            switch (cost)
            {
                case Cost.SpeedCost:
                    totalPremium = 50m;
                    break;

                case Cost.SwerveCost: 
                    totalPremium = 100m; 
                    break;

                case Cost.StopCost:
                    totalPremium = 175m;
                    break;

                case Cost.SpaceCost:
                    totalPremium = 105m;
                    break; 
            }

            return totalPremium; 

        }

    }
}
