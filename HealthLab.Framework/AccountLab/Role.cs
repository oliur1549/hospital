using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthLab.Framework.AccountLab
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }
    }
}
