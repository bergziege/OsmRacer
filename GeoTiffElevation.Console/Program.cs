using System.IO;
using GeoTiffElevation.Api;

namespace GeoTiffElevation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IElevationApi api = new ElevationApi();
            double elevation = api.GetElevation(@"C:\Develop\GeoTiffElevationApiData\Sachsen_20m\DTM_Germany_Sachsen_20m.tif", 13, 51);
            System.Console.WriteLine(elevation);
        }
    }
}
