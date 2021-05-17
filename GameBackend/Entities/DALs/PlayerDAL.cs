using GameBackend.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend.Entities.DALs
{
    public class PlayerDAL 
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog = GameBackend;
                                                          integrated security = true");
        public void Add(Player player)
        {
            using (GameBackendContext gbContext = new GameBackendContext())
            {
                var entity = gbContext.Entry(player);
                entity.State = EntityState.Added;
                gbContext.SaveChanges();
            }
        }
        public void Update(Player player)
        {
            using (GameBackendContext gbContext = new GameBackendContext())
            {
                var entity = gbContext.Entry(player);
                entity.State = EntityState.Modified;
                gbContext.SaveChanges();
            }
        }
        public void Delete(Player player)
        {
            using (GameBackendContext gbContext = new GameBackendContext())
            {
                var entity = gbContext.Entry(player);
                entity.State = EntityState.Deleted;
                gbContext.SaveChanges();
            }
        }
        public bool CheckLogin(string NatID, string Pwd)
        {
            using (GameBackendContext context = new GameBackendContext())
            {
                var login = false;
                var credentials = context.Player.Where(x => x.NationalID == NatID && x.Password == Pwd).ToList();
                if(credentials != null)
                {
                    login = true;
                }
                return login;
            }
        }

        public void ConnectionControl()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}
