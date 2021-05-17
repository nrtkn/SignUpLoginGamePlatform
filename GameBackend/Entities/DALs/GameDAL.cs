using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend.Entities.DALs
{
    public class GameDAL
    {
        SqlConnection conn = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog = GameBackend;
                                                          integrated security = true");

        public void Add(Games game)
        {
            using (GameBackendContext gbContext = new GameBackendContext())
            {
                var entity = gbContext.Entry(game);
                entity.State = EntityState.Added;
                gbContext.SaveChanges();
            }
        }
        public void Update(Games game)
        {
            using (GameBackendContext gbContext = new GameBackendContext())
            {
                var entity = gbContext.Entry(game);
                entity.State = EntityState.Modified;
                gbContext.SaveChanges();
            }
        }
        public void Delete(Games game)
        {
            using (GameBackendContext gbContext = new GameBackendContext())
            {
                var entity = gbContext.Entry(game);
                entity.State = EntityState.Deleted;
                gbContext.SaveChanges();
            }
        }

        public void getGames()
        {
            using (GameBackendContext gbContext = new GameBackendContext())
            {
               
            }
        }

        public void ConnectionControl()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}
