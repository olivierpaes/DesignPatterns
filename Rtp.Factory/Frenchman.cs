namespace Rtp.Factory
{
    public  abstract partial class Person
    {
        protected class Frenchman: Person
        {
            protected internal Frenchman() 
                : base(new SocialSecurityNumberValidationStrategyForFrance())
            {
                Language = "French";
            }
        }
    }
    
}