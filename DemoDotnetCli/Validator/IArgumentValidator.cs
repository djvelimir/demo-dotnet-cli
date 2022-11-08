namespace DemoDotnetCli.Validator;

public interface IArgumentValidator
{
    bool Validate(String[] args);
}