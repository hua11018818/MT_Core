/******************************************************
 * 项目名称: MT.Core.Document
 * 项目描述:
 * 类 名 称: XmlHelper
 * 版 本 号:
 * 说    明:
 * 作    者：唐明华
 * 创建时间：2016/11/21 19:42:54
 *******************************************************
 * 更新时间: 2016/11/21 19:42:54
******************************************************/

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MT.Core.Document
{
    /// <summary>
    /// 
    /// </summary>
    public class XmlHelper
    {

        #region XML节点判断操作
        /// <summary>
        /// 判断XML节点中是否至少包含一个搜索名称的子节点
        /// </summary>
        /// <param name="xElement">节点</param>
        /// <param name="name">子节点名称</param>
        /// <returns></returns>
        public static bool HasElementsByName(XElement xElement, string name)
        {
            return null != xElement && xElement.Elements(name).Any();
        }

        /// <summary>
        /// 判断XML节点中是否包含唯一符合名称的子节点
        /// </summary>
        /// <param name="xElement">节点</param>
        /// <param name="singleName">子节点名称</param>
        /// <returns></returns>
        public static bool HasElementBySingleName(XElement xElement, string singleName) => null != GetElementBySingleName(xElement, singleName);

        /// <summary>
        /// 判断节点是否包含某个属性
        /// </summary>
        /// <param name="xElement">节点</param>
        /// <param name="attributeName">属性名</param>
        /// <returns></returns>
        public static bool HasAttributeByName(XElement xElement, string attributeName)
        {
            if (!xElement.HasAttributes) return false;
            var xAttribute = xElement.Attribute(attributeName);
            return null != xAttribute;
        }

        #endregion

        #region XML节点获取操作

        /// <summary>
        /// 获取XML节点的单独子节点信息
        /// </summary>
        /// <param name="xElement">节点</param>
        /// <param name="singleName">唯一子节点名字</param>
        /// <returns></returns>
        public static XElement GetElementBySingleName(XElement xElement, string singleName)
        {
            XElement returnElement = null;
            if (null != xElement)
            {
                try { returnElement = xElement.Elements().Single(x => x.Name == singleName); }
                catch
                {
                    // ignored
                }
            }
            return returnElement;
        }
        
        /// <summary>
        /// 模糊查找：根据名称,获取节点下查找符合条件的子节点集合
        /// </summary>
        /// <param name="xElement">节点</param>
        /// <param name="elementName">模糊匹配子节点名称</param>
        /// <returns></returns>
        public static IEnumerable<XElement> GetElementsByContainsName(XElement xElement, string elementName)
        {
            if (null != xElement)
            {
                var query = from rtnElement in xElement.Elements()
                            where rtnElement.Name.ToString().Contains(elementName)
                            select rtnElement;
                return query;
            }
            return null;
        }

        /// <summary>
        /// 根据节点名称，查找节点下符合条件的子节点信息
        /// </summary>
        /// <param name="xElement">节点</param>
        /// <param name="elementName">节点名称</param>
        /// <returns></returns>
        public static IEnumerable<XElement> GetElementsByName(XElement xElement, string elementName) => xElement?.Elements(elementName);
        
        /// <summary>
        /// 获取节点的value值
        /// </summary>
        /// <param name="xElement">节点</param>
        /// <returns></returns>
        public static string GetElementValue(XElement xElement) => xElement?.Value;

        /// <summary>
        /// 获取属性的value值
        /// </summary>
        /// <param name="xAttribute">属性</param>
        /// <returns></returns>
        public static string GetAttributeValue(XAttribute xAttribute) => xAttribute?.Value;

        /// <summary>
        /// 获取节点下的属性值
        /// </summary>
        /// <param name="xElement">节点</param>
        /// <param name="attributeName">属性名称</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static string GetAttributeValueByName(XElement xElement, string attributeName, string defaultValue = "")
        {
            string rtnValue = defaultValue;
            if (null == xElement) return rtnValue;
            var xAttribute = xElement.Attribute(attributeName);
            if (xAttribute != null) rtnValue = xAttribute.Value;
            return rtnValue;
        }

        /// <summary>
        /// 获取XML节点的单独子节点的取值
        /// </summary>
        /// <param name="xElement">节点</param>
        /// <param name="singleName">唯一子节点名字</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static string GetElementValueByName(XElement xElement, string singleName, string defaultValue = "")
        {
            string rtnValue = defaultValue;
            XElement singleElement = GetElementBySingleName(xElement, singleName);
            if (null != singleElement)
            {
                rtnValue = singleElement.Value;
            }
            return rtnValue;
        }
        #endregion
    }
}
