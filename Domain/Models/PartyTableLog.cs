using System;
using System.Collections.Generic;

#nullable disable

namespace Waitlistme.Domain.Models
{
    public partial class PartyTableLog
    {
        public int Id { get; set; }
        public int PartyId { get; set; }
        public int TableId { get; set; }
        public int TableStatusId { get; set; }
        public string ActionMsg { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Party Party { get; set; }
        public virtual FloorTable Table { get; set; }
        public virtual TableStatus TableStatus { get; set; }
    }
}
