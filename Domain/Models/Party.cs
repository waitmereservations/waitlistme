using System;
using System.Collections.Generic;

#nullable disable

namespace Waitlistme.Domain.Models
{
    public partial class Party
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int? QuoteTime { get; set; }
        public int PartyTypeid { get; set; }
        public int? PartySize { get; set; }
        public int PartyStatusId { get; set; }
        public DateTime? ReservationTime { get; set; }
        public bool? ReservationConfirmed { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
