
using ConnectApi.Models;
using Microsoft.EntityFrameworkCore;
namespace ConnectApi.Data;

class EntityFW : DbContext
{


    public DbSet<User> Users { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Token> Tokens { get; set; }
    public DbSet<Channel> Channels { get; set; }
    public DbSet<Message> Messages { get; set; }

    private readonly IConfiguration _config;
    private readonly string? _connectionString;

    public EntityFW()
    {
        _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        this._connectionString = _config.GetConnectionString("DefaultConnection");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(this._connectionString,
            options => options.EnableRetryOnFailure()
            );
        }

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("ConnectDB");
        


    }
}

