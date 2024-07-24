namespace Kama.ApiManagement.Core.Model;

public enum SortOrderType : byte
{
    ASC = 0,
    DESC = 1
}

public class SortExp
{
    public string ColumnName { get; set; }

    public SortOrderType SortOrder { get; set; }
}
