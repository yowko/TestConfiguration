using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TestConfiguration.Handler
{
    public class YowkoSettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("yowkoData")]
        //[ConfigurationCollection(typeof(YowkoDataElement))]
        public YowkoDataElement YowkoData
        {
            get { return this["yowkoData"] as YowkoDataElement; }
        }


        //[ConfigurationProperty("yowkoSetting")]
        ////[ConfigurationCollection(typeof(YowkoDataElement))]
        //public YowkoDataElement yowkoSetting
        //{
        //    get { return this["yowkoSetting"] as YowkoDataElement; }
        //}


        //[ConfigurationProperty("YowkoDatas")]
        //[ConfigurationCollection(typeof(YowkoDataElement))]
        //public YowkoDataElementCollection YowkoDatas => this["YowkoDatas"] as YowkoDataElementCollection;

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