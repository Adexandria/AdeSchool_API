namespace AdeSchool.Domain.Models
{
    public class Subject
    {
        public Guid SubjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Teacher Teacher { get; set; }
        public IList<Result> Results { get; set; } = new List<Result>();
        public IList<Student> Students { get; set; } = new List<Student>();
        

    }
}