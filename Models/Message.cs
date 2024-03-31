namespace ConnectApi.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int SenderId { get; set; }
        public User User { get; set; }
        public Channel Channel { get; set; }
        public int ChannelId { get; set; }
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public Message()
        {
            Body = "Not specified";
            User ??= new User();
            Channel ??= new Channel();
            Room ??= new Room();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;

        }
    }
}