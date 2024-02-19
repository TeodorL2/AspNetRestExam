using Examen.Data.Models.Base;

namespace Examen.Data.Models
{
    public class Actor: BaseEntity
    {
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public ICollection<FilmActor> FilmActori { get; set; }
    }
}
