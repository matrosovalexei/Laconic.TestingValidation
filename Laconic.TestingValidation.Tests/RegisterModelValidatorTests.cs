using System.Collections;
using NUnit.Framework;

namespace Laconic.TestingValidation.Tests
{
    [TestFixture]
    public class RegisterModelValidatorTests : ValidatorTestFixtureBase<RegisterModelValidator, RegisterModel>
    {
        protected static readonly IEnumerable ValidTestCases = new[]
        {
            Case("Default", x => {}),
        };

        protected static readonly IEnumerable InvalidTestCases = new[]
        {
            Case("Email null", x => x.Email, x => x.Email = null),
            Case("Email empty", x => x.Email, x => x.Email = ""),
            Case("Email not email", x => x.Email, x => x.Email = "not-email", "Please provide correct email"),
            Case("FirstName null", x => x.FirstName, x => x.FirstName = null),
            Case("FirstName empty", x => x.FirstName, x => x.FirstName = ""),
            Case("LastName null", x => x.LastName, x => x.LastName = null),
            Case("LastName empty", x => x.LastName, x => x.LastName = ""),
            Case("Password null", x => x.Password, x => x.Password = null),
            Case("Password empty", x => x.Password, x => x.Password = ""),
            Case("Password too short", x => x.Password, x => x.Password = "1234567"),
        };

        protected override RegisterModel CreateInput()
        {
            return new RegisterModel
                   {
                       Email = "user@example.com",
                       Password = "password",
                       FirstName = "First",
                       LastName = "Last",
                   };
        }

        protected override RegisterModelValidator CreateValidator()
        {
            return new RegisterModelValidator();
        }
    }
}
