using Sharp3D.Math.Geometry2D;
using Sharp3D.Math.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sharp3D.Math.Tests.Geometry2D
{
	/// <summary>
	///This is a test class for Sharp3D.Math.Geometry2D.Circle and is intended
	///to contain all Sharp3D.Math.Geometry2D.Circle Unit Tests
	///</summary>
	[TestClass()]
	public class CircleTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public virtual TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		/// <summary>
		///Initialize() is called once during test execution before
		///test methods in this test class are executed.
		///</summary>
		[TestInitialize()]
		public virtual void Initialize()
		{
			//  TODO: Add test initialization code
		}

		/// <summary>
		///Cleanup() is called once during test execution after
		///test methods in this class have executed unless
		///this test class' Initialize() method throws an exception.
		///</summary>
		[TestCleanup()]
		public virtual void Cleanup()
		{
			//  TODO: Add test cleanup code
		}


		/// <summary>
		///A test case for GetArea ()
		///</summary>
		[TestMethod()]
		public void GetAreaTest()
		{
			Vector2F center = Vector2F.Zero;
			float radius = 2.0f; 

			Circle target = new Circle(center, radius);

			float expected = 4.0f*(float)System.Math.PI;
			float actual = target.GetArea();

			Assert.AreEqual(expected, actual, "Sharp3D.Math.Geometry2D.Circle.GetArea did not return the expected value.");
		}

	}


}
