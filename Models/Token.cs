namespace ConnectApi.Models
{
    public class Token
    {
        public int Id { get; set; }
        public required byte[] TokenHash { get; set; }
        public int UserId { get; set; }
        public DateTime ExpiryDate { get; set; }
        public required string Type { get; set; }
        public bool BlackListed { get; set; }
    }
}