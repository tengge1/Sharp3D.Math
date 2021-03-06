using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sharp3D.Math.Core;
using System.ComponentModel;

// The following code was generated by Microsoft Test Code
//  Generation V1.0. The test owner should check each test
//  for validity.

namespace Sharp3D.Math.Core.Tests
{
	/// <summary>
	/// This is a test class for Vector4D and is intended
	/// to contain all Vector4D Unit Tests
	/// </summary>
	[TestClass()]
	public class Vector4DTest
	{
		#region Initialization\Cleanup
		/// <summary>
		/// Initialize() is called once during test execution before
		/// test methods in this test class are executed.
		/// </summary>
		[TestInitialize()]
		public void Initialize()
		{
			//  TODO: Add test initialization code
		}

		/// <summary>
		/// Cleanup() is called once during test execution after
		/// test methods in this class have executed unless
		/// this test class' Initialize() method throws an exception.
		/// </summary>
		[TestCleanup()]
		public void Cleanup()
		{
			//  TODO: Add test cleanup code
		}
		#endregion

		private TestContext m_testContext = null;
		public TestContext TestContext
		{
			get { return m_testContext; }
			set { m_testContext = value; }
		}

		#region Constructors Tests
		/// <summary>
		/// ConstructorTest is a test case for Vector4D (double, double, double, double)
		/// </summary>
		[TestMethod()]
		public void ConstructorTest()
		{
			double x = 1;
			double y = 2;
			double z = 3;
			double w = 4;

			Sharp3D.Math.Core.Vector4D target = new Sharp3D.Math.Core.Vector4D(x, y, z, w);

			Assert.AreEqual(x, target.X);
			Assert.AreEqual(y, target.Y);
			Assert.AreEqual(z, target.Z);
			Assert.AreEqual(w, target.W);
		}

		/// <summary>
		/// ConstructorTest1 is a test case for Vector4D (double[])
		/// </summary>
		[TestMethod()]
		public void ConstructorTest1()
		{
			double[] coordinates = new double[4] { 1, 2, 3, 4 };

			Sharp3D.Math.Core.Vector4D target = new Sharp3D.Math.Core.Vector4D(coordinates);

			Assert.AreEqual(coordinates[0], target.X);
			Assert.AreEqual(coordinates[1], target.Y);
			Assert.AreEqual(coordinates[2], target.Z);
			Assert.AreEqual(coordinates[3], target.W);
		}

		/// <summary>
		/// ConstructorTest2 is a test case for Vector4D (Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void ConstructorTest2()
		{
			Sharp3D.Math.Core.Vector4D vector = new Sharp3D.Math.Core.Vector4D(1,2,3,4);
			Sharp3D.Math.Core.Vector4D target = new Sharp3D.Math.Core.Vector4D(vector);

			Assert.AreEqual(vector.X, target.X);
			Assert.AreEqual(vector.Y, target.Y);
			Assert.AreEqual(vector.Z, target.Z);
			Assert.AreEqual(vector.W, target.W);
		}
		#endregion

		#region Public Properties Tests
		/// <summary>
		/// XTest is a test case for X
		/// </summary>
		[TestMethod()]
		public void XTest()
		{
			Sharp3D.Math.Core.Vector4D target = Sharp3D.Math.Core.Vector4D.Zero;

			double val = 3.14;
			target.X = val;

			Assert.AreEqual(val, target.X);
		}

		/// <summary>
		/// YTest is a test case for Y
		/// </summary>
		[TestMethod()]
		public void YTest()
		{
			Sharp3D.Math.Core.Vector4D target = Sharp3D.Math.Core.Vector4D.Zero;

			double val = 3.14;
			target.Y = val;

			Assert.AreEqual(val, target.Y);
		}

		/// <summary>
		/// ZTest is a test case for Z
		/// </summary>
		[TestMethod()]
		public void ZTest()
		{
			Sharp3D.Math.Core.Vector4D target = Sharp3D.Math.Core.Vector4D.Zero;

			double val = 3.14;
			target.Z = val;

			Assert.AreEqual(val, target.Z);
		}
		/// <summary>
		/// WTest is a test case for W
		/// </summary>
		[TestMethod()]
		public void WTest()
		{
			Sharp3D.Math.Core.Vector4D target = Sharp3D.Math.Core.Vector4D.Zero;

			double val = 3.14;
			target.W = val;

			Assert.AreEqual(val, target.W);
		}
		#endregion

