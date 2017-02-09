using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TestConfiguration.Handler
{
    public class YowkoSettingsSection : ConfigurationSection
    {
        //[ConfigurationProperty("yowkoData")]
        //public YowkoDataElement YowkoData
        //{
        //    get { return this["yowkoData"] as YowkoDataElement; }
        //}

        [ConfigurationProperty("yowkoDatas")]
        [ConfigurationCollection(typeof(YowkoDataElement), AddItemName = "yowkoData")]
        public YowkoDataElementCollection YowkoDatas => this["yowkoDatas"] as YowkoDataElementCollection;



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