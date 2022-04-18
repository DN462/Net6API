using Microsoft.Extensions.Logging.Abstractions;
using Net6API.Interface;
using Net6API.Models.Shared.User;
using Net6API.Models.User;
using Net6API.Utilities;
using Net6API.Validation;
using NUnit.Framework;

namespace Net6APITests.Tests.Validation.User.Create
{
	[TestFixture]
    public class CreateUserTest
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureCityIsMissing()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureCityIsSpace()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureCountryIdIsMissing()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureCountryIdIsNegative()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureCountryIdIsZero()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureEmailIsEmpty()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureEmailIsInvalid()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureEmailIsMissing()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureEmailIsSpace()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureFirstNameIsEmpty()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureFirstNameIsMissing()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureFirstNameIsSpace()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureLastNameIsEmpty()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureLastNameIsMissing()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureLastNameIsSpace()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailurePhoneIsEmpty()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailurePhoneIsMissing()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailurePhoneIsSpace()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailurePostalCodeIsEmpty()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailurePostalCodeIsMissing()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailurePostalCodeIsSpace()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureStreetAddressIsEmpty()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureStreetAddressIsMissing()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationFailureStreetAddressIsSpace()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsFalse(_userValidation.ValidateCreatingUser(createUserData));
        }
        [Test]
        public void CreateUserValidationSuccess()
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
            CreateUserInputDataModel createUserData = new();
            createUserData.User = userData;
            Assert.IsTrue(_userValidation.ValidateCreatingUser(createUserData));
        }
    }
}

