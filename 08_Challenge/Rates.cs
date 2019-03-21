using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public enum Cost { SpeedCost, SwerveCost, StopCost, SpaceCost, basePremium }
    public class Rates
    {
        public Cost Cost { get; set; }
        public string ClientName { get; set; }
        public int SpeedViolations { get; set; }
        public int SwerveViolations { get; set; }
        public int StopViolations { get; set; }
        public int SpaceViolations { get; set; }
        public List<Rates> _rates { get; set; }

        public Rates(string client, int speed, int swerve, int stop, int space, Cost cost)
        {
            ClientName = client; 
            SpeedViolations = speed;
            SwerveViolations = swerve;
            StopViolations = stop;
            SpaceViolations = space;
            Cost = cost; 
            _rates = new List<Rates>(); 
        }

        public Rates()
        {
            _rates = new List<Rates>();
        }

       

    }
}
