using System;
using System.Collections.Generic;
using System.Text;

namespace classTesk_lssn_5
{
    class Car
    {
		private int speed;

		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}

		public int GetFester(int newSpeed)
		{
			for (int i = 0; i < newSpeed; i++)
			{
				Speed++;
			}
			return Speed;
		}

		public int GetSlower(int newSpeed)
		{
			for (int i = 0; i < newSpeed; i++)
			{
				Speed--;
			}
			return Speed;
		}

		public string Print()
		{
			return $"your spead was : {Speed}";
		}

		public string Stop()
		{
			return $"you stopted and your spead was : {Speed}";
		}

	}
}
