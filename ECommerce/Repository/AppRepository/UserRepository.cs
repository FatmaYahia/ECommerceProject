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
    public class UserRepository:BaseRepository<User>
    {
        private readonly DataContext DB;
        public UserRepository(DataContext db):base(db)
        {
            DB = db;
        }
    }
}
