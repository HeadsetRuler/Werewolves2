using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Werewolves2.Shared
{
    public class Player
    {
        public Player()
        {
            
        }
    }
    public enum Role
    {
        Werewolf, Villager
    }
    public class Game
    {
        public string Name { get; set; }
        public List<Role> PlayerRoles { get; }
        public double Ratio { get; set; }
        private readonly Random _rng = new Random();
        public Game(string inName, int inPlayers)
        {
            Name = inName;
            PlayerRoles = new List<Role>(inPlayers);
            Ratio = Math.Ceiling(inPlayers / 5f);
            for (int i = 0; i < inPlayers; i++)
            {
                if (i < Ratio)
                {
                    PlayerRoles[i] = Role.Werewolf;
                }
                else
                {
                    PlayerRoles[i] = Role.Villager;
                }
            }

            PlayerRoles = PlayerRoles.OrderBy(a => _rng.Next()).ToList();
        }
    }
}
