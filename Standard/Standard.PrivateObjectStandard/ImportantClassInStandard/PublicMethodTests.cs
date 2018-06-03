using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Standard.PrivateObjectStandardTests.ImportantClassInStandard
{
	[TestClass]
	public class PublicMethodTests
	{
		[TestMethod]
		public void NormalPublicMethod()
		{
			//Arrange
			var i = new PrivateObjectStandard.ImportantClassInStandard();

			//Act
			var result = i.PublicMethod();
			
			//Assert
			Assert.AreEqual(result, 256);
		}
	}
}
