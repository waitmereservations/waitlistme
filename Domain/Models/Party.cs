using System;
using System.Collections.Generic;

#nullable disable

namespace Waitlistme.Domain.Models
{
    public partial class Party
    {
        public Party()
        {
            FloorTables = new HashSet<FloorTable>();
            PartyTableLogs = new HashSet<PartyTableLog>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int? QuoteTime { get; set; }
        public int PartyTypeid { get; set; }
        public int? PartySize { get; set; }
        public int FloorTableId { get; set; }
        public int PartyStatusId { get; set; }
        public DateTime? ReservationTime { get; set; }
        public bool? ReservationConfirmed { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual FloorTable FloorTable { get; set; }
        public virtual PartyStatus PartyStatus { get; set; }
        public virtual PartyType PartyType { get; set; }
        public virtual ICollection<FloorTable> FloorTables { get; set; }
        public virtual ICollection<PartyTableLog> PartyTableLogs { get; set; }
    }
}
