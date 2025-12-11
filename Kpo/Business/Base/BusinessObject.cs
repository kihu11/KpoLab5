namespace Kpo.Business.Base;

public abstract class BusinessObject
{
    private readonly List<string> _errors = new List<string>();

    protected void ValidateLength(string value, int min, int max, string fieldName)
    {
        if (value == null || value.Length < min || value.Length > max)
            _errors.Add($"{fieldName} length must be between {min} and {max} characters.");
    }

    protected void ValidateRange(double value, double min, double max, string fieldName)
    {
        if (value < min || value > max)
            _errors.Add($"{fieldName} must be in range {min} to {max}.");
    }

    public IReadOnlyList<string> GetErrors() => _errors.AsReadOnly();

    public bool IsValid => !_errors.Any();

    public abstract void Validate();
}