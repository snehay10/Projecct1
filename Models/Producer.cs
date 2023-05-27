using System.ComponentModel.DataAnnotations;

namespace MVC2.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public String ProfilePictureURL { get; set; }
        public String FullName { get; set; }
        public int Bio { get; set; }

        //Realtionship
        public List<Movie> Movies { get; set;}
    }
}
