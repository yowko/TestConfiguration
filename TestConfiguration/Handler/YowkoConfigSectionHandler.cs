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
    }

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