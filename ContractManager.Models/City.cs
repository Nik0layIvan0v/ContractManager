namespace ContractManager.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Common.DatabaseConstants;

    public class City : BaseEntity
    {
        public City()
        {
            this.ClientCompanies = new HashSet<ClientCompany>();
            this.MainCompanies = new HashSet<MainCompany>();
            this.Farms = new HashSet<Farm>();
        }

        [Required]
        [MaxLength(MaxLocationNameLength)]
        public string CityName { get; set; }

        [Required]
        [MaxLength(MaxEKATTENumberLength)]
        public string EkatteNumber { get; set; }

        public virtual ICollection<ClientCompany> ClientCompanies { get; set; }

        public virtual ICollection<Farm> Farms { get; set; }

        public virtual ICollection<MainCompany> MainCompanies { get; set; }
    }
}