﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AuthModel
{
    public class SystemView : BaseModel
    {
        [Required(ErrorMessage = "Please fill this field")]
        [DisplayName("Page Name")]
        public string Name { get; set; }
        public List<SystemUserPermission> SystemUserPermissions { get; set; }

    }
}
