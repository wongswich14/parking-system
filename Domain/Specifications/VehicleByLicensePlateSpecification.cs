using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public class VehicleByLicensePlateSpecification : Specification<Vehicle>
    {
        private readonly string _licensePlate;

        public VehicleByLicensePlateSpecification(string licensePlate)
        {
            _licensePlate = licensePlate;
        }

        public override Expression<Func<Vehicle, bool>> ToExpression()
        {
            return vehicle => vehicle.LicensePlate == _licensePlate;
        }
    }
}
