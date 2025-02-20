using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public class ParkedVehiclesSpecification : Specification<Vehicle>
    {
        public override Expression<Func<Vehicle, bool>> ToExpression()
        {
            return vehicle => vehicle.ExitTime == null;
        }
    }
}
