using System.Threading.Tasks;
using RestSharp;

namespace Net6API.Interface
{
    public interface ICallApi
	{
		/*
		 * It is returning Rest Response even though in your code you will see IRestResponse it is the same.
		 * This interface is to satisfy the requirements of security scanning tools to reduce code duplication.
		 * All API Calls will be routed through here using the URL string, the Http Method (GET, POST, PUT, DELETE)
		 * If there is a body to be sent along it would occupy the body variable otherwise it can be omitted as it defaults to null. 
		 */
		public Task<RestResponse> ApiCall(string url, Method method, string? body = null);
	}
}

