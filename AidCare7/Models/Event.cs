using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AidCare7.Models
{
    public class Event
    {
        public int EventId { get; set; }
        [Display(Name = "Event Name"), Required, MaxLength(50)]
        public string EventName { get; set; }
        [Display(Name = "Event Location"), Required, MaxLength(50)]
        public string EventLocation { get; set; }
        [Display(Name = "Event Date and Time")]
        public DateTime EventDateTime { get; set; }
        public ICollection<memberevent> memberevent { get; set; }

    }
}
