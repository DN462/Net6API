using Microsoft.Extensions.Logging.Abstractions;
using Net6API.Data;
using Net6API.Interface;
using Net6API.Utilities;
using Net6API.Validation;
using NUnit.Framework;

namespace Net6APITests.Tests.Validation.User.Update
{
    [TestFixture]
	public class DatabaseUpdateUserTest
	{
        IUserValidation _userValidation;
        IValidationHelper _validationHelper;
        [OneTimeSetUp]
        public void Setup()
        {
            _validationHelper = new ValidationHelper(new NullLogger<ValidationHelper>());
            _userValidation = new UserValidation(_validationHelper);
        }

        [Test]
        public void UpdateUserValidationFailureCityIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureCityIsMissing()
        {
            UserInformation userData = new();
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureCityIsSpace()
        {
            UserInformation userData = new();
            userData.City = " ";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureCountryIdIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureCountryIdIsNegative()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = -2;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureCountryIdIsZero()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 0;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureEmailIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureEmailIsInvalid()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureEmailIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureEmailIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = " ";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureFirstNameIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureFirstNameIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureFirstNameIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = " ";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureLastNameIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureLastNameIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureLastNameIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = " ";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailurePhoneIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailurePhoneIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailurePhoneIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = " ";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailurePostalCodeIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailurePostalCodeIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailurePostalCodeIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = " ";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureStreetAddressIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureStreetAddressIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureStreetAddressIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = " ";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationUserIdIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationUserIdIsNegative()
        {
            UserInformation userData = new();
            userData.Id = -1;
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationFailureUserIdIsZero()
        {
            UserInformation userData = new();
            userData.Id = 0;
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(userData));
        }
        [Test]
        public void UpdateUserValidationSuccess()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Id = 1;
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsTrue(_userValidation.ValidateUpdatingUser(userData));
        }
    }
}

