using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Enaip.Exercise.KataPasswordRefactor.Entities.Validators
{
    public class Validator : IValidator
    {
        protected List<Check> _checkList;
        protected ResultValidation _resultValidation;
        public Validator(List<Check> checkList, ResultValidation resultValidation)
        {
            _checkList = checkList;
            _resultValidation = resultValidation;
        }

        public ResultValidation Validate(string input)
        {
            foreach (Check item in _checkList)
            {
                if (!Regex.IsMatch(input, item.Expression))
                    _resultValidation.ErrorDescription.Add(item.ErrorMessage);
            }
            return _resultValidation;
        }
    }
}