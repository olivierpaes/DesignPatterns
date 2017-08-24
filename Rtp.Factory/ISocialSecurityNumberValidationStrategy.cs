namespace Rtp.Factory
{
    public interface ISocialSecurityNumberValidationStrategy
    {
        bool IsValid(string socialSecurityNumber);
    }
}