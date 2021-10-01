using Bussiness.Abstract;
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
    public class BinaController : ControllerBase
    {
        IBinaService _binaService;
        public BinaController(IBinaService binaService)
        {
            _binaService = binaService;
        }
        Bina bina { get; set; }
        
        [HttpGet("getall")]
        public IActionResult GetAll()


        {

            var result = _binaService.GetAll();
            if (result.Success)
            {
                
                return Ok(result.Data);

            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _binaService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Bina bina)
        {
            var result =  _binaService.Add(bina);
            if (result.Success)
            {
                 return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(int id)  
        {
            bina = _binaService.GetById(id).Data;
            var result = _binaService.Delete(bina);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("bina")]
        public IActionResult Update(Bina bina)
        {
            var result = _binaService.Update(bina);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
