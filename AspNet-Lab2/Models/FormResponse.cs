using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNet_Lab2.Models
{
    public class FormResponse
    {
        [DisplayName("Dni od urodzenia")]
        public int DaysSinceBirthday { get; set; }
     
        [DisplayName("Rok przestępny")]
        public bool IsLeapYear { get; set; }

        [DisplayName("Imię")]
        public string FirstName { get; set; }
    }
}
