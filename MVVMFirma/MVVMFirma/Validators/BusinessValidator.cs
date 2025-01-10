using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Validators
{
    public static class BusinessValidator
    {
        public static string ValidateIsPositive(decimal? price)
        {
            if(!price.HasValue)
            {
                return "To pole jest wymagane.";
            }

            if (price < 0)
            {
                return "Cena musi być większa niż 0.";
            }
            return string.Empty;
        }
    }
}
