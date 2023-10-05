using Microsoft.VisualStudio.TestTools.UnitTesting;
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
	public class TemplateTests
	{
		[TestMethod]
		public void ReadV2Template()
		{
			var path = Path.Combine("Data", "SWMaps_GPRS_Master.swmr");
			var reader = new TemplateReader(path);
			var template = reader.Read();

			var writer = new TemplateV2Writer(template);
			var outPath = Path.Combine("Data", "SWMaps_GPRS_Master_re.swmt");
			writer.WriteTemplate(outPath);
		}

		[TestMethod]
		public void ConvertV1ToV2()
		{
			var path = Path.Combine("Data", "SW_WSP_V3_Rural_Template.swmt");
			var reader = new TemplateReader(path);
			var template = reader.Read();

			var writer = new TemplateV2Writer(template);
			var outPath = Path.Combine("Data", "SW_WSP_V3_Rural_Template_V2.swmt");
			writer.WriteTemplate(outPath);
		}
	}
}
