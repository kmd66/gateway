namespace Kama.ApiManagement.Core.Model;

public abstract class ListVM
{
    public int PageSize { get; set; }

    public int PageIndex { get; set; }

    public List<SortExp> SortExp { get; set; }

    public bool GetTotalCount { get; set; }
}