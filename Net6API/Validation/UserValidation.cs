using Net6API.Data;
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
		private bool ValidatingUser(UserInputDataModel user)
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
			return Errors == 0;
        }
		private bool ValidatingUser(UserInformation user, bool creatingUser)
        {
			int Errors = 0;
			if (creatingUser)
			{
				if (user.Id != 0)
					Errors++;
			}
			else
				if (user.Id < 1)
				Errors++;
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
			return Errors == 0;
        }
		private bool ValidatingUpdatingUser(UpdateUserInputDataModel user)
		{
			int Errors = 0;
			if (user.UserId < 1)
				Errors++;
			Errors += ValidatingUser(user.User) ? 0 : 1;
			return Errors == 0;
		}
		public bool ValidateCreatingUser(CreateUserInputDataModel user)
		{
			return ValidatingUser(user.User);
		}
		public bool ValidateCreatingUser(UserInformation user)
		{
			return ValidatingUser(user, true);
		}
		public bool ValidateUpdatingUser(UpdateUserInputDataModel user)
		{
			return ValidatingUpdatingUser(user);
		}
		public bool ValidateUpdatingUser(UserInformation user)
        {
			return ValidatingUser(user, false);
        }
	}
}