#region Copyright (C) 2015 Sascha Simon

//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see http://www.gnu.org/licenses/.
//
//  Visit the official homepage at http://www.sascha-simon.com

#endregion

using Newtonsoft.Json;

namespace com.strava.api.Statistics
{
    public class Stats
    {
        [JsonProperty("biggest_ride_distance")]
        public double BiggestRideDistance { get; set; }

        [JsonProperty("biggest_climb_elevation_gain")]
        public double BiggestClimbElevationGain { get; set; }

        [JsonProperty("recent_ride_totals")]
        public RecentRideTotals RecentRideTotals { get; set; }

        [JsonProperty("recent_run_totals")]
        public RecentRunTotals RecentRunTotals { get; set; }

        [JsonProperty("ytd_ride_totals")]
        public YearToDateRideTotals YearToDateRideTotals { get; set; }

        [JsonProperty("ytd_run_totals")]
        public YearToDateRunTotals YearToDateRunTotals { get; set; }

        [JsonProperty("all_ride_totals")]
        public AllRideTotals RideTotals { get; set; }
        
        [JsonProperty("all_run_totals")]
        public AllRunTotals RunTotals { get; set; }
    }
}
