using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using L01_2021_CE_650_2021_ML_601.Models;

namespace L01_2021_CE_650_2021_ML_601.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class motoristasController : ControllerBase
    {
        private readonly restauranteDBContext _restauranteDBContext;
        public motoristasController(restauranteDBContext restauranteDBContext)
        {
            _restauranteDBContext = restauranteDBContext;
        }
        /// <sumary>
        /// EndPoint que retorna el listado de todos los equipos existentes
        /// </sumary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<motoristas> listadoMotorista = (from e in _restauranteDBContext.motoristas
                                           select e).ToList();

            if (listadoMotorista.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoMotorista);
        }


    }
}
