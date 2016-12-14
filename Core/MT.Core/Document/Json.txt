/**************JSON操作*********************/
请引用Newtonsoft.Json类库去操作JSON数据

1,序列号JSON字符串
string jsonStr = JsonConvert.SerializeObject(obj);
2，通过字符串反射对象
object obj = JsonConvert.DeserializeObject<object>(jsonStr);
3,拼接JSON对象推荐使用：JObject
4,拼接JSON数组推荐使用：JArray