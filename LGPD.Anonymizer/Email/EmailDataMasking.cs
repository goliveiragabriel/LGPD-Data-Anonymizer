using LGPD.Anonymizer.Interfaces;

namespace LGPD.Anonymizer.Email
{
    public class EmailDataMasking : IEmailDataMasking
    {
        public string Mask(string value)
        {
            return "***";
        }
    }
}
