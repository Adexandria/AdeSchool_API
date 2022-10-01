namespace AdeSchool.Domain.Models
{
    public class Result
    {
        public Guid ResultId { get; set; }
        public string Term { get; set; }
        public string Session { get; set; }
        public Grade Grade { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}