using Net6API.Models.User;

namespace Net6API.Interface
{
	public interface IProcessingUser
	{
		public Task<bool> CreateUser(CreateUserInputDataModel user);
		public Task<bool> UpdateUser(UpdateUserInputDataModel user);
	}
}

