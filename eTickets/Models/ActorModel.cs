namespace eTickets.Models
{
    public class ActorModel
    {
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }


        //Navigation
        public ICollection<Actor_Movie> Actors_Movies { get; set; }

    }
}
