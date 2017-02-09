using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TestConfiguration.Handler
{
    public class YowkoSettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("yowkoSetting")]
        [ConfigurationCollection(typeof(YowkoDataElement))]
        public YowkoDataElementCollection yowkoSetting
        {
            get { return this["yowkoSetting"] as YowkoDataElementCollection; }
        }
    }

    public class YowkoDataElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new YowkoDataElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            //throw new NotImplementedException();
            return (element as YowkoDataElement).Channel;
        }
    }
}