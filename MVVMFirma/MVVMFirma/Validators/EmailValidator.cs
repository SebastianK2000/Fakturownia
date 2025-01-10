using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Validators
{
    public static class EmailValidator
    {
        public static string ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return "Adres e-mail jest wymagany.";
            }

            if (!email.Contains('@'))
            {
                return "Adres e-mail musi zawierać znak '@'.";
            }

            return string.Empty;
        }
    }
}