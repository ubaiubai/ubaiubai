using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL
{
    class Players : Team, IComparable
    {
        int id;
        string name;
        int age;
        string battingStyle;
        string bowlingStyle;

        public Players()
        {
        }

        public Players(int id, string name, int age, string battingStyle, string bowlingStyle)
        {
            Id = id;
            Name = name;
            Age = age;
            BattingStyle = battingStyle;
            BowlingStyle = bowlingStyle;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string BattingStyle { get => battingStyle; set => battingStyle = value; }
        public string BowlingStyle { get => bowlingStyle; set => bowlingStyle = value; }

        public int CompareTo(object obj)
        {
            Players p = (Players)obj;
            return this.BattingStyle.CompareTo(p.BattingStyle);

        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Id, Name, Age, BattingStyle);
        }

        public override bool Equals(object obj)
        {
            Players p = (Players)obj;

            return this.BattingStyle.Equals(p.BattingStyle);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}