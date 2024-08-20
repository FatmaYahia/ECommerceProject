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
    public class SystemViewRepository:BaseRepository<SystemView>
    {
        private readonly DataContext DB;
        public SystemViewRepository(DataContext DB):base(DB)
        {
            this.DB = DB;
        }
        public List<SystemView> getSystemUserViews(int systemUserId)
        {
            List<SystemView> systemViews = DB.SystemUserPermissions.Where(x => x.Fk_systemUser == systemUserId).
                 Select(x => x.SystemView).ToList();
            return systemViews;
        }
    }
}
