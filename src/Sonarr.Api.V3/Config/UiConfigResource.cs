﻿using Sonarr.Http.REST;

namespace Sonarr.Api.V3.Config
{
    public class UiConfigResource : RestResource
    {
        //Calendar
        public int FirstDayOfWeek { get; set; }
        public string CalendarWeekColumnHeader { get; set; }

        //Dates
        public string ShortDateFormat { get; set; }
        public string LongDateFormat { get; set; }
        public string TimeFormat { get; set; }
        public bool ShowRelativeDates { get; set; }

        public bool EnableColorImpairedMode { get; set; }
    }
}