using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MoviesEtickets.Controllers.Data.Enums;

namespace MoviesEtickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime Released { get; set; }
        public MovieCategory Category { get; set; }


        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }


        public int CinemaId { get; set; }
        public int ProducerId { get; set; }


        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
