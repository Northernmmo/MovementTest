using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonBehaviors.Actions;
using Styx;
using Styx.CommonBot;
using Styx.CommonBot.Coroutines;
using Styx.TreeSharp;
using Styx.WoWInternals.WoWObjects;

namespace MovementTest
{
	public class MovementTest : BotBase
	{
		#region Declerations & Overrides
		private static readonly LocalPlayer Me = StyxWoW.Me;
		private Composite _root;

		public override string Name { get { return "MovementTest"; } }
		public override PulseFlags PulseFlags { get { return PulseFlags.All; } }
		public override Composite Root { get { return _root ?? (_root = new ActionRunCoroutine(ret => RootLogic())); } }
		public override void OnSelected() { }
		#endregion

		public static async Task<bool> RootLogic()
		{
			await CommonCoroutines.SleepForLagDuration();
			return true;
		}
	}
}
