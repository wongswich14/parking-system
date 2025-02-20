using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ParkingSlotService
    {
        private readonly IGenericRepository<ParkingSlot> _repository;

        public ParkingSlotService(IGenericRepository<ParkingSlot> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ParkingSlot>> GetAllSlotsAsync() => await _repository.GetAllAsync();
    }
}
