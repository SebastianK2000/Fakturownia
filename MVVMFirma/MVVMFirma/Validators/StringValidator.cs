using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Validators
{
    public static class StringValidator
    {
        public static string ValidateIsFirstLetterUpper(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "Pole nie może być puste";
            }

            return char.IsUpper(text, 0) ? string.Empty : "Pierwsza litera musi być duża";
        }
    }
}
