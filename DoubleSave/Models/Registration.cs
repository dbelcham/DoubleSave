using System.ComponentModel.DataAnnotations;

namespace DoubleSave.Models
{
    public class Registration
    {
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Credit Card Number")]
        public string CreditCardNumber { get; set; }
        [Display(Name = "Registration Confirmation #")]
        public string RegistrationConfirmation { get; set; }
        [Display(Name = "Payment Confirmation #")]
        public string PaymentConfirmation { get; set; }

        public bool HasPosted { get; set; }
    }
}