using AutoMapper;
using Entity.AuthModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AutoMapper
{
    public class AutoMapping:Profile
    {
        public AutoMapping() 
        {
            CreateMap<SystemUser, SystemUser>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.CreatedAt, opt => opt.Ignore())
                .ForMember(x => x.SystemUserPermissions, opt => opt.Ignore());
            CreateMap<SystemView, SystemView>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.CreatedAt, opt => opt.Ignore())
                .ForMember(x => x.SystemUserPermissions, opt => opt.Ignore());
        }
    }
}
