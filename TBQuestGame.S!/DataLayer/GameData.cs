using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.S_.Models;

namespace TBQuestGame.S_.DataLayer
{
   public class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Jetto",
                Age = 26,
                JobTitle = Player.Professtion.Adventurer,
                Race = Character.RaceType.Goblin,
                Health = 100,
                Lives = 1,
                Sanity = 0,
                LocationId = 0
            };
        }
        public static List<string> InitialMesseges()
        {
            return new List<string>()
            {
                "\tCongratulations You have been chosen by the Corporation to participate in its latest endeavor, the Aion Project. Your task is to escape...If you escape in the time limit you will be rewared with one million dollars and all your debts cleared.",
                "\tThe only rule is you won't be able to tell anyone about the Aion Project."
            };
        }
    }
}
