using System;

namespace FodySample
{
	class Sample
	{
		[Logger]
		public void Execute()
		{
			Console.WriteLine("Hello {0}!", GetVal());
		}

		[Logger]
		public string GetVal()
		{
			return "Fody";
		}
	}
}
