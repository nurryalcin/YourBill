using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdisyonsController : ControllerBase
    {
        IAdisyonService _adisyonService;
        


        public AdisyonsController(IAdisyonService adisyonService)
        {
           this. _adisyonService = adisyonService;
          
            
        }
        //productservice'e bağımlı
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _adisyonService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Adisyon adisyon)
        {
            var result = _adisyonService.Add(adisyon);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
       
      


    }
    
}
