using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Models
{
    public class TeacherCourses:BaseModel
    {
        public Guid TeachertId { get; set; }
        public Guid CourseId { get; set; }
        public virtual TeacherProfile Student { get; set; }
        public virtual Course Course{ get; set; }

    }
}
