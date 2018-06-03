using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PrivateObjectFrameworkTests.ImportantClassInFramework
{
	[TestClass]
	public class PrivateMethod
	{
		[TestMethod]
		public void TestPrivateMethodWithPrivateObject()
		{
			PrivateObject objToTestPrivateMethod = new PrivateObject(typeof(PrivateObjectFramework.ImportantClassInFramework));

			//Invoke the private method on the ImportantClass
			int result = Convert.ToInt32(objToTestPrivateMethod.Invoke("PrivateMethod", 2));

			Assert.AreEqual(result, 628);
		}
	}
}
