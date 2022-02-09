namespace Enaip.Exercise.KataPasswordRefactor.Entities
{
    public class Check
    {
        public string Expression { get; }
        public string ErrorMessage { get; }
        public Check(string expression, string errorMessage)
        {
            Expression = expression;
            ErrorMessage = errorMessage;
        }        
    }
}
