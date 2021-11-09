using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL
{
    class PlayersBO : Players, IComparable
    {

        public int CompareTo(object obj)
        {
            PlayersBO p = (PlayersBO)obj;
            return this.BattingStyle.CompareTo(p.BattingStyle);

        }
        public static void SearchPlayerMethod(object[] arr, string name)
        {
             


        }
    }
}