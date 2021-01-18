using System;
using System.Collections.Generic;

#nullable disable

namespace Waitlistme.Domain.Models
{
    public partial class PartyType
    {
        public PartyType()
        {
            Parties = new HashSet<Party>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Party> Parties { get; set; }
    }
}
