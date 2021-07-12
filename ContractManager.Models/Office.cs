namespace ContractManager.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Common.DatabaseConstants;

    public class Office : BaseEntity
    {
        public Office()
        {
            this.EmployeesOffices = new HashSet<EmployeesOffice>();
            this.ClientCompanies = new HashSet<ClientCompany>();
        }

        [Required]
        [MaxLength(MaxCompanyNameLength)]
        public string OfficeName { get; set; }

        public bool IsClosed { get; set; } = false;

        [Required]
        public string MainCompanyId { get; set; }

        public MainCompany MainCompany { get; set; }

        public virtual ICollection<ClientCompany> ClientCompanies { get; set; }

        public virtual ICollection<EmployeesOffice> EmployeesOffices { get; set; }
    }
}   