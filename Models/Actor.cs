using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_Application.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [DisplayName("Actor Name")]
        [Required(ErrorMessage = "Actor Name is required")]
        public string Name { get; set; }
        [DisplayName("About Actor")]
        [Required(ErrorMessage = "About info is required")]
        public string Bio { get; set; }

        // Relationship
        public List<Actor_Movie> Actors_Movies { get; set; } = new List<Actor_Movie>();
    }
}
