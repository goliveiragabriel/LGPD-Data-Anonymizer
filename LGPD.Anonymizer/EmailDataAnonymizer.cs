namespace LGPD.Anonymizer
{
    public class EmailDataAnonymizer : DataAnonymizerBase
    {
        public override object Anonymize(string value)
        {
            return "***";
        }
    }
}
