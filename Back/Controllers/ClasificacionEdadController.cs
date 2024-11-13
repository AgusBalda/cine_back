﻿using Back.Data.Service.Interfaces;
using Back.Data.Service.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClasificacionEdadController : ControllerBase
    {
        private readonly IClasificacionEdadService _service;

        public ClasificacionEdadController(IClasificacionEdadService service)
        {
            _service = service;
        }

        // GET: api/<ClasificacionEdadController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _service.TraerClasificacionEdad());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }



    }
}