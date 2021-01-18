using System;
using System.Collections.Generic;

#nullable disable

namespace Waitlistme.Domain.Models
{
    public partial class TableStatus
    {
        public TableStatus()
        {
            FloorTables = new HashSet<FloorTable>();
            PartyTableLogs = new HashSet<PartyTableLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FloorTable> FloorTables { get; set; }
        public virtual ICollection<PartyTableLog> PartyTableLogs { get; set; }
    }
}
