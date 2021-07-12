namespace ContractManager.Models
{
    using System;
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Common.DatabaseConstants;

    public class Employee : IdentityUser
    {
        public Employee()
        {
            this.EmployeesOffices = new HashSet<EmployeesOffice>();
            this.ContractHeaders = new HashSet<ContractHeader>();
            //this.Id = Guid.NewGuid().ToString();
        }

        public bool IsActive { get; set; } = true;

        [Required]
        [MaxLength(MaxPeopleNamesLength)]
        public string EmployeeName { get; set; }

        public virtual ICollection<EmployeesOffice> EmployeesOffices { get; set; }

        public virtual ICollection<ContractHeader> ContractHeaders { get; set; }
    }
}