using SmellyDirtyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmellyDirtyApp.Bll
{
    public class Bll_Course
    {
        public IEnumerable<Course> GetCourses()
        {
            return new List<Course>();
        }

        public StudentCourse GetStudentCourse(Guid courseId, Guid studentId)
        {
            return new StudentCourse();
        }

        public void SetResault(Guid courseId,Guid studentId,int resault)
        {
            StudentCourse studentCourse = GetStudentCourse(courseId,studentId);
            studentCourse.Course.Resault = resault;
        }

        public IEnumerable<Course> OfferCourses()
        {
            return new List<Course>();
        }

        public void SelectCourse(Guid courseId)
        {
        }

        public int GetResault()
        {
            int resault = 0;
            var courses = GetCourses();
            foreach (var course in courses)
            {
                resault += course.Resault;
            }
            return resault;
        }
    }
}
