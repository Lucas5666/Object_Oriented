using System;
using System.Reflection;
using System.Text;

namespace JsonHelper
{
	public class JsonHelper
	{
		//{"ID":"1","LoginId":"Cai"}
		public static string ObjectToJson(Object obj)
		{
			Type t = obj.GetType();//获取类型
			PropertyInfo[] AllProperty = t.GetProperties();//获取所以属性

			StringBuilder sb = new StringBuilder();

			sb.Append("{");
			foreach (var item in AllProperty)
			{
				sb.AppendFormat("\"{0}\":\"{1}\",", item.Name, item.GetValue(obj));
			}
			sb.Remove(sb.Length - 1, 1);
			sb.Append("}");

			return sb.ToString();
		}

        //{"ID":"1","LoginId":"Cai"}
        public static T JsonToObject<T>(string json) where T : new()
		{
			//Type t = typeof(T);
			//T obj = (T)Activator.CreateInstance(t);

			T instance = new T();
			Type type = instance.GetType();

            json = json.Replace("\"", string.Empty).Replace("{", string.Empty).Replace("}", string.Empty);
			string[] KeyValue = json.Split(':', ',');

			for (int i = 0; i < KeyValue.Length; i += 2)
			{
				PropertyInfo p = type.GetProperty(KeyValue[i]);

                object value = Convert.ChangeType(KeyValue[i + 1],p.PropertyType);
				p.SetValue(instance, value);

            }
			return instance;
		}
	}
}

