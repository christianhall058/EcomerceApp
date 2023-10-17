using System.ComponentModel.DataAnnotations;

namespace EcomerceApp.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public int ProfilePictureURL { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
