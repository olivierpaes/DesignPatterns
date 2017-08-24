namespace Rtp.Factory
{
    class SocialSecurityNumberValidationStrategyForFrance : ISocialSecurityNumberValidationStrategy
    {
        public bool IsValid(string socialSecurityNumber)
        {
            return socialSecurityNumber.Length == 3;
        }
    }
}