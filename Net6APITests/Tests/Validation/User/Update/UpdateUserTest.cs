using System;
using Microsoft.Extensions.Logging.Abstractions;
using Net6API.Interface;
using Net6API.Models.Shared.User;
using Net6API.Models.User;
using Net6API.Utilities;
using Net6API.Validation;
using NUnit.Framework;

namespace Net6APITests.Tests.Validation.User.Update
{
	[TestFixture]
	public class UpdateUserTest
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
            UserInputDataModel userData = new();
            userData.City = "";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureCityIsMissing()
        {
            UserInputDataModel userData = new();
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureCityIsSpace()
        {
            UserInputDataModel userData = new();
            userData.City = " ";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureCountryIdIsMissing()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureCountryIdIsNegative()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = -2;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureCountryIdIsZero()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 0;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureEmailIsEmpty()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureEmailIsInvalid()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureEmailIsMissing()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureEmailIsSpace()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = " ";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureFirstNameIsEmpty()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureFirstNameIsMissing()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureFirstNameIsSpace()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = " ";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureLastNameIsEmpty()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureLastNameIsMissing()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureLastNameIsSpace()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = " ";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailurePhoneIsEmpty()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailurePhoneIsMissing()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailurePhoneIsSpace()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = " ";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailurePostalCodeIsEmpty()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailurePostalCodeIsMissing()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailurePostalCodeIsSpace()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = " ";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureStreetAddressIsEmpty()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureStreetAddressIsMissing()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureStreetAddressIsSpace()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = " ";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureUserIdIsMissing()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureUserIdIsNegative()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = -4;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationFailureUserIdIsZero()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 0;
            UpdateUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
        [Test]
        public void UpdateUserValidationSuccess()
        {
            UserInputDataModel userData = new();
            userData.City = "City";
            userData.CountryId = 1;
            userData.Email = "Email@test.net";
            userData.FirstName = "FirstName";
            userData.LastName = "LastName";
            userData.Phone = "888-888-8888";
            userData.PostalCode = "90210";
            userData.State = "California";
            userData.StreetAddress = "123 Main Street";
            UpdateUserInputDataModel UpdateUserData = new();
            UpdateUserData.UserId = 1;
            UpdateUserData.User = userData;
            Assert.IsTrue(_userValidation.ValidateUpdatingUser(UpdateUserData));
        }
    }
}

