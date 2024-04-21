using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceStation14_HoPBase.Data;
namespace SpaceStation14_HoPBase.Service
{
    public enum BaseStatus
    {
        Saved,
        Edit,
        Unknown
    }
    public static class SaveLoadService
    {
        public static string FileName;
        public static BaseStatus Status;
        public static List<Player> players = new List<Player>();
    }
}
