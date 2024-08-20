using BaseRepository;
using DAL;
using Entity.AuthModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Common.DataEnum;

namespace Repository.AuthRepository
{
    public class SystemUserPermissionRepository:BaseRepository<SystemUserPermission>
    {
        private readonly DataContext DB;
        public SystemUserPermissionRepository(DataContext DB):base(DB)
        {
            this.DB = DB;
        }
        public bool checkAuthorization(int fk_AccessLevel,string Email ,string viewName)
        {

            if (fk_AccessLevel == (int)AccessLevelEnum.FullAccess)
            {
                return isFullAccess(Email, viewName);
            }
            else if (fk_AccessLevel == (int)AccessLevelEnum.ControlAccess)
            {
                return isControlAccess(Email, viewName);
            }
            else if (fk_AccessLevel == (int)AccessLevelEnum.ViewAccess)
            {
                return isViewAccess(Email, viewName);
            }
            return false;
        }
        public bool isFullAccess(string Email,string viewName)
        {
            bool result = DB.SystemUserPermissions.Where(x => x.SystemUser.Email == Email)
                .Where(x => x.SystemView.Name == viewName).Where(x => x.Fk_accessLevel == (int)AccessLevelEnum.FullAccess).Any();
            return result;
        }
        public bool isControlAccess(string Email, string viewName)
        {
            bool result = DB.SystemUserPermissions.Where(x => x.SystemUser.Email == Email)
                .Where(x => x.SystemView.Name == viewName)
                .Where(x => x.Fk_accessLevel == (int)AccessLevelEnum.FullAccess|| x.Fk_accessLevel==(int)AccessLevelEnum.ControlAccess).Any();
            return result;
        }
        public bool isViewAccess(string Email, string viewName)
        {
            bool result = DB.SystemUserPermissions.Where(x => x.SystemUser.Email == Email)
                .Where(x => x.SystemView.Name == viewName)
                .Where(x => x.Fk_accessLevel == (int)AccessLevelEnum.FullAccess|| x.Fk_accessLevel==(int)AccessLevelEnum.ControlAccess
                ||x.Fk_accessLevel==(int)AccessLevelEnum.ViewAccess).Any();
            return result;
        }
    }
}
