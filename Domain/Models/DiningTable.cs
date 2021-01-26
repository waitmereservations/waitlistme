using System;
using System.Collections.Generic;

#nullable disable

namespace Waitlistme.Domain.Models
{
    public partial class DiningTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TableStatusId { get; set; }
        public int? Capacity { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
