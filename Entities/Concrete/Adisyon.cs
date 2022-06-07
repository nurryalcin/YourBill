using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Entities.Concrete
{
    public class Adisyon : IEntity
    {
        public int AdisyonId { get; set; }
        public int? CompanyId { get; set; }
        public int BillImageId { get; set; }
        public DateTime? Date { get; set; }
        public string ImagePath { get; set; }
        public Company Company { get; set; }

    }
}
