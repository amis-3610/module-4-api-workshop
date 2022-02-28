namespace Api.Workshop.Models
{
    public record Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Address? Address { get; set; }
        public List<Course>? Courses { get; set; }
    }
}