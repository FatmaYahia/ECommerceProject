using Entity.AuthModel;
using System.ComponentModel;

namespace ECommerce.AppAdmin.ViewModel
{
    public class SystemUserVM
    {
        public SystemUser SystemUser { get; set; }
        [DisplayName("View Access Level")]
        public List<int> viewAccessLevelList { get; set; }
        [DisplayName("Control Access Level")]
        public List<int> controlAccessLevellList { get; set; }
        [DisplayName("Full Access Level")]
        public List<int> fullAccessLevelList { get; set; }
    }
}
