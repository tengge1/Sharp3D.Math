using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sharp3D.Math.Core;
using Sharp3D.Math.Analysis;

namespace Sharp3D.Math.Analysis.Tests
{
	/// <summary>
	/// This is a test class for TrapezoidIntegral and is intended
	/// to contain all TrapezoidIntegral Unit Tests
	/// </summary>
	[TestClass()]
	public class IntegrationTest
	{
		#region Initialize\Cleanup
		/// <summary>
		/// Initialize() is called once during test execution before
		/// test methods in this test class are executed.
		/// </summary>
		[TestInitialize()]
		public void Initialize()
		{
		}

		/// <summary>
		/// Cleanup() is called once during test execution after
		/// test methods in this class have executed unless
		/// this test class' Initialize() method throws an exception.
		/// </summary>
		[TestCleanup()]
		public void Cleanup()
		{
		}
		#endregion

		#region Test Context
		private TestContext m_testContext = null;
		public TestContext TestContext
		{
			get { return m_testContext; }
			set { m_testContext = value; }
		}
		#endregion

		/// <summary>
		/// IntegrateTest is a test case for Integrate (Sharp3D.Math.Core.MathFunctions.UnaryFunction<double>, double, double)
		/// </summary>
		[TestMethod()]
		public void TrapezoidDefaultTest()
		{
			TrapezoidIntegral target = new Sharp3D.Math.Analysis.TrapezoidIntegral();
			target.IntegrationMethod = TrapezoidIntegral.Method.Default;
			DoDoublePrecisionTests(target, target.Accuracy);
		}
		[TestMethod()]
		public void TrapezoidMidpointTest()
		{
			TrapezoidIntegral target = new Sharp3D.Math.Analysis.TrapezoidIntegral();
			target.IntegrationMethod = TrapezoidIntegral.Method.MidPoint;
			DoDoublePrecisionTests(target, target.Accuracy);
		}

		#region Private Helper Methods
		public double fx(double x)
		{
			return x;
		}
		public double sqrx(double x)
		{
			return x * x;
		}

		private void TestSingleIntegration(
			IDoubleIntegrator integrator,
			MathFunctions.UnaryFunction<double> f, double a, double b,
			double expected, double accuracy)
		{
			double actual = integrator.Integrate(f, a, b);
			Assert.IsTrue(MathFunctions.ApproxEquals(expected, actual, accuracy));
		}
		private void DoDoublePrecisionTests(IDoubleIntegrator integrator, double accuracy)
		{
			Sharp3D.Math.Core.MathFunctions.UnaryFunction<double> f = null;

			// Test against a constant function
			f = new Sharp3D.Math.Core.MathFunctions.UnaryFunction<double>(delegate { return 1.0; });
			TestSingleIntegration(integrator, f, 0.0, 1.0, 1.0, accuracy);

			// Test f(x) = x
			f = new Sharp3D.Math.Core.MathFunctions.UnaryFunction<double>(fx);
			TestSingleIntegration(integrator, f, 0.0, 1.0, 0.5, accuracy);

			// Test f(x) = x^2
			f = new Sharp3D.Math.Core.MathFunctions.UnaryFunction<double>(sqrx);
			TestSingleIntegration(integrator, f, 0.0, 1.0, 1.0 / 3.0, accuracy);

			// Test f(x) = sin(x)
			f = MathFunctions.DoubleSinFunction;
			TestSingleIntegration(integrator, f, -MathFunctions.HalfPI, MathFunctions.HalfPI, 0.0, accuracy);

			// Test f(x) = cos(x)
			f = MathFunctions.DoubleCosFunction;
			TestSingleIntegration(integrator, f, 0.0, MathFunctions.PI, 0.0, accuracy);
		}
		#endregion
	}
}
