namespace Enaip.Exercise.KataPasswordRefactor.Entities.Validators
{
    public interface IValidator
    {
        ResultValidation Validate(string input);
    }
}