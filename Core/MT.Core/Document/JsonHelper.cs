/******************************************************
 * 项目名称: MT.Core.Document
 * 项目描述:
 * 类 名 称: JsonHelper
 * 版 本 号:
 * 说    明:
 * 作    者：唐明华
 * 创建时间：2016/11/21 19:41:28
 *******************************************************
 * 更新时间: 2016/11/24 唐明华
******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Core.Document
{
    /// <summary>
    /// 请引用Newtonsoft.Json类库去操作JSON数据
    ///1,序列号JSON字符串
    ///string jsonStr = JsonConvert.SerializeObject(obj);
    ///2，通过字符串反射对象
    ///object obj = JsonConvert.DeserializeObject<object>(jsonStr);
    ///3,拼接JSON对象推荐使用：JObject
    ///4,拼接JSON数据推荐使用：JArray
    /// </summary>
    public class JsonHelper
    {
    }
}
