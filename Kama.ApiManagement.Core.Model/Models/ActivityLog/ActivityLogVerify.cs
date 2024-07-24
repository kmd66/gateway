namespace Kama.ApiManagement.Core.Model;

public class ActivityLogVerify
{
    public ActivityLogVerifyResult VerifyResult { get; set; }
}

public enum ActivityLogVerifyResult : byte
{
    Ok = 1,
    Excluded = 2,
    ActionBlocked = 3,
    UserBlocked = 4
}