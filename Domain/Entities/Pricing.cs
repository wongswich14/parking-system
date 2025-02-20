using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pricing
    {
        public int Id { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal DailyRate { get; set; }
    }
}
