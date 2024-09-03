using AutoMapper;
using AutoMapper.Configuration.Conventions;
using ECommerce.AppAdmin.Filter;
using ECommerce.AppAdmin.ViewModel;
using Entity.AuthModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using System.Reflection.Metadata;
using static Common.DataEnum;

namespace ECommerce.AppAdmin.Controllers
{
    public class SystemUserController : Controller
    {
        private readonly UnitOfWork UOW;
        private readonly IMapper mapper;
        public SystemUserController(UnitOfWork UOW,IMapper mapper)
        {
             this.UOW= UOW;
            this.mapper = mapper;
        }
        [Authorize((int)AccessLevelEnum.ViewAccess)]
        public IActionResult Index()
        {
            return View(UOW.SystemUserRepository.GetAll());
        }
        [Authorize((int)AccessLevelEnum.ControlAccess)]
        public IActionResult CreateOrEdit(int id = 0)
        {
            SystemUser systemUser = new SystemUser();
            if (id > 0)
            {
                
                systemUser = UOW.SystemUserRepository.GetById(id);
                if(systemUser == null)
                {
                    return NotFound();
                }
            }
            return View(GetSystemUserVM(systemUser));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrEdit(int id,SystemUserVM systemUserVM)
        {
            try
            {
                if (id > 0)
                {
                    SystemUser Data = UOW.SystemUserRepository.GetById(id);
                    mapper.Map(systemUserVM.SystemUser, Data);
                    UOW.SystemUserRepository.UpdateEntity(Data);
                    UOW.SystemUserRepository.Save();
                }
                else
                {
                    UOW.SystemUserRepository.CreateEntity(systemUserVM.SystemUser);
                    UOW.SystemUserRepository.Save();
                }
              
                    UOW.SystemUserPermissionRepository.DeleteEntity(UOW.SystemUserPermissionRepository.GetAll().Where(x => x.Fk_systemUser == systemUserVM.SystemUser.Id).ToList());
                    UOW.SystemUserPermissionRepository.CreateEntity(new SystemUserPermission
                    {
                        Fk_systemView = (int)SystemViewEnum.Home,
                        Fk_accessLevel = (int)AccessLevelEnum.ViewAccess,
                        Fk_systemUser = systemUserVM.SystemUser.Id,

                    });
                    if (systemUserVM.fullAccessLevelList !=null)
                    {
                        foreach (var item in systemUserVM.fullAccessLevelList)
                        {
                            UOW.SystemUserPermissionRepository.CreateEntity(new SystemUserPermission
                            {
                                Fk_systemView = item,
                                Fk_accessLevel = (int)AccessLevelEnum.FullAccess,
                                Fk_systemUser = systemUserVM.SystemUser.Id,
                            });
                        }
                    }
                    if (systemUserVM.controlAccessLevellList != null)
                    {
                        if (systemUserVM.fullAccessLevelList != null)
                        {
                            systemUserVM.controlAccessLevellList = systemUserVM.controlAccessLevellList.Where(x => !systemUserVM.fullAccessLevelList.Contains(x)).ToList();
                        }
                        if (systemUserVM.controlAccessLevellList != null)
                        {
                            foreach (var item in systemUserVM.controlAccessLevellList)
                            {
                                UOW.SystemUserPermissionRepository.CreateEntity(new SystemUserPermission
                                {
                                    Fk_systemView = item,
                                    Fk_accessLevel = (int)AccessLevelEnum.ControlAccess,
                                    Fk_systemUser = systemUserVM.SystemUser.Id,
                                });
                            }
                        }
                    }
                if (systemUserVM.viewAccessLevelList != null)
                {
                    if (systemUserVM.fullAccessLevelList != null)
                    {
                        systemUserVM.viewAccessLevelList = systemUserVM.viewAccessLevelList.Where(x => !systemUserVM.fullAccessLevelList.Contains(x)).ToList();
                    }
                    if (systemUserVM.controlAccessLevellList != null)
                    {
                        systemUserVM.viewAccessLevelList = systemUserVM.viewAccessLevelList.Where(x => !systemUserVM.controlAccessLevellList.Contains(x)).ToList();
                    }
                    if (systemUserVM.viewAccessLevelList != null)
                    {
                        foreach (var item in systemUserVM.viewAccessLevelList)
                        {
                            UOW.SystemUserPermissionRepository.CreateEntity(new SystemUserPermission
                            {
                                Fk_systemView = item,
                                Fk_accessLevel = (int)AccessLevelEnum.ViewAccess,
                                Fk_systemUser = systemUserVM.SystemUser.Id,
                            });
                        }
                    }
                }
                    UOW.SystemUserPermissionRepository.Save();
                
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UOW.SystemUserRepository.userExist(systemUserVM.SystemUser.Email))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        [Authorize((int)AccessLevelEnum.ViewAccess)]
        public IActionResult Details(int id)
        {
            SystemUser systemUser = UOW.SystemUserRepository.GetById(id);
            if (systemUser == null)
            {
                return NotFound();
                
            }
            return View(systemUser);
        }
        [Authorize((int)AccessLevelEnum.FullAccess)]
        public IActionResult Delete(int id)
        {
            SystemUser systemUser = UOW.SystemUserRepository.GetById(id);
            if (systemUser == null)
            {
                return NotFound();

            }
            ViewBag.canDelete = true;
            if (id == 1)
            {
                ViewBag.canDelete = false;
            }
            return View(systemUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult confirmDelete(int id)
        {
            SystemUser systemUser = UOW.SystemUserRepository.GetById(id);
            UOW.SystemUserRepository.DeleteEntity(systemUser);
            UOW.SystemUserRepository.Save();
            return RedirectToAction(nameof(Index));
        }
        public SystemUserVM GetSystemUserVM(SystemUser systemUser)
        {
            SystemUserVM systemUserVM = new SystemUserVM()
            {
                SystemUser=systemUser
            };
            if (systemUser.SystemUserPermissions != null && systemUser.SystemUserPermissions.Any())
            {
                systemUserVM.viewAccessLevelList = systemUser.SystemUserPermissions.Where(x => x.Fk_accessLevel == (int)AccessLevelEnum.ViewAccess)
                    .Select(x => x.Fk_systemView).ToList();
                systemUserVM.controlAccessLevellList = systemUser.SystemUserPermissions.Where(x => x.Fk_accessLevel == (int)AccessLevelEnum.ControlAccess)
                    .Select(x => x.Fk_systemView).ToList();
                systemUserVM.fullAccessLevelList = systemUser.SystemUserPermissions.Where(x => x.Fk_accessLevel == (int)AccessLevelEnum.FullAccess)
                                    .Select(x => x.Fk_systemView).ToList();

            }
            return systemUserVM;
        }
    }
}
