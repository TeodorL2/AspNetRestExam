namespace Examen.Data.Models
{
    public class FilmActor
    {
        public Guid IdFilm {  get; set; }
        
        public Guid IdActor { get; set; }

        public Film Film { get; set; }
        public Actor Actor { get; set; }
    }
}
