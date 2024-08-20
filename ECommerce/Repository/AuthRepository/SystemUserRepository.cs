using BaseRepository;
using DAL;
using Entity.AuthModel;
using Microsoft.EntityFrameworkCore;
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
            DB = db;
        }
        public List<SystemUser> GetAll()
        {
            return DB.SystemUsers.Include(x=>x.SystemUserPermissions).ToList();
        }
        public SystemUser GetById(int id)
        {
            return DB.SystemUsers.Include(x => x.SystemUserPermissions).SingleOrDefault(x => x.Id == id);
        }

        public bool userExist(string Email,string Password=null)
        {
            bool result= DB.SystemUsers.Where(x => x.Email == Email)
                .Where(x => x.Password == Password || Password == null).Any();
            
            return result;
        }
        public SystemUser getByEmail(string Email)
        {
            SystemUser result=DB.SystemUsers.Where(x=>x.Email==Email).FirstOrDefault();
            return result;
        }
        public List<SystemView> getSystemUserViews(int systemUserId)
        {
           List<SystemView> systemViews= DB.SystemUserPermissions.Where(x => x.Fk_systemUser == systemUserId).
                Select(x => x.SystemView).ToList();
            return systemViews;
        }
    }
}
