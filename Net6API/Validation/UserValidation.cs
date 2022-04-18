using Net6API.Interface;
using Net6API.Models.User;

namespace Net6API.Validation
{
    public class UserValidation : IUserValidation
	{
		private IValidationHelper _helper;
		public UserValidation(IValidationHelper helper)
        {
			_helper = helper;
        }
		private bool ValidatingCreatingUser(CreateUserInputDataModel user)
		{
			int Errors = 0;
			if (string.IsNullOrWhiteSpace(user.User.FirstName))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.LastName))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.Email) || _helper.TestIsEmailValid(user.User.Email))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.Phone))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.StreetAddress))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.City))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.PostalCode))
				Errors++;
			if (user.User.CountryId == 0)
				Errors++;
			return Errors == 0;
		}
		private bool ValidatingUpdatingUser(UpdateUserInputDataModel user)
		{
			int Errors = 0;
			if (user.UserId == 0)
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.FirstName))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.LastName))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.Email) || _helper.TestIsEmailValid(user.User.Email))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.Phone))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.StreetAddress))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.City))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.User.PostalCode))
				Errors++;
			if (user.User.CountryId == 0)
				Errors++;
			return Errors == 0;
		}
		public bool ValidateCreatingUser(CreateUserInputDataModel user)
		{
			return ValidatingCreatingUser(user);
		}
		public bool ValidateUpdatingUser(UpdateUserInputDataModel user)
		{
			return ValidatingUpdatingUser(user);
		}
	}
}