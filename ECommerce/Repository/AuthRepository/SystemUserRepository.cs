using BaseRepository;
using DAL;
using Entity.AuthModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AuthRepository
{
    public class SystemUserRepository:BaseRepository<SystemUser>
    {
        private readonly DataContext DB;
        public SystemUserRepository(DataContext db):base(db) 
        { 
        }
    }
}
