namespace Rtp.Factory
{
    public abstract partial class Person
    {
        /// <summary>
        /// This class is protected and an inner class so it is not possible to use the constructor from putside
        /// </summary>
        protected class Frenchman: Person
        {
            
            /// <summary>
            /// Constructor is protected internal to make sure that it is useable by the Person class. 
            /// Only nternal should also do but only protected won't do the trick.
            /// </summary>
            protected internal Frenchman() 
                : base(new SocialSecurityNumberValidationStrategyForFrance())
            {
                Language = "French";
            }
        }
    }
    
}