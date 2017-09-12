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
	public class DistanceMethodsTest
	{
		#region Test Context
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
		#endregion

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
		/// A test case for Point-Point distance method
		/// </summary>
		[TestMethod()]
		public void PointPointDistance()
		{
			Vector2F p0 = new Vector2F(0, 0);
			Vector2F p1 = new Vector2F(1, 1);

			float expected = (float)System.Math.Sqrt(2);
			float actual = DistanceMethods.Distance(p0, p1);

			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// A test case for Point-Segment distance method.
		/// </summary>
		[TestMethod()]
		public void PointSegmentDistance()
		{
			Vector2F p;
			Vector2F start;
			Vector2F end;
			Segment s;
			float expected;
			float actual;

			// Start point is the closest
			p = new Vector2F(0, 0);
			start = new Vector2F(1, 0);
			end = new Vector2F(1, 1);
			s = new Segment(start, end);

			expected = 1.0f;
			actual = DistanceMethods.Distance(p, s);
			Assert.AreEqual(expected, actual);

			// End point is the closest
			p = new Vector2F(1, 3);
			expected = 2.0f;
			actual = DistanceMethods.Distance(p, s);
			Assert.AreEqual(expected, actual);

			// Closest ppoint is inside the segment
			p = new Vector2F(0.5f, 0.5f);
			expected = 0.5f;
			actual = DistanceMethods.Distance(p, s);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void PointRayDistance()
		{
			Vector2F p;
			Ray r = new Ray(Vector2F.Zero, new Vector2F(1, 1));
			float expected, actual;

			// Point is closest to somewhere on the ray
			p = new Vector2F(0, 4);
			expected = (float)System.Math.Sqrt(8);
			actual = DistanceMethods.Distance(p, r);
			Assert.AreEqual(expected, actual);

			// Point is closest to origin
			p = new Vector2F(-1, -1);
			expected = (float)System.Math.Sqrt(2);
			actual = DistanceMethods.Distance(p, r);
			Assert.AreEqual(expected, actual);
		}
	}


}
