namespace Rtp.Factory
{
    public class Belgian : Person
    {
        protected internal Belgian()
            : base(new SocialSecurityNumberValidationStrategyForBelgium())
        {
            
        }

       
    }
}