using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Validators
{
    public static class ValidateREGON
    {
        public static string Validate(decimal? regon)
        {
            if (!regon.HasValue)
            {
                return "Numer REGON jest wymagany.";
            }

            string regonString = regon.Value.ToString("F0");

            if (regonString.Length != 9 && regonString.Length != 14)
            {
                return "Numer REGON musi zawierać 9 lub 14 cyfr.";
            }

            if (!regonString.All(char.IsDigit))
            {
                return "Numer REGON może zawierać tylko cyfry.";
            }

            return string.Empty;
        }
    }

}