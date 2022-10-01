namespace AdeSchool.Domain.Models
{
    public class Guardian
    {
       public Guid GuardianId { get; set; }
       public Title Title { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public Relationship Relationship { get; set; }
       public string PhoneNumber { get; set; }
       public string Address { get; set; }     
        
       public IList<Student> Students = new List<Student>();
        
    }
}