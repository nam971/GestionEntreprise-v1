namespace GestionEntreprise.Models
{
    public class Service
    {
        public int Id { get; set;  }
        public string? Name { get; set; }
        public List<Employee>? Employees { get; set; }
        public List<Job>? Jobs { get; set; }
    }
}
