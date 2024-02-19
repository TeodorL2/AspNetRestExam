using Examen.Data.DTOs;
using Examen.Data.Models;
using Examen.Repositories.FilmRepository;

namespace Examen.Services.FilmService
{
    public class FilmService: IFilmService
    {
        private readonly IFilmRepository _filmRepository;

        public FilmService(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public async Task<List<FilmDto>> GetFilme()
        {
            List<FilmDto> rez = new List<FilmDto>();

            List<Film> aux = await _filmRepository.GetFilme();

            if (aux != null)
            {
                foreach (var film in aux)
                {
                    rez.Add(new FilmDto
                    {
                        Titlu = film.Titlu,
                        NumeRegizor = film.NumeRegizor,
                    });
                }
            }

            return rez;
        }
    }
}
