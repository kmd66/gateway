namespace Kama.ApiManagement.Core.Model;

public class ActivityLogSetting
{
    public bool Enabled { get; set; } 

    public string ActivityLogHost { get; set; }

    public int ExcludedActionCacheTimeout { get; set;}
}

