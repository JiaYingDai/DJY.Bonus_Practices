using Microsoft.VisualBasic;

namespace LeaveTime.test
{
	public class Tests
	{

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void �а�9_18�I()
		{
			int start = 9;
			int end = 18;
			int expected = 8;

			Leave leaveTime= new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void �а�9_17�I()
		{
			int start = 9;
			int end = 17;
			int expected = 7;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void �а�9_12�I()
		{
			int start = 9;
			int end = 12;
			int expected = 3;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void �а�9_13�I()
		{
			int start = 9;
			int end = 13;
			int expected = 3;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void �а�12_14�I()
		{
			int start = 12;
			int end = 14;
			int expected = 1;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void �а�8_18�I()
		{
			int start = 8;
			int end = 18;
			int expected = 8;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void �а�9_23�I()
		{
			int start = 9;
			int end = 23;
			int expected = 8;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}






	}
}