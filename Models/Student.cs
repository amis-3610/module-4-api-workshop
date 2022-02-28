namespace Api.Workshop.Models
{
    public record Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Address? Address { get; set; }
    }
}