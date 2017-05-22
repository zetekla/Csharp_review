using System;
namespace derek_tut
{
	public class Vehicle : IDrivable
	{
		double IDrivable.Speed
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		int IDrivable.Wheels
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		void IDrivable.Move()
		{
			throw new NotImplementedException();
		}

		void IDrivable.Stop()
		{
			throw new NotImplementedException();
		}
	}
}
