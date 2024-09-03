namespace WebApplication1.Models.Entities
{
    public class Employees //this class is like a table in sql each field is like a coloumn
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; } //this make this as a nullable property 

    }
}
