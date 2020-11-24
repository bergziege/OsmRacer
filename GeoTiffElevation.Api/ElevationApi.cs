using System.Diagnostics;
using System.Globalization;
using OSGeo.GDAL;
using OSGeo.OGR;

namespace GeoTiffElevation.Api {
    public class ElevationApi : IElevationApi {

        public double GetElevation(string filePath, double lat, double lon) {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"./ExternalCalls/CallGdallocationinfo.bat",
                    Arguments =
                        $"{filePath} {lat.ToString(CultureInfo.InvariantCulture)} {lon.ToString(CultureInfo.InvariantCulture)}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = false
                }
            };
            proc.Start();
            double elevation = -10000;
            while (!proc.StandardOutput.EndOfStream) {
                var line = proc.StandardOutput.ReadLine();
                if (line.Contains("Value:")) {
                    line = line.Replace("    Value: ", "");
                    elevation = double.Parse(line, CultureInfo.InvariantCulture);
                }
            }

            return elevation;
        }
    }
}