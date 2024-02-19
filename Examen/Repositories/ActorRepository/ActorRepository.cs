using Examen.Data;
using Examen.Data.Models;
using Examen.Repositories.FilmRepository;
using Examen.Repositories.GenericRepository;
using System.ComponentModel.Design;

namespace Examen.Repositories.ActorRepository
{
    public class ActorRepository: GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(ExamenContext context) : base(context) { }

        public async Task<List<Actor>> GetActori()
        {
            return await GetAll();
        }

        public bool AssignFilm(Guid actorId, Guid filmId)
        {
            _examenContext.FilmActori.Add(new FilmActor
            {
                IdFilm = filmId,
                IdActor = actorId
            });

            return true;
        }

        public Actor? FindByNumePrenume(string nume, string prenume)
        {
                return _table.FirstOrDefault(t => t.Nume.Equals(nume) && t.Prenume.Equals(prenume));
        }

        public dynamic GetActoriGrupatiDupaFilme()
        {
            var rez = _examenContext.Filme.Join(_examenContext.FilmActori, f => f.Id, fa => fa.IdFilm,
                (f, fa) => new { f, fa }).Join(_examenContext.Actori, u => u.fa.IdActor, a => a.Id,
                (u, a) => new { u.f, u.fa, a }).GroupBy(t => t.f.Id).ToList();

            return rez;
        }
    }
}
