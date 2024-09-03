namespace WebApplication1.Models.Dtos
{
    public class AddEmployeeDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? PhoneNumber { get; set; } //this make this as a nullable property 
    }
}
