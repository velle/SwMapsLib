using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwMapsLib.IO;
using System.IO;

namespace SwMapsLibTests
{
	[TestClass]
	public class SwMapsWriteTests
	{
		[TestMethod]
		public void WriteSwMapsV1()
		{
			var path = Path.Combine("Data", "30101001_con.swmaps");
			var reader = new SwMapsV1Reader(path);
			var project = reader.Read();

			var outPath = Path.Combine("Data", "SwMapsV1Test.swmaps");
			System.IO.File.Delete(outPath);
			var writer = new SwMapsV1Writer(project);
			writer.WriteSwmapsDb(outPath);

		}

		[TestMethod]
		public void WriteSwMapsV2()
		{
			var path = Path.Combine("Data", "30101001_con.swmaps");
			var reader = new SwMapsV1Reader(path);
			var project = reader.Read();

			var outPath = Path.Combine("Data", "SwMapsV2Test.swmaps");
			System.IO.File.Delete(outPath);
			var writer = new SwMapsV2Writer(project);
			writer.WriteSwmapsDb(outPath);

		}

		[TestMethod]
		public void WriteSwmz()
		{
			var path = Path.Combine("Data", "30101001_con.swmaps");
			var reader = new SwMapsV1Reader(path);
			var project = reader.Read();

			var outPath = Path.Combine("Data", "SwmzTest.swmz");
			System.IO.File.Delete(outPath);
			var writer = new SwmzWriter(project,2);
			writer.Write(outPath);
		}
	}
}
