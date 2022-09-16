using eTickets.Data.Enum;

namespace eTickets.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }


        public MovieCategory MovieCategory { get; set; }

        //Navigation
        public int cinemaId { get; set; }
        public CInemaModels cinema { get; set; }

        public int producerId { get; set; }
        public ProducerModel ProducerModel { get; set; }

        public ICollection<Actor_Movie> Actors_Movies { get; set; }


    }
}
