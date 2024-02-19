using Examen.Data.DTOs;
using Examen.Data.Models;
using Examen.Repositories.ActorRepository;
using Examen.Repositories.FilmRepository;

namespace Examen.Services.ActorService
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        private readonly IFilmRepository _filmRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public async Task<List<ActorDto>> GetActori()
        {
            List<ActorDto> rez = new List<ActorDto>();

            List<Actor> aux = await _actorRepository.GetActori();

            if (aux != null)
            {
                foreach (var act in aux)
                {
                    rez.Add(new ActorDto
                    {
                        Nume = act.Nume,
                        Prenume = act.Prenume
                    });
                }
            }

            return rez;
        }

        public bool AssignFilm(AssignFilmRequestDto req)
        {
            Actor? actor = _actorRepository.FindByNumePrenume(req.NumeActor, req.PrenumeActor);
            if (actor == null)
                return false;

            Film? film = _filmRepository.FindByTitlu(req.TitluFilm);
            if (film == null)
                return false;

            _actorRepository.AssignFilm(actor.Id, film.Id);
            var rez = _actorRepository.Save();
            return rez;
        }

        public Task<List<dynamic>> GetActoriGrupatiDupaFilme()
        {
            var rez = _actorRepository.GetActoriGrupatiDupaFilme();

            return rez;

        }
    }
}
