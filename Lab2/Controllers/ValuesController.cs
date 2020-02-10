using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IGaseosaSettings _agua;
        public ValuesController(IGaseosaSettings moviesettings)
        {
            _agua = moviesettings;
        }
        //localhost:51626/api/Values/GetWithParam/?nombre=""
        [HttpGet("GetWithParam", Name = "Get")]
        public ActionResult<object> Get(string nombre)
        {
            object tempo = _agua.GetOne(nombre);
            return tempo;
        }

        [HttpPost]
        public ActionResult<Gaseosa> Create(Gaseosa movie)
        {
            _agua.Create(movie);
            return movie;
        }
    }
}
