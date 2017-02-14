using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TestConfiguration.Handler
{
    public class YowkoSettings : ConfigurationSection
    {
        [ConfigurationProperty("yowkoSettings", IsRequired = true)]
        [ConfigurationCollection(typeof(YowkoSettingsElementCollection), AddItemName = "yowkoData", ClearItemsName = "clear", RemoveItemName = "remove")]
        public YowkoSettingsElementCollection yowkoSettings
        {
            get { return this["yowkoSettings"] as YowkoSettingsElementCollection; }
            set { this["yowkoSettings"] = value; }
        }

        public class YowkoSettingsElementCollection : ConfigurationElementCollection, IEnumerable<YowkoDataElement>
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

            //protected List<YowkoDataElement> ToList()
            //{
            //    yield return 
            //}
            IEnumerator<YowkoDataElement> IEnumerable<YowkoDataElement>.GetEnumerator()
            {
                foreach (YowkoDataElement element in Enumerable.Range(0, base.Count).Select(base.BaseGet))
                    yield return element;
            }
        }
    }
}