		#region ICloneable test
		/// <summary>
		/// CloneTest is a test case for Clone ()
		/// </summary>
		[TestMethod()]
		public void CloneTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D actual;

			actual = vector.Clone();
			Assert.AreEqual(vector.X, actual.X);
			Assert.AreEqual(vector.Y, actual.Y);
			Assert.AreEqual(vector.Z, actual.Z);
			Assert.AreEqual(vector.W, actual.W);
		}
		#endregion

		#region Public Static Parse Methods Tests
		/// <summary>
		/// ParseTest is a test case for Parse (string)
		/// </summary>
		[TestMethod()]
		public void ParseTest()
		{
			string value;
			Sharp3D.Math.Core.Vector4D expected = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D actual;

			value = "(1,2,3,4)";
			actual = Sharp3D.Math.Core.Vector4D.Parse(value);
			Assert.AreEqual(expected, actual);

			value = "( 1,  2 , 3 , 4  )";
			actual = Sharp3D.Math.Core.Vector4D.Parse(value);
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// ParseTest is a test case for Parse (string)
		/// Verifies the exception thrown when illegal input is given.
		/// </summary>
		[TestMethod()]
		[ExpectedException(typeof(Sharp3D.Math.Core.ParseException))]
		public void ParseExceptionTest()
		{
			Sharp3D.Math.Core.Vector4D.Parse("[1,2,3,4]");
		}
		/// <summary>
		/// TryParseTest is a test case for TryParse (string, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void TryParseTest()
		{
			string value = "(1,2,3,4)";
			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;

			Vector4D expectedResult = new Vector4D(1, 2, 3, 4);
			bool expected = true;
			bool actual;

			actual = Sharp3D.Math.Core.Vector4D.TryParse(value, out result);
			Assert.AreEqual(expected, actual);
			Assert.AreEqual(expectedResult, result);
		}
		[TestMethod()]
		public void TryParseFailTest()
		{
			string value = "[1,2,3,4)";
			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;

			Vector4D expectedResult = Vector4D.Zero;
			bool expected = false;
			bool actual;

			actual = Sharp3D.Math.Core.Vector4D.TryParse(value, out result);
			Assert.AreEqual(expected, actual);
			Assert.AreEqual(expectedResult, result);
		}
		#endregion

		#region Public Methods Tests
		/// <summary>
		/// GetLengthTest is a test case for GetLength ()
		/// </summary>
		[TestMethod()]
		public void GetLengthTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);

			double expected = System.Math.Sqrt(30);
			double actual;

