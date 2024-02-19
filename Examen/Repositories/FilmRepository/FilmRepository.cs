using Examen.Data;
using Examen.Data.DTOs;
using Examen.Data.Models;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.FilmRepository
{
    public class FilmRepository: GenericRepository<Film>, IFilmRepository
    {
        public FilmRepository(ExamenContext context) : base(context) { }
        public async Task<List<Film>> GetFilme()
        {
            return await GetAll();
        }

        public Film? FindByTitlu(string titlu)
        {
            return _table.FirstOrDefault(t => t.Titlu.Equals(titlu));
        }
    }
}
