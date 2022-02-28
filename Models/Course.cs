namespace Api.Workshop.Models
{
    public record Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }

        public List<Student> Students { get; set; }

    }
}