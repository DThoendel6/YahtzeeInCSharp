using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int UserHighScore { get; set; }
        public int UserNumberOfGamesPlayed { get; set; }

        public User() { }

        public User(int id, string username, int highscore, int games)
        {
            UserId = id;
            Username = username;
            UserHighScore = highscore;
            UserNumberOfGamesPlayed = games;
        }
    }
}
