using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOC.Test
{
    public interface IConfigReader
    {

    }
    public class ConfigReader : IConfigReader
    {
        public ConfigReader(string configSectionName)
        {
            // Store config section name
        }
    }
}