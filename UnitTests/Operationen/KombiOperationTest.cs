using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Operationen
{
	[TestClass]
	public class KombiOperationTest
	{
		private Mock<Operation> _operation1Mock;
		private Mock<Operation> _operation2Mock;
		private Mock<Scorecard> _scorecardMock;

		[TestInitialize]
		public void Init()
		{
			_operation1Mock = new Mock<Operation>();
			_operation2Mock = new Mock<Operation>();
			_scorecardMock = new Mock<Scorecard>();
		}

		[TestMethod]
		public void TestSingleOperation()
		{
			var KombiOperation = new KombiOperation(_operation1Mock.Object);
			KombiOperation.FuehreAus(_scorecardMock.Object);
			_operation1Mock.Verify(operation => operation.FuehreAus(_scorecardMock.Object));
		}

		[TestMethod]
		public void TestMultipleOperations()
		{
			var KombiOperation = new KombiOperation(_operation1Mock.Object, _operation2Mock.Object);
			KombiOperation.FuehreAus(_scorecardMock.Object);
			_operation1Mock.Verify(operation => operation.FuehreAus(_scorecardMock.Object));
			_operation2Mock.Verify(operation => operation.FuehreAus(_scorecardMock.Object));
		}
	}
}
