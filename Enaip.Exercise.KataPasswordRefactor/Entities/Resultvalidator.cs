using System.Collections.Generic;
using System.Linq;

namespace Enaip.Exercise.KataPasswordRefactor.Entities
{
    public class ResultValidation
    {
        public bool IsValid => !ErrorDescription.Any();
        public List<string> ErrorDescription { get; set; }
        public ResultValidation() => ErrorDescription = new List<string>();
    }
}