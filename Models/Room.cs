using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_Reservation_System.Models
{
    /// <summary>
    /// Tworzenie classy Room i komponentow
    /// </summary>
    public class Room
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
        [Required]
        public string RType { get; set; }
        public bool Isactive { get; set; }
        public DateTime Date { get; set; }

        [NotMapped]
        public virtual string[] RTypes => new string[] {"First Class", "2nd Class", "Third Class"};

    }
}