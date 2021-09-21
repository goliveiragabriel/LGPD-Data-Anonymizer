namespace LGPD.Anonymizer
{
    public interface IDataAnonymizer
    {
        object Anonymize(string value);
    }

    public abstract class DataAnonymizerBase : IDataAnonymizer
    {
        public abstract object Anonymize(string value);
    }
}
