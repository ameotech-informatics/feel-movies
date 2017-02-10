using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Globalization;

namespace MovieFeeler.Common
{
    public class ConfigSettings
    {
        public static string GetApiKey() 
        {
            if (ConfigurationManager.AppSettings["MOVIEDB_APIKEY"] != null) 
            {
                return ConfigurationManager.AppSettings["MOVIEDB_APIKEY"];
            }
            return "";
        }
        public static string GetMovieDBUrl()
        {
            if (ConfigurationManager.AppSettings["MOVIEDB_APIURL"] != null) 
            {
                return ConfigurationManager.AppSettings["MOVIEDB_APIURL"];
            }
            return "";
        }
        public static string GetDisqusShortname() 
        {
            if (ConfigurationManager.AppSettings["DisqusShortName"] != null)
            {
                return ConfigurationManager.AppSettings["DisqusShortName"];
            }
            return "";
        }
    }
}
