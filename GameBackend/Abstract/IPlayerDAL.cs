using GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend.Abstract
{
    public interface IPlayerDAL
    {
        void ConnectionControl();
        void Add(Player player);
        void Update(Player player);
        void Delete(int IDPlayer);
    }
}
