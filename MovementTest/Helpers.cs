using Styx;
using Styx.Common;
using Styx.CommonBot.Coroutines;
using Styx.Pathing;
using Styx.WoWInternals.WoWObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MovementTest
{
	class Helpers
	{
		private static string _lastMsg;
		private static readonly LocalPlayer Me = StyxWoW.Me;

		public static void Log(string msg)
		{
			if (msg == _lastMsg) return;
			Logging.Write(Colors.DeepPink, "[MT] " + msg);
			_lastMsg = msg;
		}

		public static async Task<bool> MoveTo(WoWPoint destination)
		{
			Log("Moving to destination");
			await CommonCoroutines.SleepForLagDuration();
			return false;
		}
	}
}
