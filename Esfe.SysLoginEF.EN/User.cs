using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysLoginEF.EN
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("PassWord")]
        [StringLength(10)]
        public string Password { get; set; }
        [Required]
        public int RoleId { get; set; }
        public Role Roles { get; set; }

    }
}
