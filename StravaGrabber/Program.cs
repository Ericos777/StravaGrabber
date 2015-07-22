using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.strava.api.Clients;
using com.strava.api.Authentication;
using com.strava.api.Common;
using StravaGrabber.Managers;



namespace StravaGrabber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StaticAuthentication auth = new StaticAuthentication("c441c195cb8cfbea510177272daa357d5f7782b8");

            SegmentClient client = new SegmentClient(auth);

            Coordinate southwest = new Coordinate(52.517385, 6.104680);

            Coordinate northeast = new Coordinate(52.511221, 6.090261);

            var result = client.ExploreSegments(northeast, southwest);

            var controller = new SegmentController(result);

            controller.ToFile(@"C:\\temp\\test\\segmenten.csv");
            

            //foreach (var segment in result.Results)
            //{
            //    Console.WriteLine(segment.ToString());
            //}
            Console.Read();

        }
    }
}
