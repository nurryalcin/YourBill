using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AdisyonDetailDto : IDto
    {
        public int AdisyonId { get; set; }
        public string CompanyName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
    }
}
