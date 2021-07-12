namespace ContractManager.Models
{
    using System.ComponentModel.DataAnnotations;

    public class EmployeesOffice
    {
        [Required]
        public string EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Required]
        public string OfficeId { get; set; }

        public Office Office { get; set; }
    }
}