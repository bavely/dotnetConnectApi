namespace ConnectApi.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string ProfilePic { get; set; }
        public string Address1  { get; set; }
        public string Address2  { get; set; }
        public string City      { get; set; }
        public string State     { get; set; }
        public string Country   { get; set; }
        public string ZipCode   { get; set; }
        public DateTime DOB      { get; set; }
        public string Gender    { get; set; }
        public string About     { get; set; }
        public string[] PicsUrls { get; set; }
        public string[] Interests  { get; set; }
        public bool IsOnline    { get; set; }
        public DateTime LastSeen { get; set; }
        public bool IsPublic    { get; set; }   
        public int UserId { get; set; }
        public User User { get; set; }   

        public Profile()
        {
            DOB = DateTime.Now;
            LastSeen = DateTime.Now;
            PicsUrls = [];
            Interests = [];
            IsOnline = false;
            IsPublic = true;
            Gender = "Not specified";
            User = new User();
            About = "Not specified";
            ProfilePic ??= "";
            Address1 ??= "";
            Address2 ??= "";
            City ??= "";
            State ??= "";
            Country ??= "";
            ZipCode ??= "";

        }
     
    }
}