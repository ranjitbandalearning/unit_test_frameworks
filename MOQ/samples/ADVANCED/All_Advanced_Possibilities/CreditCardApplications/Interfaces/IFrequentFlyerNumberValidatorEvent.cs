using System;

namespace CreditCardApplications
{

    public interface IFrequentFlyerNumberValidatorEvent
    {
        bool IsValid(string frequentFlyerNumber);
        void IsValid(string frequentFlyerNumber, out bool isValid);
        IServiceInformation ServiceInformation { get; }
        ValidationMode ValidationMode { get; set; }

        event EventHandler ValidatorLookupPerformed;
    }
}