using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemSkuCreateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSkuCreateInfo : AopObject
    {
        /// <summary>
        /// 成本价，单位分
        /// </summary>
        [XmlElement("cost_price")]
        public long CostPrice { get; set; }

        /// <summary>
        /// SKU扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("item_ext_info")]
        public List<ItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 标价，单位分
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 售价，单位分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }
    }
}
