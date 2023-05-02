namespace GestionEntreprise.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Service? Service { get; set; }
        public List<Employee>? Employees { get; set; }

    }
}
