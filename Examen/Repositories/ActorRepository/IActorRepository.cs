using Examen.Data.Models;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.ActorRepository
{
    public interface IActorRepository: IGenericRepository<Actor>
    {
        Task<List<Actor>> GetActori();

        bool AssignFilm(Guid actorId, Guid filmId);

        Actor? FindByNumePrenume(string nume, string prenume);

        dynamic GetActoriGrupatiDupaFilme();
    }
}
