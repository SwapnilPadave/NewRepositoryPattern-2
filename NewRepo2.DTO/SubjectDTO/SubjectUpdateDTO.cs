using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.DTO.SubjectDTO
{
    public class SubjectUpdateDTO
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int CourseId { get; set; }
    }
}
