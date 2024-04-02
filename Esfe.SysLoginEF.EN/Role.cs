using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Esfe.SysLoginEF.EN
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("Name Role")]
        public string Name { get; set; }

    }
}
