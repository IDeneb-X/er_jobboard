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
        [Required(ErrorMessage = "Required {0}")]
        [DataMember(IsRequired = true)]
        public string job { get; set; }

        [Display(Name = "Job title")]
        [Required(ErrorMessage = "Required {0}")]
        [DataMember(IsRequired = true)]
        public string job_title { get; set; }

        [Display(Name = "Description")]
        [MaxLength(150)]
        [DataType(DataType.MultilineText)]
        [DataMember(IsRequired = true)]
        public string description { get; set; }

        [Display(Name = "Created At")]
        [DataMember(IsRequired = true)]
        public string created_at { get; set; }

        [Display(Name = "Expires At")]
        [DataMember(IsRequired = true)]
        public string expires_at { get; set; }
    }
}