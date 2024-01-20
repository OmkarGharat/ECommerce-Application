﻿using System.ComponentModel.DataAnnotations;

namespace ECommerce_Application.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        // Relationship
        public List<Actor_Movie> Actors_Movies { get; set; } = new List<Actor_Movie>();
    }
}
