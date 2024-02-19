using Examen.Data.DTOs;
using Examen.Services.FilmService;
using Examen.Services.ActorService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamenController : ControllerBase
    {
        private readonly IFilmService _filmService;
        private readonly IActorService _actorService;

        public ExamenController(IFilmService filmService, IActorService actorService)
        {
            _filmService = filmService;
            _actorService = actorService;
        }

        [HttpGet("actori")]
        public async Task<IActionResult> GetAllActori()
        {
            var resp = await _actorService.GetActori();

            if (resp == null)
            {
                return BadRequest("no elements found");
            }
            return Ok(resp);
        }

        [HttpGet("filme")]
        public async Task<IActionResult> GetAllFilme()
        {
            var resp = await _filmService.GetFilme();

            if (resp == null)
            {
                return BadRequest("no elements found");
            }
            return Ok(resp);
        }

        
        [HttpPost("assignFilm")]
        public IActionResult AssignMaterii([FromBody] AssignFilmRequestDto req)
        {
            var resp = _actorService.AssignFilm(req);
            if(!resp)
                return BadRequest("date invalide");

            return Ok(resp);
        }

        [HttpGet("actoriDupaFilme")]
        public IActionResult ActoriDupaFilme()
        {
            var resp = _actorService.GetActoriGrupatiDupaFilme();

            if (resp == null)
                return Ok("ne exista filme in baza de date");

            return Ok(resp);
        }
    }
}
