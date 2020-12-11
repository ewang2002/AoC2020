﻿#define GENERAL
using System;
using System.IO;
using System.Threading.Tasks;
#if !GENERAL
using AoC2020.RevisedSolutions;
#else
using AoC2020.Solutions;
#endif

namespace AoC2020
{
	public class Program
	{
		public static async Task Main()
		{
			var input = await File
				.ReadAllTextAsync(Path.Join("Inputs", "11.txt"));

#if GENERAL
			new Day11(input).Solve();
#else
			new Day11Revised(input).Solve();
#endif
			Console.ReadLine();
		}
	}
}