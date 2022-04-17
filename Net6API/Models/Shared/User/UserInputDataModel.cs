using System.ComponentModel.DataAnnotations;

namespace Net6API.Models.Shared.User
{
	public class UserInputDataModel
	{

        [MinLength(2, ErrorMessage = "First Name must be a minimum of 2 characters.")]
        [MaxLength(50, ErrorMessage = "First Name can not exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Last Name must be a minimum of 2 characters.")]
        [MaxLength(100, ErrorMessage = "Last Name can not exceed 100 characters.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MinLength(6, ErrorMessage = "Email must be a minimum of 6 characters.")]
        [MaxLength(320, ErrorMessage = "Email can not exceed 320 characters.")]
        public string Email { get; set; }

        [Required]
        [Phone]
        [MinLength(1, ErrorMessage = "Phone must be a minimum of 1 character.")]
        [MaxLength(20, ErrorMessage = "Phone can not exceed 20 characters.")]
        public string Phone { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Street Address must be a minimum of 3 characters.")]
        [MaxLength(200, ErrorMessage = "Street Address can not exceed 200 characters.")]
        public string StreetAddress { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "City must be at least 1 character.")]
        [MaxLength(100, ErrorMessage = "City can not exceed 100 characters.")]
        public string City { get; set; }

        // This is optional as some countries do not have States/Provinces
        public string State { get; set; }

        /*
         * This is set as an int as the Countries would be a dropdown sent in a key value pair.
         * The program generally would get the ID as the key and the Country Name as the value.
         */
        [Required]
        public int CountryId { get; set; }

        [Required]
        public string PostalCode { get; set; }
    }
}

