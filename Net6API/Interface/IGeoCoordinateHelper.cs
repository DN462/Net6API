using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net6API.Interface
{
    public interface IGeoCoordinateHelper
	{
		public Task<Dictionary<double, double>> GetGeoCoordinates(string StreetAddress);
	}
}

