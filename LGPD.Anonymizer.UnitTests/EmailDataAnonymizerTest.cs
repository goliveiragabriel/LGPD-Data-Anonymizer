using FluentAssertions;
using LGPD.Anonymizer.Email;
using LGPD.Anonymizer.Interfaces;
using Moq;
using Xunit;

namespace LGPD.Anonymizer.UnitTests
{
    public class EmailDataAnonymizerTest
    {
        [Fact]
        public void WhenIsValidEmail_ShouldAnonymizeEmailValue()
        {
            string email = @"teste@teste.com";
            string expectedValue = @"***";
            Moq.Mock<IEmailDataMasking> mock = new Mock<IEmailDataMasking>();
            mock.Setup(x => x.Mask(email)).Returns(expectedValue);
            EmailDataAnonymizer anonymizer = new EmailDataAnonymizer(mock.Object);

            var result = anonymizer.Anonymize(email);

            result.Should().Be(expectedValue);
        }
    }
}
