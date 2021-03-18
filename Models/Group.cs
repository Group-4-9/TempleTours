using System;
using System.ComponentModel.DataAnnotations;
using TempleTours.Models;

namespace TempleTours.Models
{
    public class Group
    {
        [Key]
        [Required]
        public int GroupID { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        public int Size { get; set; }
        
        [Required]
        public string Email { get; set; }

        // TODO: decide whether to enforce formatting on the view or in the model, do that
        public string Phone { get; set; }

        public TimeslotModel.Timeslot GroupSlot { get; set; }

    }
}
