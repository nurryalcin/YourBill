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
    public class BillImagesController : ControllerBase
    {
        private IFileProcess fileProcess;
        private IBillImageService billImageService;

        public BillImagesController(IFileProcess fileProcess, IBillImageService carImageService)
        {
            this.fileProcess = fileProcess;
            this.billImageService = billImageService;
        }

        [HttpPost]
        [Route("add/{id}")]
        public IActionResult UploadImage([FromForm] IFormFile files, int id)
        {
            var result = billImageService.Add(id, files);
            if (result.Success)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteCarImage(int id, string path)
        {
            var result = billImageService.Delete(id);
            if (result == null)
                return Ok(result);
            return BadRequest(result.Message);
        }
    }
}
