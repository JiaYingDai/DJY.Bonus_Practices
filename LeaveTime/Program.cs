using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveTime
{
	// 計算一天總請假時數
	// 每天上班時間9-18點，12-13點是休息時間
	public class Program
	{
		static void Main(string[] args)
		{
			//int start = 14;
			//int end = 19;

			Leave totalLeave = new Leave() { LeaveStart = 5, LeaveEnd = 23 };
			totalLeave.Message();
		}
	}

	public class Work
	{
		public int WorkStart { get; set; } // 上班時間
		public int WorkEnd { get; set; } // 下班時間
		public int BreakStart { get; set; } // 午休開始時間
		public int BreakEnd { get; set; } // 午休結束時間

		public Work()
        {
			WorkStart = 9;
			WorkEnd = 18;
			BreakStart = 12;
			BreakEnd = 13;
		}

    }

	public class Leave:Work
	{
		public int _leaveStart;
        public int LeaveStart // 請假起始時間
		{
			get
			{
				return _leaveStart;
			}
			set
			{
				if (value < WorkStart) // 請假起始時間 早於 上班時間
				{
					_leaveStart = WorkStart;
				}
				else if (value >= BreakStart && value < BreakEnd) // 請假起始時間 介於 午休時間
				{
					_leaveStart = BreakEnd;
				}
				else if (value >= WorkEnd) // 請假起始時間 晚於 下班時間
				{
					_leaveStart = -1;
				}
				else // 請假起始時間 不是 上班時間前 也不是 介於午休時間				
				{
					_leaveStart = value;
				}
			}
		}
		private int _leaveEnd;
		public int LeaveEnd // 請假結束時間
		{
			get
			{
				return _leaveEnd;
			}
			set
			{
				if (value > BreakStart && value <= BreakEnd) // 請假結束時間 介於 午休時間
				{
					_leaveEnd = BreakStart;
				}
				else if (value >= WorkEnd) // 請假結束時間 晚於 下班時間
				{
					_leaveEnd = WorkEnd;
				}
				else if (value <= LeaveStart)  // 請假結束時間 早於等於 請假開始時間
				{
					_leaveEnd = -1;
				}
				else
				{
					_leaveEnd = value;
				}
			}
		} 

		public int TotalLeave()
		{
			if ( LeaveStart < 0 || LeaveEnd < 0 )
			{
				return -1; // -1: 不符請假規則，錯誤
			}
			else
			{
				int span;
				if ((LeaveStart >= WorkStart && LeaveEnd <= BreakStart)  // 早上工作時間請假
					|| (LeaveStart >= BreakEnd && LeaveEnd <= WorkEnd)) // 下午工作時間請假
				{
					span = LeaveEnd - LeaveStart;
				}
				else
				{
					span = LeaveEnd - LeaveStart - (BreakEnd - BreakStart);
				}
				return span;
			}
		}

		public void Message()
		{
			string message = TotalLeave() >= 0 ?
				$"請假總時數為: {TotalLeave()}小時" : "錯誤，請重新輸入";

			Console.WriteLine(message);
		}

	}
}
