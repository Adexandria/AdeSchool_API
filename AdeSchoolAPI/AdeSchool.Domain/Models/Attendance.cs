namespace AdeSchool.Domain.Models
{
    public class Attendance
    {
        public Guid AttendanceId { get; set; }
        public DateTime Date { get; protected set; }
        public bool IsPresent { get; set; } = false;
        public Student Student { get; set; }
    }
}