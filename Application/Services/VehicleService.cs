using Domain.Entities;
using Domain.Interfaces;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class VehicleService
    {
        private readonly IGenericRepository<Vehicle> _vehicleRepository;

        public VehicleService(IGenericRepository<Vehicle> vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<Vehicle> GetVehicleByLicensePlateAsync(string licensePlate)
        {
            var spec = new VehicleByLicensePlateSpecification(licensePlate);
            return (await _vehicleRepository.FindAsync(spec)).FirstOrDefault();
        }

        public async Task<IEnumerable<Vehicle>> GetParkedVehiclesAsync()
        {
            var spec = new ParkedVehiclesSpecification();
            return await _vehicleRepository.FindAsync(spec);
        }
    }
}
