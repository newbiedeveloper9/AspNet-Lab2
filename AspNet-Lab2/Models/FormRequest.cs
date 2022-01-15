using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNet_Lab2.Models
{
    public class FormRequest
    {
        [Required] 
        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }
    }
}
