using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BillImage:IEntity
    {
        public int BillImageId { get; set; }
        public int AdisyonId { get; set; }
        public string? ImagePath { get; set; }
        public DateTime? Date { get; set; }

    }
}
