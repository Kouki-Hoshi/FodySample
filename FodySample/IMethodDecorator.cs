using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FodySample
{
	interface IMethodDecorator
	{
		void Init(object instance, MethodBase method, object[] args);

		void OnEntry();

		void OnExit();

		void OnException(Exception exception);
    }
}
