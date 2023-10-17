using System.ComponentModel.DataAnnotations;

namespace EcomerceApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public int ProfilePictureURL { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }
    }
}
