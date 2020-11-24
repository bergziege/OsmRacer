using System.IO;

namespace GeoTiffElevation.Api {
    public interface IElevationApi {
        double GetElevation(string filePath, double lat, double lon);
    }
}