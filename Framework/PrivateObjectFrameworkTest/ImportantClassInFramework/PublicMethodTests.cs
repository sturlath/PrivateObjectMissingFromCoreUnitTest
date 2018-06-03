using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrivateObjectFrameworkTests.ImportantClassInFramework
{
	[TestClass]
	public class PublicMethodTests
	{
		[TestMethod]
		public void NormalPublicMethod()
		{
			//Arrange
			var i = new PrivateObjectFramework.ImportantClassInFramework();

			//Act
			var result = i.PublicMethod();
			
			//Assert
			Assert.AreEqual(result, 314);
		}
	}
}
