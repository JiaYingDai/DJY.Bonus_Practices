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
		public void 叫安9_18翴()
		{
			int start = 9;
			int end = 18;
			int expected = 8;

			Leave leaveTime= new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void 叫安9_17翴()
		{
			int start = 9;
			int end = 17;
			int expected = 7;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void 叫安9_12翴()
		{
			int start = 9;
			int end = 12;
			int expected = 3;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void 叫安9_13翴()
		{
			int start = 9;
			int end = 13;
			int expected = 3;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void 叫安12_14翴()
		{
			int start = 12;
			int end = 14;
			int expected = 1;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void 叫安8_18翴()
		{
			int start = 8;
			int end = 18;
			int expected = 8;

			Leave leaveTime = new Leave() { LeaveStart = start, LeaveEnd = end };
			int actual = leaveTime.TotalLeave();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void 叫安9_23翴()
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