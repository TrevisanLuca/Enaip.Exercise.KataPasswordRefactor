using Enaip.Exercise.KataPasswordRefactor.Entities.Validators;
using System.Collections.Generic;

namespace Enaip.Exercise.KataPasswordRefactor.Entities
{
    public class CheckerPassword
    {
        private IValidator validator;
        public List<Check> checkList;
        public CheckerPassword()
        {            
            validator = new Validator(PopulateCheckList(), new ResultValidation());
        }
        public ResultValidation Validate(string input) => validator.Validate(input);

        //Simula il caricare i parametri da DB/File
        static List<Check> PopulateCheckList()
        {
            List<Check> result = new List<Check>();

            result.Add(new Check(@".{8,}", "Password must be at least 8 characters"))                ;
            result.Add(new Check(@"(.*\d){2}", "The password must contain at least 2 numbers"));
            result.Add(new Check(@"[A-Z]", "password must contain at least one capital letter"));
            result.Add(new Check(@"(.*[\W]){1,}", "password must contain at least one special character"));

            return result;
        }
    }
}