using System;
using System.Collections.Generic;

#nullable disable

namespace Waitlistme.Domain.Models
{
    public partial class PartyDiningTable
    {
        public int Id { get; set; }
        public int PartyId { get; set; }
        public int DiningTableId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
