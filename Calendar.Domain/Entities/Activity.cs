using System;
using System.ComponentModel.DataAnnotations;


namespace Calendar.Domain.Entities
{
    class Activity
    {
        [Required]
        public Guid AcitivityID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    }
}
