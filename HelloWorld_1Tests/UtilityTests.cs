using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld_1;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_1.Tests
{
	[TestClass()]
	public class UtilityTests
	{
		[TestMethod()]
		public void ConvertTest()
		{
			// Arrange
			string input = "a";

			// Act
			var result = Utility.Convert(input);

			// Assert
			Assert.AreEqual("ConvertedA", result);
		}
	}
}