			actual = vector.GetLength();
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// GetLengthSquaredTest is a test case for GetLengthSquared ()
		/// </summary>
		[TestMethod()]
		public void GetLengthSquaredTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);

			double expected = 30;
			double actual;

			actual = vector.GetLengthSquared();
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// NormalizeTest is a test case for Normalize ()
		/// </summary>
		[TestMethod()]
		public void NormalizeTest()
		{
			Sharp3D.Math.Core.Vector4D target = new Vector4D(10, 20, 30, 40);

			target.Normalize();

			bool expected = true;
			bool actual = MathFunctions.ApproxEquals(target.GetLength(), 1.0);

			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// NormalizeExceptionTest is a test case for Normalize() where the vector length is zero.
		/// </summary>
		[TestMethod()]
		[ExpectedException(typeof(System.DivideByZeroException))]
		public void NormalizeExceptionTest()
		{
			Vector4D vector = Vector4D.Zero;
			vector.Normalize();
		}
		/// <summary>
		/// ClampZeroTest is a test case for ClampZero ()
		/// </summary>
		[TestMethod()]
		public void ClampZeroTest()
		{
			double tolerance = MathFunctions.EpsilonD;
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(tolerance / 3, tolerance / 2, 1.5, 2.0);
			Sharp3D.Math.Core.Vector4D expected = new Vector4D(0.0, 0.0, 1.5, 2.0);

			vector.ClampZero();

			Assert.AreEqual(vector, expected);
		}

		/// <summary>
		/// ClampZeroTest1 is a test case for ClampZero (double)
		/// </summary>
		[TestMethod()]
		public void ClampZeroTest1()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(0.5, 0.9, 1.5, 2.0);
			Sharp3D.Math.Core.Vector4D expected = new Vector4D(0.0, 0.0, 1.5, 2.0);
			double tolerance = 1.0;

			vector.ClampZero(tolerance);

			Assert.AreEqual(vector, expected);
		}
		#endregion

		#region System.Object Overrides Tests
		/// <summary>
		/// EqualsTest is a test case for Equals (object)
		/// </summary>
		[TestMethod()]
		public void EqualsTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D target = new Sharp3D.Math.Core.Vector4D(vector);

			bool expected = true;
			bool actual;

			actual = target.Equals(vector);
			Assert.AreEqual(expected, actual, vector.ToString() + " should be equal to " + target.ToString());

			expected = false;
			vector.X = 10;
			actual = target.Equals(vector);
			Assert.AreEqual(expected, actual, vector.ToString() + " should not be equal to " + target.ToString());
		}
		/// <summary>
		/// ToStringTest is a test case for ToString ()
		/// </summary>
		[TestMethod()]
		public void ToStringTest()
		{
			Sharp3D.Math.Core.Vector4D target = new Vector4D(1, 2, 3, 4);

			string expected = "(1, 2, 3, 4)";
			string actual;

			actual = target.ToString();
			Assert.AreEqual(expected, actual);
		}
		#endregion

		#region Public Static Vector Arithmetics Tests
		/// <summary>
		/// AddVectorScalarResultTest is a test case for Add (Sharp3D.Math.Core.Vector4D, double, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void AddVectorScalarResultTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Sharp3D.Math.Core.Vector4D(1, 2, 3, 4);
			double scalar = 1;
			Sharp3D.Math.Core.Vector4D expected = new Sharp3D.Math.Core.Vector4D(2, 3, 4, 5);
			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;

			Sharp3D.Math.Core.Vector4D.Add(vector, scalar, ref result);

			Assert.AreEqual(expected, result);
		}
		/// <summary>
		/// AddVectorVectorResultTest is a test case for Add (Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void AddVectorVectorResultTest()
		{
			Sharp3D.Math.Core.Vector4D left = new Sharp3D.Math.Core.Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D right = new Sharp3D.Math.Core.Vector4D(4, 3, 2, 1);
			Sharp3D.Math.Core.Vector4D expected = new Sharp3D.Math.Core.Vector4D(5, 5, 5, 5);

			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;

			Sharp3D.Math.Core.Vector4D.Add(left, right, ref result);
			Assert.AreEqual(expected, result);
		}
		/// <summary>
		/// SubtractScalarVectorTest is a test case for Subtract (double, Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void SubtractScalarVectorTest()
		{
			double scalar = 10.0;
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(9, 8, 7, 6);
			Sharp3D.Math.Core.Vector4D expected = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;

			Sharp3D.Math.Core.Vector4D.Subtract(scalar, vector, ref result);
			Assert.AreEqual(expected, result);
		}
		/// <summary>
		/// SubtractVectorScalarTest is a test case for Subtract (Sharp3D.Math.Core.Vector4D, double, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void SubtractVectorScalarTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);
			double scalar = 1.0;
			Sharp3D.Math.Core.Vector4D expected = new Vector4D(0, 1, 2, 3);
			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;

			Sharp3D.Math.Core.Vector4D.Subtract(vector, scalar, ref result);
			Assert.AreEqual(expected, result);
		}
		/// <summary>
		/// SubtractVectorVectorTest is a test case for Subtract (Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void SubtractVectorVectorTest()
		{
			Sharp3D.Math.Core.Vector4D left = new Vector4D(11, 12, 13, 14);
			Sharp3D.Math.Core.Vector4D right = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D expected = new Vector4D(10, 10, 10, 10);

			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;

			Sharp3D.Math.Core.Vector4D.Subtract(left, right, ref result);
			Assert.AreEqual(expected, result);
		}
		/// <summary>
		/// DivideScalarVectorResultTest is a test case for Divide (double, Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void DivideScalarVectorResultTest()
		{
			double scalar = 24.0;
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(2, 3, 6, 8);
			Sharp3D.Math.Core.Vector4D expected = new Vector4D(12, 8, 4, 3);

			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;

			Sharp3D.Math.Core.Vector4D.Divide(scalar, vector, ref result);
			Assert.AreEqual(expected, result);
		}
		/// <summary>
		/// DivideVectorScalarResultTest is a test case for Divide (Sharp3D.Math.Core.Vector4D, double, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void DivideVectorScalarResultTest()
		{
			double scalar = 2.0;
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(2, 4, 6, 8);
			Sharp3D.Math.Core.Vector4D expected = new Vector4D(1, 2, 3, 4);

			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;
			Sharp3D.Math.Core.Vector4D.Divide(vector, scalar, ref result);

			Assert.AreEqual(expected, result);
		}
		/// <summary>
		/// DivideVectorVectorTest is a test case for Divide (Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void DivideVectorVectorTest()
		{
			Sharp3D.Math.Core.Vector4D left = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D right = new Vector4D(2, 4, 6, 8);

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(0.5, 0.5, 0.5, 0.5);
			Sharp3D.Math.Core.Vector4D actual;

			actual = Sharp3D.Math.Core.Vector4D.Divide(left, right);
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// DivideVectorVectorResultTest is a test case for Divide (Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void DivideVectorVectorResultTest()
		{
			Sharp3D.Math.Core.Vector4D left = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D right = new Vector4D(2, 4, 6, 8);
			Sharp3D.Math.Core.Vector4D expected = new Vector4D(0.5, 0.5, 0.5, 0.5);

			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;
			Sharp3D.Math.Core.Vector4D.Divide(left, right, ref result);
			Assert.AreEqual(expected, result);
		}
		/// <summary>
		/// MultiplyVectorScalarTest is a test case for Multiply (Sharp3D.Math.Core.Vector4D, double, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void MultiplyVectorScalarTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);
			double scalar = 2;
			Sharp3D.Math.Core.Vector4D expected = new Vector4D(2, 4, 6, 8);

			Sharp3D.Math.Core.Vector4D result = Vector4D.Zero;
			Sharp3D.Math.Core.Vector4D.Multiply(vector, scalar, ref result);

			Assert.AreEqual(expected, result);
		}
		/// <summary>
		/// ApproxEqualTest is a test case for ApproxEqual (Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void ApproxEqualTest()
		{
			Sharp3D.Math.Core.Vector4D left = new Sharp3D.Math.Core.Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D right = left + MathFunctions.EpsilonD;

			bool expected = true;
			bool actual;

			actual = Sharp3D.Math.Core.Vector4D.ApproxEqual(left, right);
			Assert.AreEqual(expected, actual);

			right = right + MathFunctions.EpsilonD;
			expected = false;

			actual = Sharp3D.Math.Core.Vector4D.ApproxEqual(left, right);
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// ApproxEqualTest1 is a test case for ApproxEqual (Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D, double)
		/// </summary>
		[TestMethod()]
		public void ApproxEqualTest1()
		{
			Sharp3D.Math.Core.Vector4D left = new Sharp3D.Math.Core.Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D right = new Sharp3D.Math.Core.Vector4D(1.09, 2.09, 3.09, 4.09);
			double tolerance = 0.1;

			bool expected = true;
			bool actual;

			actual = Sharp3D.Math.Core.Vector4D.ApproxEqual(left, right, tolerance);
			Assert.AreEqual(expected, actual);

			right = new Sharp3D.Math.Core.Vector4D(1.2, 2.2, 3.2, 4.2);
			expected = false;

			actual = Sharp3D.Math.Core.Vector4D.ApproxEqual(left, right, tolerance);
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// DotProductTest is a test case for DotProduct (Sharp3D.Math.Core.Vector4D, Sharp3D.Math.Core.Vector4D)
		/// </summary>
		[TestMethod()]
		public void DotProductTest()
		{
			Sharp3D.Math.Core.Vector4D left = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D right = new Vector4D(4, 3, 2, 1);

			double expected = 20;
			double actual;

			actual = Sharp3D.Math.Core.Vector4D.DotProduct(left, right);
			Assert.AreEqual(expected, actual);
		}
		#endregion

		#region Unary Operators Tests
		/// <summary>
		/// NegativeTest is a test case for operator -
		/// </summary>
		[TestMethod()]
		public void NegativeTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(-1, -2, -3, -4);
			Sharp3D.Math.Core.Vector4D actual;

			actual = -vector;
			Assert.AreEqual(expected, actual);
		}
		#endregion

		#region Binary Operators Tests
		/// <summary>
		/// AddTest4 is a test case for operator +
		/// </summary>
		[TestMethod()]
		public void AddOpVectorScalarTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);
			double scalar = 1.0;

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(2, 3, 4, 5);
			Sharp3D.Math.Core.Vector4D actual;

			actual = vector + scalar;
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// AddTest5 is a test case for operator +
		/// </summary>
		[TestMethod()]
		public void AddOpVectorVectorTest()
		{
			Sharp3D.Math.Core.Vector4D left = new Sharp3D.Math.Core.Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D right = new Sharp3D.Math.Core.Vector4D(4, 3, 2, 1);

			Sharp3D.Math.Core.Vector4D expected = new Sharp3D.Math.Core.Vector4D(5, 5, 5, 5);
			Sharp3D.Math.Core.Vector4D actual;

			actual = left + right;
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// AddTest6 is a test case for operator +
		/// </summary>
		[TestMethod()]
		public void AddOpScalarVectorTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);
			double scalar = 1.0;

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(2, 3, 4, 5);
			Sharp3D.Math.Core.Vector4D actual;

			actual = scalar + vector;
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// SubtractTest is a test case for operator -
		/// </summary>
		[TestMethod()]
		public void SubtractOpVectorScalarTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);
			double scalar = 1.0;

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(0, 1, 2, 3);
			Sharp3D.Math.Core.Vector4D actual;

			actual = vector - scalar;
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// SubtractTest1 is a test case for operator -
		/// </summary>
		[TestMethod()]
		public void SubtractOpScalarVectorTest()
		{
			double scalar = 10;
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(9, 8, 7, 6);

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D actual;

			actual = scalar - vector;
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// SubtractTest2 is a test case for operator -
		/// </summary>
		[TestMethod()]
		public void SubtractOpVectorVectorTest()
		{
			Sharp3D.Math.Core.Vector4D left = new Vector4D(10, 10, 10, 10);
			Sharp3D.Math.Core.Vector4D right = new Vector4D(9, 8, 7, 6);

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D actual;

			actual = left - right;
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// MultiplyTest2 is a test case for operator *
		/// </summary>
		[TestMethod()]
		public void MultiplyOpVectorScalarTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);
			double scalar = 2;

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(2, 4, 6, 8);
			Sharp3D.Math.Core.Vector4D actual;

			actual = vector * scalar;
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// MultiplyTest3 is a test case for operator *
		/// </summary>
		[TestMethod()]
		public void MultiplyOpScalarVectorTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(1, 2, 3, 4);
			double scalar = 2;

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(2, 4, 6, 8);
			Sharp3D.Math.Core.Vector4D actual;

			actual = scalar * vector;
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// DivideTest6 is a test case for operator /
		/// </summary>
		[TestMethod()]
		public void DivideScalarVectorTest()
		{
			double scalar = 24.0;
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(2, 3, 6, 8);

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(12, 8, 4, 3);
			Sharp3D.Math.Core.Vector4D actual;

			actual = scalar / vector;
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// DivideTest7 is a test case for operator /
		/// </summary>
		[TestMethod()]
		public void DivideVectorScalarTest()
		{
			Sharp3D.Math.Core.Vector4D vector = new Vector4D(2, 4, 6, 8);
			double scalar = 2.0;

			Sharp3D.Math.Core.Vector4D expected = new Vector4D(1, 2, 3, 4);
			Sharp3D.Math.Core.Vector4D actual;

			actual = vector / scalar;
			Assert.AreEqual(expected, actual);
		}
		#endregion

		#region Index Operator Tests
		/// <summary>
		/// ItemTest is a test case for this[int index]
		/// </summary>
		[TestMethod()]
		public void ItemTest()
		{
			Sharp3D.Math.Core.Vector4D target = new Vector4D(1, 2, 3, 4);

			Assert.AreEqual(target.X, target[0]);
			Assert.AreEqual(target.Y, target[1]);
			Assert.AreEqual(target.Z, target[2]);
			Assert.AreEqual(target.W, target[3]);
		}
		[TestMethod()]
		[ExpectedException(typeof(System.IndexOutOfRangeException))]
		public void ItemTest1()
		{
			Vector4D vector = new Vector4D(1, 2, 3, 4);
			vector[4]++;
		}
		#endregion
	}
}
