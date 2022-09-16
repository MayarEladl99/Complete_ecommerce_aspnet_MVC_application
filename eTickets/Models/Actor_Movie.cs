namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int MovieID { get; set; }
        public MovieModel Movie { get; set; }
        public int ActorID { get; set; }
        public ActorModel Actor { get; set; }

         

    }
}
