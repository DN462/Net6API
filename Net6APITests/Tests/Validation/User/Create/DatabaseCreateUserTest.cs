using System;
using Microsoft.Extensions.Logging.Abstractions;
using Net6API.Data;
using Net6API.Interface;
using Net6API.Utilities;
using Net6API.Validation;
using NUnit.Framework;

namespace Net6APITests.Tests.Validation.User.Create
{
    [TestFixture]
	public class DatabaseCreateUserTest
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
        public void CreateUserValidationFailureCityIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureCityIsMissing()
        {
            UserInformation userData = new();
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureCityIsSpace()
        {
            UserInformation userData = new();
            userData.City = " ";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureCountryIdIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureCountryIdIsNegative()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = -2;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureCountryIdIsZero()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 0;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureEmailIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureEmailIsInvalid()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureEmailIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureEmailIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = " ";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureFirstNameIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureFirstNameIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureFirstNameIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = " ";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureLastNameIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureLastNameIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureLastNameIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = " ";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailurePhoneIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailurePhoneIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailurePhoneIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = " ";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailurePostalCodeIsEmpty()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailurePostalCodeIsMissing()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailurePostalCodeIsSpace()
        {
            UserInformation userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = " ";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureStreetAddressIsEmpty()
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
            userData.StreetAddress = "";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureStreetAddressIsMissing()
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
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureStreetAddressIsSpace()
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
            userData.StreetAddress = " ";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureUserIdIsNegative()
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
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationFailureUserIdIsPositive()
        {
            UserInformation userData = new();
            userData.Id = 2;
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            Assert.IsFalse(_userValidation.ValidateCreatingUser(userData));
        }
        [Test]
        public void CreateUserValidationSuccess()
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
            Assert.IsTrue(_userValidation.ValidateCreatingUser(userData));
        }
    }
}