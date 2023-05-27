using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace MVC2.Models
{
    public class Cinema
    {
        [Key]
        public  int Id { get; set; }
        public String Logo { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
