using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IAuditable
    {
        DateTime CreateDate { get; set; }
        DateTime? ChangeDate { get; set; }
        Guid UserCreatedId { get; set; }
        Guid? UserChangedId { get; set; }
        bool IsDeleted { get; set; }
    }
}
