namespace AdeSchool.Domain.Models
{
    public class Classroom
    {
        public Guid ClassroomId { get; set; }
        public string Name { get; set; }    
        public IList<Student> Students { get; set; } = new List<Student>();
        public IList<Teacher> Teachers { get; set; } = new List<Teacher>();

    }
}