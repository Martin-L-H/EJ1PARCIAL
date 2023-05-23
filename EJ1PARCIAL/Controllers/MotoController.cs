using EJ1PARCIAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EJ1PARCIAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoController : ControllerBase
    {
        private List<Moto> Motos = new List<Moto>();
        public MotoController()
        {
            Motos.Add(new Moto() { Id = 0, Marca = "John", Modelo = "Doe" });
            Motos.Add(new Moto() { Id = 1, Marca = "Yamaha", Modelo = "ZR-1" });
            Motos.Add(new Moto() { Id = 2, Marca = "Kawasaki", Modelo = "Ninja" });
            Motos.Add(new Moto() { Id = 3, Marca = "Suzuki", Modelo = "Hayabusa" });
            Motos.Add(new Moto() { Id = 4, Marca = "Honda", Modelo = "GoldWing" });
        }

        [HttpGet]
        //[Produces("application/xml")]
        public List<Moto> GetAll()        {
            return Motos;
        }
        [HttpGet("{id}")]
        //[Produces("application/xml")]
        public ActionResult<Moto> GetOne(int id)
        {
            var unica = Motos.FirstOrDefault(x => x.Id == id);
            if (unica == null)
            {
                return NotFound();
            }
            else
            {
                return unica;
            }
        }
    }
}
