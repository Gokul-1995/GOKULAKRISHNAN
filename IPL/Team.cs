using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL
{
    public class Team
    {
        string teamName;
        string country;

        public string TeamName { get => teamName; set => teamName = value; }
        public string Country { get => country; set => country = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}