using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Autofixture1242Repro
{
	public interface IPartial { }
	public abstract class OrderCloudModel
	{
		internal Dictionary<string, object> Props { get; set; } = new Dictionary<string, object>();
		protected T GetProp<T>(string name) {
			return Props.TryGetValue(name, out object value) ? (T)value : default(T);
		}
		protected T GetProp<T>(string name, T defaultValue)
		{
			if (Props.TryGetValue(name, out object value))
				return (T)value;

			if (this is IPartial)
				return default(T);
			else
			{
				SetProp(name, defaultValue);
				return defaultValue;
			}
		}
		protected void SetProp<T>(string name, T value) {
			Props[name] = value;
		}
	}

	public class Order : OrderCloudModel
	{
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	public class Order<Txp> : Order
	{
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
}
