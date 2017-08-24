namespace Rtp.Factory
{
    public abstract partial class Person
    {
        public string Firstname { get; protected set; }
        public string Lastname { get; protected set; }
        public string Language { get; protected set; }

        public string Ssnr
        {
            get { return _ssnr; }
            set
            {
                if (_ssnrValidation.IsValid(value))
                {
                    _ssnr = value;
                }
            }
        }

        
        private readonly ISocialSecurityNumberValidationStrategy _ssnrValidation;
        private string _ssnr;

        protected Person(ISocialSecurityNumberValidationStrategy ssnrValidation)
        {
            _ssnrValidation = ssnrValidation;
        }

        public static Person ForFrance(string ssnr, string firstname, string lastname)
        {
            var result = new Frenchman();
            result.Ssnr = ssnr;
            result.Firstname = firstname;
            result.Lastname = lastname;

            return result;



        }

        public static Person ForBelgium(string ssnr, string firstname, string lastname, string language)
        {
            var result = new Belgian();
            result.Ssnr = ssnr;
            result.Firstname = firstname;
            result.Lastname = lastname;
            result.Language = language;
            return result;
        }
        
    }
}