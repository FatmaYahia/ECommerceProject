using DAL;
using Repository.AuthRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    
    public class UnitOfWork
    {
        private readonly DataContext DB;
        public UnitOfWork( DataContext db)
        {
            DB = db;
        }
        public SystemUserRepository SystemUserRepository=>new SystemUserRepository(DB);
        public SystemViewRepository SystemViewRepository=>new SystemViewRepository(DB);
        public SystemUserPermissionRepository SystemUserPermissionRepository=> new SystemUserPermissionRepository(DB);  
    }
}
