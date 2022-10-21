
namespace MinhaApi.Configurations
{
    public class DatabaseConfiguration
    {
        public string DefaultConnectionString { get; set; }
        public string ConnectionString { get; set; }
        public Database Database { get; set; }

        public DatabaseConfiguration(IConfiguration configuration)
        {
            DefaultConnectionString = configuration["DefaultConnectionString"];
            ConnectionString = configuration[$"ConnectionString:{DefaultConnectionString}"];
            Database = (Database)Enum.Parse(typeof(Database), DefaultConnectionString);
        }
    }

    public enum Database
    {
        PostgreSql,
        Oracle,
        MySql
    }
}
