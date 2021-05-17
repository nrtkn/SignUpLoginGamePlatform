using GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend
{
    public class GameBackendContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
    }
}
