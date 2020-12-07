﻿using System;
using System.IO;
using System.Threading.Tasks;
using AoC2020.Solutions;

namespace AoC2020
{
	public class Program
	{
		public static async Task Main()
		{
			var input = await File
				.ReadAllTextAsync(Path.Join("Inputs", "07.txt"));

			new Day07(input).Solve();
			Console.ReadLine();
		}
	}
}
