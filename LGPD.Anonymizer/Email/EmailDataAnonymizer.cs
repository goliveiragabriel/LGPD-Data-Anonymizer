using LGPD.Anonymizer.Interfaces;

namespace LGPD.Anonymizer.Email
{
    public class EmailDataAnonymizer : DataAnonymizerBase
    {
        private readonly IEmailDataMasking _emailDataMasking;

        public EmailDataAnonymizer(IEmailDataMasking emailDataMasking)
        {
            _emailDataMasking = emailDataMasking;
        }

        public override object Anonymize(string value)
        {
            return _emailDataMasking.Mask(value);
        }
    }
}
