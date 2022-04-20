using Net6API.Data;
using Net6API.Models.User;

namespace Net6API.Interface
{
	public interface IUserValidation
	{
		public bool ValidateCreatingUser(CreateUserInputDataModel user);
		public bool ValidateCreatingUser(UserInformation user);
		public bool ValidateUpdatingUser(UpdateUserInputDataModel user);
		public bool ValidateUpdatingUser(UserInformation user);
	}
}