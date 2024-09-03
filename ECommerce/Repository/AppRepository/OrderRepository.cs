using BaseRepository;
using DAL;
using Entity.AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AppRepository
{
    public class OrderRepository:BaseRepository<Order>
    {
        private readonly DataContext DB;
        public OrderRepository(DataContext db):base(db)
        {
            DB = db;
        }
    }
}
