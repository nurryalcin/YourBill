using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Entities.Concrete
{
    public class Company:IEntity
    {
        public int CompanyId { get; set; }
        public int CompanyCityId { get; set; }
        public int CompanyDistrictId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string? CompanyPhone { get; set; }

    }
}
