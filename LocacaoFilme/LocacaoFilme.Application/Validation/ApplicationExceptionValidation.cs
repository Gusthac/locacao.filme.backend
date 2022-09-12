using System;

namespace LocacaoFilme.Application.Validation
{
    public class ApplicationExceptionValidation : Exception
    {
        public ApplicationExceptionValidation(string error) : base(error)
        { }

        public static void When(bool hasError, string error)
        {
            if (hasError)
                throw new ApplicationExceptionValidation(error);
        }
    }
}