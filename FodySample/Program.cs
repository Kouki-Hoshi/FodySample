﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodySample
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Start Main");

			new Sample().Execute();

			Console.WriteLine("End Main");
			Console.Read();
		}
	}
}
