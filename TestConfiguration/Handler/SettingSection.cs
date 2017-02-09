using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TestConfiguration.Handler
{
    public class SettingSection : ConfigurationSection
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get
            {
                return this["name"] as string;
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("type", IsRequired = false)]
        public string Type
        {
            get
            {
                return this["type"] as string;
            }
            set
            {
                this["type"] = value;
            }
        }

        [ConfigurationProperty("Caches")]
        [ConfigurationCollection(typeof(CacheEle), AddItemName = "Cache")]
        public CacheEleCollection Caches
        {
            get
            {
                return this["Caches"] as CacheEleCollection;
            }
        }
    }
    public class CacheEleCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new CacheEle();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as CacheEle).Name;
        }

        public CacheEle this[int index]
        {
            get
            {
                return this.BaseGet(index) as CacheEle;
            }
        }
    }
    public class CacheEle : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get
            {
                return this["name"] as string;
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("path", IsRequired = true)]
        public string Path
        {
            get
            {
                return this["path"] as string;
            }
            set
            {
                this["path"] = value;
            }
        }

        [ConfigurationProperty("Global")]
        public CacheGlobalEle Global
        {
            get
            {
                return this["Global"] as CacheGlobalEle;
            }
        }

        [ConfigurationProperty("Session")]
        public CacheSessionEle Session
        {
            get
            {
                return this["Session"] as CacheSessionEle;
            }
        }
    }
    public class CacheGlobalEle : ConfigurationElement
    {
        [ConfigurationProperty("duration")]
        public string Duration
        {
            get
            {
                return this["duration"] as string;
            }
            set
            {
                this["duration"] = value;
            }
        }
    }
    public class CacheSessionEle : ConfigurationElement
    {
        [ConfigurationProperty("duration")]
        public string Duration
        {
            get
            {
                return this["duration"] as string;
            }
            set
            {
                this["duration"] = value;
            }
        }

        [ConfigurationProperty("autoExpire")]
        public string AutoExpire
        {
            get
            {
                return this["autoExpire"] as string;
            }
            set
            {
                this["autoExpire"] = value;
            }
        }
    }
}