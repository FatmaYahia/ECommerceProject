using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AuthModel
{
    public class SystemUserPermission : BaseModel
    {

        [ForeignKey(nameof(SystemUser))]
        public int Fk_systemUser { get; set; }
        [DisplayName("System User")]
        public SystemUser SystemUser { get; set; }
        [ForeignKey(nameof(AccessLevel))]
        public int Fk_accessLevel { get; set; }
        [DisplayName("Access Level")]
        public AccessLevel AccessLevel { get; set; }
        [ForeignKey(nameof(SystemView))]
        public int Fk_systemView { get; set; }
        [DisplayName("System View")]
        public SystemView SystemView { get; set; }
    }
}
