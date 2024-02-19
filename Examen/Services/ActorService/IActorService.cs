using Examen.Data.DTOs;

namespace Examen.Services.ActorService
{
    public interface IActorService
    {
        Task<List<ActorDto>> GetActori();

        bool AssignFilm(AssignFilmRequestDto request);

        Task<List<dynamic>> GetActoriGrupatiDupaFilme();
    }
}
