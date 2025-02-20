using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ParkingSlotDto
    {
        public int SlotNumber { get; set; }
        public bool IsOccupied { get; set; }
        public string Type { get; set; }
    }
}
