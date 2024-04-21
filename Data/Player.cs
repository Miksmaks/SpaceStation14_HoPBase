using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation14_HoPBase.Data
{
    public class Player
    {
        public string Name;
        public string Jobs;
        public string Other;
        public Player(string name,string jobs,string other) 
        {
            Name = name;
            Jobs = jobs;
            Other = other;
        }
    }
}
