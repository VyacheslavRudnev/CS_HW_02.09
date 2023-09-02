using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp020923
{
    public class FootballTeam
    {
        public string TeamName { get; set; }
        public List<TeamPlayer> Players { get; set; }
        public FootballTeam(string teamName)
        {
            TeamName = teamName;
            Players = new List<TeamPlayer>();
        }
        public IEnumerator<TeamPlayer> GetEnumerator()
        {
            return Players.GetEnumerator();
        }
    }
}
