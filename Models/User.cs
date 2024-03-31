namespace ConnectApi.Models
{
    public class User
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public byte[] Password { get; set; }
        public string Type { get; set; }
        public string RegisterSource { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsPhoneVerified { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Profile Profile { get; set; }
        public ICollection<Channel> Channels { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Message> Messages { get; set; }

        public User()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;

            Type ??= "User";

            RegisterSource ??= "Email";

            Password ??= new byte[] { };

            LastName ??= "";

            FirstName ??= "";

            Email ??= "";

            Phone = 0;

            UserName ??= "";

            Profile = new Profile();

            Channels = [];

            Rooms = [];

            Messages = [];

        }

    }
}