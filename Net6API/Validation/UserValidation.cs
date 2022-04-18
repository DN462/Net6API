using Net6API.Interface;
using Net6API.Models.Shared.User;
using Net6API.Models.User;

namespace Net6API.Validation
{
    public class UserValidation : IUserValidation
	{
		private readonly IValidationHelper _helper;
		public UserValidation(IValidationHelper helper)
        {
			_helper = helper;
        }
		private int ValidatingUser(UserInputDataModel user)
        {
			int Errors = 0;
			if (string.IsNullOrWhiteSpace(user.FirstName))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.LastName))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.Email) || !_helper.TestIsEmailValid(user.Email))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.Phone))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.StreetAddress))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.City))
				Errors++;
			if (string.IsNullOrWhiteSpace(user.PostalCode))
				Errors++;
			if (user.CountryId < 1)
				Errors++;
			return Errors;
        }
		private bool ValidatingCreatingUser(CreateUserInputDataModel user)
		{
			return ValidatingUser(user.User) == 0;
		}
		private bool ValidatingUpdatingUser(UpdateUserInputDataModel user)
		{
			int Errors = 0;
			if (user.UserId == 0)
				Errors++;
			Errors += ValidatingUser(user.User);
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