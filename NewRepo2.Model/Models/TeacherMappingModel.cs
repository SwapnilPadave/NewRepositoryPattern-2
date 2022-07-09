using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Model.Models
{
    public class TeacherMappingModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Teacher_Model")]
        public virtual int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
        [Display(Name ="Subject_Model")]
        public virtual int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
    }
}
