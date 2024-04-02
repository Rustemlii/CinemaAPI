using Business.Abstract;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly IMovie _movie;

        public CinemaController(IMovie movie)
        {
            _movie = movie;
        }

        [HttpGet]
        public IActionResult CinemaList()
        {
            var values=_movie.GetAll();
            return Ok(values);
        }
        [HttpGet("Id")]
        public IActionResult CinemaByID(int id)
        {
            var values=_movie.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CinemaAdd(MovieDTO m)
        {
            string answer = "Succes Add";          
            _movie.Insert(m);
            return Ok(answer);
        }

        [HttpPut]
        public IActionResult MovieUpdate(MovieDTO m)
        {
            string answer = "Succes Updated";         
            _movie.Update(m);
            return Ok(answer);
        }

        [HttpDelete]
        public IActionResult MovieDelete(int id)
        {
            string answer = "Deleted Data";
            _movie.Delete(id);
            return Ok(answer);
        }
    }
}
