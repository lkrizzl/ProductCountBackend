namespace Domain.Core.PrimitiveTypes.Result;

public class Result
{
    protected Result(bool isSuccess, params Error[] errors)
    {

        if(isSuccess && errors.Length != 0)
        { 
            throw new InvalidOperationException(); 
        }

        if(!isSuccess && errors.Length == 0)
        { 
            throw new InvalidOperationException(); 
        }

        IsSuccess = isSuccess;
        Errors = errors;
    }

    public Error[] Errors { get; protected set; }

    public bool IsSuccess { get; protected set; }

    public bool IsFailure { get => !IsSuccess; }

    public static Result Success() => new Result(true, []);

    public static Result<TValue> Success<TValue>(TValue value) => new(value, true, []);

    public static Result Failure(params Error[] errors) => new Result(false, errors);

    public static Result<TValue> Failure<TValue>(params Error[] errors) => new(default!, false, errors);

    public static Result Concat(params Result[] results)
    {
        var failure = results.Where(x => x.IsFailure).Select(e => e.Errors);

        if(failure.Count() == 0)
        {
            return Success();
        }

        return Failure([.. failure.SelectMany(e => e)]);

    }

    public Dictionary<string, string[]> ToDictionary()
    {
        if (IsSuccess)
        {
            throw new InvalidOperationException();
        }

        Dictionary<string, string[]> dict = new Dictionary<string, string[]>();

        foreach (var error in Errors)
        {
            dict.Add(error.Code, [error.Massage]);
        }

        return dict;

    }
    


}
