using System.ComponentModel.DataAnnotations;

namespace MVC2.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public String ProfilePictureURL { get; set; }
        public String FullName { get; set; }
        public int Bio { get; set; }

        //Relationship

        public List <Actor_Movie> Actors_Movies { get; set; }
    }
}
