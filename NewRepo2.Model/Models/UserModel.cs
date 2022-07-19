using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Model.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }        
        public string Surname { get; set; }
        [Display(Name ="UserRoles_Model")]
        public virtual int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual UserRoles UserRoles { get; set; }
    }
}
