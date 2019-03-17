using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.S_.Models
{
   public class Character
    {
        #region Enumn
        public enum RaceType
        {
            Human,
            Dwarf,
            Elf,
            Goblin,
            DarkElf,
        }
        #endregion

        #region Fields
        private int _id;
        private string _name;
        private int _age;
        private RaceType _race;
        private int _locationId;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public RaceType Race
        {
            get => _race;
            set => _race = value;
        }
        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }
        #endregion

        #region Methods
        public virtual string DefaultGreeting()
        {
            return $"Hello, my name is {_name}";
        }
        #endregion
    }
}
