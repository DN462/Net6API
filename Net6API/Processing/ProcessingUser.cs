using System;
using Net6API.Data;
using Net6API.Interface;
using Net6API.Models.User;

namespace Net6API.Processing
{
	public class ProcessingUser
	{
		private readonly AppDbContext _context;
		private readonly ILogger<ProcessingUser> _logger;
		private readonly IUserValidation _userValidation;
		public ProcessingUser(AppDbContext context, ILogger<ProcessingUser> logger, IUserValidation userValidation)
        {
			_context = context;
			_logger = logger;
			_userValidation = userValidation;
        }
		private async Task<bool> CreatingUser(CreateUserInputDataModel user)
		{
			bool success;
			try
			{
				if (_userValidation.ValidateCreatingUser(user))
				{
					UserInformation newUser = new();
					newUser.City = user.User.City;
					newUser.CountryId = user.User.CountryId;
					newUser.Email = user.User.Email;
					newUser.FirstName = user.User.FirstName;
					newUser.LastName = user.User.LastName;
					newUser.Phone = user.User.Phone;
					newUser.PostalCode = user.User.PostalCode;
					newUser.State = user.User.State;
					newUser.StreetAddress = user.User.StreetAddress;
					if (_userValidation.ValidateCreatingUser(newUser))
					{
						await _context.UsersInformation.AddAsync(newUser);
						await _context.SaveChangesAsync();
						success = true;
					}
					else
						success = false;
				}
				else
					success = false;
			}
			catch (Exception ex)
			{
				_logger.LogError("Error has occurred in the CreatingUser function in the ProcessingUser class: " + ex);
				success = false;
			}
			return success;
		}
	}
}