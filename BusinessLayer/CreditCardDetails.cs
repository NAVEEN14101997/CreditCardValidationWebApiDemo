using System;

namespace BusinessLayer
{
   public class CreditCardDetails
    {
        public string CardNumber { get; set; }
        public string CVVNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
