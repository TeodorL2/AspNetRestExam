using Examen.Repositories.FilmRepository;
using Examen.Repositories.ActorRepository;
using Examen.Services.ActorService;
using Examen.Services.FilmService;

namespace Examen.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IFilmRepository, FilmRepository>();
            services.AddTransient<IActorRepository, ActorRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IFilmService, FilmService>();
            services.AddTransient<IActorService, ActorService>();

            return services;
        }

    }
}
