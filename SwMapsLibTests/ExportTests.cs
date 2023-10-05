using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwMapsLib.Conversions.KMZ;
using SwMapsLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SwMapsLibTests
{
	[TestClass]
	public class ExportTests
	{
		[TestMethod]
		public void ExportKmz()
		{
			var path = Path.Combine("Data", "TestSwmz.swmz");
			var project = new SwmzReader(path).Read();
			var exporter = new SwMapsKmzWriter(project);
			exporter.WriteKml(Path.Combine("Data", "TestSwmz.kml"));
			exporter.WriteKmz(Path.Combine("Data", "TestSwmz.kmz"));
		}
	}
}
