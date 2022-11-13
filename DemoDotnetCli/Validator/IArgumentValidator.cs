namespace DemoDotnetCli.Validator;

public interface IArgumentValidator
{
    bool Validate(string[] args);
}