using Examen.Data.Models.Base;

namespace Examen.Data.Models
{
    public class Film: BaseEntity
    {
        public string Titlu { get; set; }

        public string NumeRegizor { get; set; }

        public ICollection<FilmActor> FilmActori { get; set; }
    }
}
