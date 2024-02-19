using Examen.Data.DTOs;
using Examen.Data.Models;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.FilmRepository
{
    public interface IFilmRepository: IGenericRepository<Film>
    {
        Task<List<Film>> GetFilme();

        Film? FindByTitlu(string titlu);
    }
}
