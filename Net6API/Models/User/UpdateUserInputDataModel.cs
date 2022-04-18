using System;
using Net6API.Models.Shared.User;

namespace Net6API.Models.User
{
	public class UpdateUserInputDataModel
	{
        public int UserId { get; set; }
        public UserInputDataModel User { get; set; }
    }
}