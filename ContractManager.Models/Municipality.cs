namespace ContractManager.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Common.DatabaseConstants;

    public class Municipality : BaseEntity
    {
        public Municipality()
        {
            this.Cities = new HashSet<City>();
        }

        [Required]
        public string DistrictId { get; set; }

        public District District { get; set; }

        [Required]
        [MaxLength(MaxLocationNameLength)]
        public string MunicipalityName { get; set; }
            
        [Required]
        [MaxLength(MaxSuffixLength)]
        public string MunicipalitySuffixCode { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}