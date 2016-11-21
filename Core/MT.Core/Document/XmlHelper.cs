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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MT.Core.Document
{
    /// <summary>
    /// 
    /// </summary>
    public class XmlHelper
    {
        /// <summary>
        /// 判断XML节点中是否包含子节点
        /// </summary>
        /// <param name="xElement">节点</param>
        /// <param name="name">子节点名称</param>
        /// <returns></returns>
        public static bool HasElementsByName(XElement xElement, string name)
        {
            return null != xElement && xElement.Elements(name).Any();
        }
    }
}
