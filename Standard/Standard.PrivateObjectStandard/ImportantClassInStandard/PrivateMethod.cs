using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Standard.PrivateObjectStandardTests.ImportantClassInStandard
{
	[TestClass]
	public class PrivateMethod
	{
		[TestMethod]
		public void TestPrivateMethodWithPrivateObject()
		{
			Assert.Fail("PrivateObject is missing from MStest .net Core project!");
			
			//PrivateObject objToTestPrivateMethod = new PrivateObject(typeof(PrivateObjectStandard.ImportantClassInStandard));

			//Invoke the private method on the ImportantClass
			//int result = Convert.ToInt32(objToTestPrivateMethod.Invoke("PrivateMethod", 2));

			//Assert.AreEqual(result, 512);
		}
	}
}
