using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthLab.Framework.AccountLab
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }
    }
}
