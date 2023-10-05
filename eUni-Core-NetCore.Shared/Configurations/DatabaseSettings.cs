namespace eUni_Core_NetCore.Shared.Configurations;

public class DatabaseSettings
{
    public string DbProvider { get; set; } = null!;
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
}
