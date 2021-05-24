using BusinessLayer.Interface;
using System.Linq;

namespace BusinessLayer.Implementation
{
    public class ValidateCardDetails : IValidateCardDetails
    {
        public bool Validate(CreditCardDetails creditCardDetails)
        {
            bool isValidationsucceeded = false;

            if (creditCardDetails != null)
            {
                if (creditCardDetails.CardNumber.Count() == 16 && creditCardDetails.CVVNumber.Count() == 4 && creditCardDetails.ExpiryDate > System.DateTime.Now)
                {
                    isValidationsucceeded = true;
                }
            }
           return  isValidationsucceeded;
        }
    }
}
