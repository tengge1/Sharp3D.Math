using Sharp3D.Math.Geometry2D;
using Sharp3D.Math.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sharp3D.Math.Tests.Geometry2D
{
	/// <summary>
	///This is a test class for Sharp3D.Math.Geometry2D.Triangle and is intended
	///to contain all Sharp3D.Math.Geometry2D.Triangle Unit Tests
	///</summary>
	[TestClass()]
	public class TriangleTest
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
		///A test case for Ordering
		///</summary>
		[TestMethod()]
		public void OrderingTest()
		{
			Vector2F p0 = new Vector2F(0.0f, 0.0f); 
			Vector2F p1 = new Vector2F(1.0f, 0.0f);
			Vector2F p2 = new Vector2F(0.5f, 0.5f);

			Triangle target = new Triangle(p0, p1, p2);
			Ordering expected = Ordering.Counterclockwise;
			//Assert.AreEqual(expected, target.Ordering);

			p0 = new Vector2F(0.0f, 0.0f);
			p1 = new Vector2F(0.5f, 0.5f);
			p2 = new Vector2F(1.0f, 0.0f);
			target = new Triangle(p0, p1, p2);

			expected = Ordering.Clockwise;
			Assert.AreEqual(expected, target.Ordering);

			p1 = new Vector2F(0.5f, 0.0f);
			target = new Triangle(p0, p1, p2);
			expected = Ordering.None;
			Assert.AreEqual(expected, target.Ordering);
		}

		/// <summary>
		///A test case for GetArea ()
		///</summary>
		[TestMethod()]
		public void GetAreaTest()
		{
			Vector2F p0 = new Vector2F(0.0f, 0.0f);
			Vector2F p1 = new Vector2F(1.0f, 0.0f);
			Vector2F p2 = new Vector2F(0.5f, 0.5f);
			Triangle target = new Triangle(p0, p1, p2);

			float expected = 0.25f;
			float actual = target.GetArea();
			

			Assert.AreEqual(expected, actual);
		}
	}


}
