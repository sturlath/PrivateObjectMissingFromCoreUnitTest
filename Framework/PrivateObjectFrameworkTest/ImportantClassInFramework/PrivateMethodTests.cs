using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PrivateObjectFrameworkTests.ImportantClassInFramework
{
	[TestClass]
	public class PrivateMethodTests
	{
		[TestMethod]
		public void TestPrivateMethodWithPrivateObject()
		{
			//Arrange
			PrivateObject objToTestPrivateMethod = new PrivateObject(typeof(PrivateObjectFramework.ImportantClassInFramework));

			//Act
			//Invoke the private method on the ImportantClass
			int result = Convert.ToInt32(objToTestPrivateMethod.Invoke("PrivateMethod", 2));

			//Assert
			Assert.AreEqual(result, 628);
		}
	}
}
