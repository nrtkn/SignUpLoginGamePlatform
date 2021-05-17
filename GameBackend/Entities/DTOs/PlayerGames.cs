using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend.Entities.DTOs
{
    public class PlayerGames
    {
        public int IDPlayerGame { get; set; }
        public int IDPlayer { get; set; }
        public int IDGame { get; set; }
    }
}
