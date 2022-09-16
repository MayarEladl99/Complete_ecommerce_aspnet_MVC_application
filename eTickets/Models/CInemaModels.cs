namespace eTickets.Models
{
    public class CInemaModels
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        //Navigation

        public ICollection<MovieModel> CinemaMovies { get; set; }
    }
}
