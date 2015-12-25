using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Compatibility;
using Assert = NUnit.Framework.Assert;

namespace LastNonDuplicate.Test
{
	[TestFixture]
	public class LastNonDuplicateFinderTests
	{
		private LastNonDuplicateFinder _SUT;
		[SetUp]
		public void BeforeEachTest()
		{
			_SUT = new LastNonDuplicateFinder();
        }

		[Test]
		public void Mime_Returns_E()
		{
			var result = _SUT.FindLastNonDuplicate("mime");
			Assert.That(result == 'e');
		}

		[Test]
		public void AllDuplicates_Returns_NullChar()
		{
			var result = _SUT.FindLastNonDuplicate("aabbcc");
			Assert.That(result == '\0');
		}

		[Test]
		public void NoDuplicates_Returns_LastChar()
		{
			var result = _SUT.FindLastNonDuplicate("abcde");
			Assert.That(result == 'e');
		}

		[Test]
		public void Null_Returns_NullString()
		{
			var result = _SUT.FindLastNonDuplicate(null);
			Assert.That(result == '\0');
		}

		[Test]
		public void EmptyString_Returns_NullString()
		{
			var result = _SUT.FindLastNonDuplicate("");
			Assert.That(result == '\0');
		}

		[Test]
		public void RunsIn_Linear_Time()
		{
			var regularString = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
			var longString = "";
			for (var i = 0; i < 1000; i++)
			{
				longString += regularString;
			}
			regularString = "b" + regularString;
			longString = "b" + longString;

			var regularStopWatch = new Stopwatch();
			regularStopWatch.Start();
			_SUT.FindLastNonDuplicate(regularString);
			regularStopWatch.Stop();

			var longStopWatch = new Stopwatch();
			longStopWatch.Start();
			_SUT.FindLastNonDuplicate(longString);
			longStopWatch.Stop();

			Assert.That(regularStopWatch.ElapsedTicks * 1001 > longStopWatch.ElapsedTicks);
		}
	}
}
