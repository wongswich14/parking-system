using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ParkingSlot: BaseInfo, IAuditable
    {
        public int Id { get; set; }
        public int SlotNumber { get; set; }
        public bool IsOccupied { get; set; }
        public ParkingSlotType Type { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? ChangeDate { get; set; }
        public Guid UserCreatedId { get; set; }
        public Guid? UserChangedId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
