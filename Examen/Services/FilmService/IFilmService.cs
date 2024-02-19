using Examen.Data.DTOs;

namespace Examen.Services.FilmService
{
    public interface IFilmService
    {
        Task<List<FilmDto>> GetFilme();
    }
}
