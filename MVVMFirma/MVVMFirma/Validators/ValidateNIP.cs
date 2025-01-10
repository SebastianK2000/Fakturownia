using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Validators
{
    public static class NIPValidator
    {
        public static string ValidateNIP(decimal? nip)
        {
            if (!nip.HasValue)
            {
                return "Numer NIP jest wymagany.";
            }

            string nipString = nip.Value.ToString("F0");

            if (nipString.Length != 10)
            {
                return "Numer NIP musi zawierać dokładnie 10 cyfr.";
            }

            if (!nipString.All(char.IsDigit))
            {
                return "Numer NIP może zawierać tylko cyfry.";
            }

            return string.Empty;
        }
    }
}