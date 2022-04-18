using Net6API.Interface;
using RestSharp;

namespace Net6API.Utilities
{
    // This is written to use an Interface so it can be used as a Dependency Injection across the entire project to streamline the code.
	public class CallApi : ICallApi
	{
        private static async Task<RestResponse> ApiCalling(string url, Method method, string? body = null)
        {
            // Url gets passed in and filtered for bad characters (Note your API copy may not have this)
            url = Uri.EscapeDataString(url);
            /*
             * Generates a RestClient based on what URL you wish to make the request to.
             * As of .NET 5 the redeclaration of what you are needing as new is no longer required.
             * It instantiates based off of the value declared for the variable datatype.
             */
            RestClient client = new(url);

            /*
             * Generates a container for the Request to be sent to the client endpoint.
             * This is set to use the Http Method passed in as well as if there was a body to add it as a JSON body for processing.
             */
            RestRequest request = new();
            request.Method = method;

            /*
             * As of .NET 5 if the if statement is a single line that would be within the brackets it is permitted to use no brackets
             * It uses an indentation setup identical to python if it will be single line like below.
             */
            if (!string.IsNullOrWhiteSpace(body) && !request.Method.Equals(Method.Get) || !request.Method.Equals(Method.Delete))
                request.AddJsonBody(body);
            return await client.ExecuteAsync(request);
        }
        public async Task<RestResponse> ApiCall(string url, Method method, string? body = null)
        {
            return await ApiCalling(url, method, body);
        }
    }
}