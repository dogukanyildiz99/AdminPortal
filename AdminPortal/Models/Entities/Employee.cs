namespace AdminPortal.Models.Entities
{
    public class Employee
    {
        // Guid means Global Unique Identifier
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
