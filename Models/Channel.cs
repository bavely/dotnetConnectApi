namespace ConnectApi.Models
{
    public class Channel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  int OwnerId { get; set; }
        public IList<Message> Messages { get; set; }
        public ICollection<User> Members { get; set; } = new List<User>();


        public Channel()
        {
            Name = "Not specified";

            Messages = new List<Message>();
            Members = new List<User>();

        }
    }
}