using System;
using System.Net.Mail;
using Microsoft.Extensions.Logging;
using Net6API.Interface;

namespace Net6API.Utilities
{
	public class ValidationHelper : IValidationHelper
	{
        /*
         * This is a Helper I built and designed after I left.
         * This should be of major help as it helps validate email addresses to a certain point.
         * It tests that the hostname in the email address contains a period.
         * If it does infact have one then it is reasonable to assume the email address is valid.
         */

        // This sets up the Logging service to be able to be used within this class.
        private readonly ILogger<ValidationHelper> _logger;

        // This is enabling the class and helping it inject all of the dependencies in this case the logging system
        public ValidationHelper(ILogger<ValidationHelper> logger)
        {
            _logger = logger;
        }

        // This is to test if the email address is given is valid.
        private bool TestingIsEmailValid(string Email)
        {
            /*
             * This is written without the setting of true or false as it is not required.
             * This is set no matter what within the function so it is going to always have a value returned.
             * The compiler sees it and accepts the fact it will be set so it will continue to compile.
             */
            bool valid;
            try
            {
                /*
                 * Uses the System.Net.Mail library to use the MailAddress function to generate the email address.
                 * It takes the email address string passed in and breaks it down into its sub parts and checks the validity
                 * of the email that gets passed in.
                 */
                MailAddress m = new (Email);

                /*
                 * The if statement below uses the Contains method to check if the host has a period in the name which
                 * is being used as the decision point if the email is valid. If it is valid then we pass it through if
                 * not then it is marked as false. This also could be written in a single line stating:
                 * valid = m.Host.Contains(".");
                 * It generates the boolean expression but for easier understanding I have it written below in longer format.
                 */
                if (m.Host.Contains("."))
                    valid = true;
                else
                    valid = false;
            }
            catch (Exception ex)
            {
                // Catches the error and logs it into the system using the logging system that was injected
                _logger.LogError("An Error has occurred in TestingIsEmailValid function in ValidationHelper class: ", ex);
                valid = false;
            }
            return valid;
        }
        public bool TestIsEmailValid(string Email)
        {
            return TestingIsEmailValid(Email);
        }
    }
}

