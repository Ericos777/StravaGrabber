using com.strava.api.Activities;
using com.strava.api.Segments;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaGrabber.Managers
{
    class SegmentController
    {
        public ExplorerResult Result { get; set; }


        public SegmentController(ExplorerResult result)
        {
            Result = result;
        }


        public void ToFile(string filename)
        {

            if (!File.Exists(filename))
            {
                // Create a file to write to. 
                using (StreamWriter sw = File.CreateText(filename))
                {
                    var counter = 0;

                    foreach (var seg in Result.Results)
                    {
                        counter++;

                        if (counter == 1)//header toevoegen
                        {
                            sw.WriteLine(seg.GetHeader());
                        }

                        sw.WriteLine(seg.GetLine());
                    }

                }
            }
            else
            {
                // Opens a file to write to. 
                using (StreamWriter sw = File.CreateText(filename))
                {
                    foreach (var seg in Result.Results)
                    {
                        sw.WriteLine(seg.GetLine());
                    }
                }
            }

            Console.WriteLine(String.Format("De segmenten zijn weggeschreven op : {0}", filename));


        }


    }
}
