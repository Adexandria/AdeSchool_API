using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeSchool.Domain.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public StateOfOrigin StateOfOrigin { get; set; }
        public Class Class { get; set; }  
        public Classroom Classroom { get; set; }
        public IList<Teacher> Teachers { get; set; } = new List<Teacher>();
        public IList<Subject> Subjects { get; set; } = new List<Subject>();
        public IList<Guardian> Parents { get; set; } = new List<Guardian>();
        public IList<Result> Results { get; set; } = new List<Result>();
        public IList<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}
