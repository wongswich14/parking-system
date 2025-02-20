using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Vehicle: BaseInfo, IAuditable
    {

       
        public string LicensePlate { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public int SlotId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? ChangeDate { get; set; }
        public Guid UserCreatedId { get; set; }
        public Guid? UserChangedId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
