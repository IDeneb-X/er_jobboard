using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace er_jobboard.Models
{
    [Table("tb_jobboard")]
    [DataContract]
    public class JobBoard
    {
        [Key]
        [Display(Name = "Id")]
        [DataMember(IsRequired = true)]
        public int Id { get; set; }

        [Display(Name = "Job")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Required {0}")]
        [DataMember(IsRequired = true)]
        public string job { get; set; }

        [Display(Name = "Job title")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Required {0}")]
        [DataMember(IsRequired = true)]
        public string job_title { get; set; }

        [Display(Name = "Description")]
        [MaxLength(150)]
        [DataType(DataType.MultilineText)]
        [DataMember(IsRequired = true)]
        public string description { get; set; }

        [Display(Name = "Created At")]
        [MaxLength(50)]
        [DataMember(IsRequired = true)]
        public string created_at { get; set; }

        [Display(Name = "Expires At")]
        [MaxLength(50)]
        [DataMember(IsRequired = true)]
        public string expires_at { get; set; }
    }
}