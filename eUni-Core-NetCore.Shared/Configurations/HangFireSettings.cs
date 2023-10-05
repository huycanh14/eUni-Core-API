namespace eUni_Core_NetCore.Shared.Configurations;

public class HangFireSettings
{
    public string Route { get; set; } = null!;

    public string ServerName { get; set; } = null!;

    public DatabaseSettings Storage { get; set; } = default!;

    public Dashboard Dashboard { get; set; } = default!;
}
public class Dashboard
{
    public string AppPath { get; set; } = null!;
    public int StatsPollingInterval { get; set; }
    public string DashboardTitle { get; set; } = null!;
}