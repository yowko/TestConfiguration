using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TestConfiguration.Handler
{
    public class YowkoConfigSectionHandler : ConfigurationSection
    {
        [ConfigurationProperty("channel", DefaultValue = "", IsRequired = true)]
        public string Channel
        {
            get
            {
                return this["channel"] as string;
            }
            set
            {
                this["channel"] = value;
            }
        }

        [ConfigurationProperty("userName", IsRequired = true)]
        public string UserName
        {
            get
            {
                return this["userName"] as string;
            }
            set
            {
                this["userName"] = value;
            }

        }

        [ConfigurationProperty("userSecret", IsRequired = true)]
        public string UserSecret
        {
            get
            {
                return this["userSecret"] as string;
            }
            set
            {
                this["userSecret"] = value;
            }
        }
    }

    public class yowkoConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("yowkoData")]
        public YowkoDataElement YowkoData
        {
            get { return this["yowkoData"] as YowkoDataElement; }
        }
        //[ConfigurationProperty("yowkoDatas")]
        //[ConfigurationCollection(typeof(YowkoDataElement))]
        //public YowkoDataCollection Caches
        //{
        //    get
        //    {
        //        return this["yowkoDatas"] as YowkoDataCollection;
        //    }
        //}
    }

    //public class YowkoDataCollection : ConfigurationElementCollection
    //{
    //    protected override ConfigurationElement CreateNewElement()
    //    {
    //        return new YowkoDataElement();
    //    }

    //    protected override object GetElementKey(ConfigurationElement element)
    //    {
    //        return (element as YowkoDataElement).Channel;
    //    }
    //}


    public class YowkoDataElement : ConfigurationElement
    {
        [ConfigurationProperty("channel", DefaultValue = "", IsRequired = true)]
        public string Channel
        {
            get
            {
                return this["channel"] as string;
            }
            set
            {
                this["channel"] = value;
            }
        }

        [ConfigurationProperty("userName", IsRequired = true)]
        public string UserName
        {
            get
            {
                return this["userName"] as string;
            }
            set
            {
                this["userName"] = value;
            }

        }

        [ConfigurationProperty("userSecret", IsRequired = true)]
        public string UserSecret
        {
            get
            {
                return this["userSecret"] as string;
            }
            set
            {
                this["userSecret"] = value;
            }
        }
    }

}