namespace eTickets.Models
{
    public class ProducerModel
    {
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }


        //Navigations
        public ICollection<MovieModel> MoviesProduced { get; set; }
    }
}
