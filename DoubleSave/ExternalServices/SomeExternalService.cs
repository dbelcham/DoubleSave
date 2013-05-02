using System;

namespace DoubleSave.ExternalServices
{
    public class SomeExternalService
    {
        public ServiceConfirmation Save(string name, string creditCardNumber)
        {
            return new ServiceConfirmation
                {
                    PaymentConfirmation = Guid.NewGuid().ToString(),
                    RegistrationConfirmation = Guid.NewGuid().ToString()
                };
        }
    }
}