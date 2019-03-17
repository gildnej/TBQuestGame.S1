using System.Collections.Generic;

namespace TBQuestGame.S_.Models
{
    public class Player : Character
    {
        #region Enumn
        public enum Professtion
        {
            Explorer, Commander, Adventurer
        }
        #endregion

        #region Fields
        public int _lives;
        public Professtion _JobTitle;
        public int _health;
        public int _sanity;
        #endregion

        #region Properties
        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }
        public Professtion JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public int Sanity
        {
            get { return _sanity; }
            set { _sanity = value; }
        }
        #endregion

        #region Constructor
        public Player()
        {
        }
        #endregion

        #region Method
        public override string DefaultGreeting()
        {
            string article = "a";

            List<string> vowels = new List<string>() { "A", "E", "I", "O", "U" };

            if (vowels.Contains(JobTitle.ToString().Substring(0, 1)))
            {
                article = "an";
            }

            return $"Hello, my name is {Name} and I am {article} {JobTitle} for the Aion Project.";
        }
        #endregion

        #region Events

        #endregion
    }
}
