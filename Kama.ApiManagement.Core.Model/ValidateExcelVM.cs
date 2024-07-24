namespace Kama.ApiManagement.Core.Model;

using System.Linq;

public class ValidateExcelVM<T1, T2>
    where T1 : class, new()
    where T2 : Enum
{
    public ValidateExcelVM()
    {
        Errors = new List<ValidateExcelErrorVM<T2>>();
        List = new List<T1>();
    }

    public List<ValidateExcelErrorVM<T2>> Errors { get; set; }

    public Dictionary<string, int> HeaderColumns { get; set; }

    public List<T1> List { get; set; }

    public bool Success => Errors.Count() == 0;

    public void AddError(T2 error, ExcelCellVM cell , string FieldValue)
    {
        try
        {
            var theError = Errors.FirstOrDefault(e => e.Error.ToString() == error.ToString());

            if (theError == null)
            {
                theError = new ValidateExcelErrorVM<T2> { Error = error , Fieldvalue = FieldValue };
                theError.Cells.Add(cell);
                Errors.Add(theError);
            }
            else
                theError.Cells.Add(cell);
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}

public class ValidateExcelErrorVM<T>
    where T : Enum
{
    public ValidateExcelErrorVM()
    {
        Cells = new List<ExcelCellVM>();
    }
    public T Error { get; set; }

    public string Fieldvalue { get; set; }

    public List<ExcelCellVM> Cells { get; set; }
}

public class ExcelCellVM
{
    public int? Row { get; set; }

    public int? Column { get; set; }

}

public class ExployeeExcelProcessErrors
{
    public string NationalCode { get; set; }
    
    public string Messages { get; set; }
}
