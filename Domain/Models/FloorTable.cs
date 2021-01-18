using System;
using System.Collections.Generic;

#nullable disable

namespace Waitlistme.Domain.Models
{
    public partial class FloorTable
    {
        public FloorTable()
        {
            Parties = new HashSet<Party>();
            PartyTableLogs = new HashSet<PartyTableLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TableStatusId { get; set; }
        public int PartyId { get; set; }
        public int? Capacity { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Party Party { get; set; }
        public virtual TableStatus TableStatus { get; set; }
        public virtual ICollection<Party> Parties { get; set; }
        public virtual ICollection<PartyTableLog> PartyTableLogs { get; set; }
    }
}
