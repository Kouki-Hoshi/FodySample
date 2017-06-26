using System;
using System.Reflection;

[module: FodySample.Logger]
namespace FodySample
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Assembly | AttributeTargets.Module)]
	public class Logger : Attribute, IMethodDecorator
	{
		private object instance;
		private MethodBase method;
		private object[] args;

		public virtual void Init(object instance, MethodBase method, object[] args)
		{
			this.instance = instance;
			this.method = method;
			this.args = args;
		}

		public void OnEntry()
		{
			Console.WriteLine("OnEntry {0}", method.Name);
		}

		public void OnExit()
		{
			Console.WriteLine("OnExit {0}", method.Name);
		}

		public void OnException(Exception exception)
		{
		}
	}
}
