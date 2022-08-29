using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Models
{
    public class StudentCourse:BaseModel
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public virtual StudentProfile Student { get; set; }
        public virtual Course Course{ get; set; }

    }
}
