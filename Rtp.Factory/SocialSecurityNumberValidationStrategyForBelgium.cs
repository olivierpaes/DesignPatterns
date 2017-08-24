namespace Rtp.Factory
{
    class SocialSecurityNumberValidationStrategyForBelgium : ISocialSecurityNumberValidationStrategy
    {
        public bool IsValid(string socialSecurityNumber)
        {
            return socialSecurityNumber.Length == 4 ;
        }
    }
}