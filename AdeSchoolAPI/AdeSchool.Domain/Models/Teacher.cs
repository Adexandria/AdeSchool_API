using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeSchool.Domain.Models
{
    public class Teacher
    {
        public Guid TeacherId { get; set; }
        public Title Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Subject Subject { get; set; }
        public IList<Student> Students = new List<Student>();
        public IList<Classroom> Classrooms = new List<Classroom>();
        
    }
}
