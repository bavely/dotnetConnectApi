namespace ConnectApi.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Message> Messages { get; set; }
        public ICollection<User> Members { get; set;} = new List<User>();
        public int OwnerId { get; set; } 
        public string Category { get; set; }


        public Room()
        {
            Messages = new List<Message>();
            Members = new List<User>();
            Name = "Not specified";
            Category = "Not specified";

        }
    }
}