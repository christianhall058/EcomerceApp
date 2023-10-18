﻿using System.ComponentModel.DataAnnotations;

namespace EcomerceApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
