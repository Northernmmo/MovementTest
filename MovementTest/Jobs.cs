using Styx;
using Styx.WoWInternals.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementTest
{
	class SubTask
	{
		public SubTask(string name)
		{
			Name = name;
		}
		public string Name { get; set; }
	}

	class Jobs
	{
		public static List<Job> MyJobs = new List<Job>();
		private static int CurrentJobIndex;

		public static void NextJob()
		{
			CurrentJobIndex++;
		}

		public static Job CurrentJob()
		{
			return MyJobs[CurrentJobIndex];
		}
	}

	class Job
	{
		public Job(string name, WoWPoint location, int shipmentCrateEntry, int workOrderNpcEntry, int professionNpcEntry, List<SubTask> subTasks)
		{
			Name = name;
			Location = location;
			ShipmentCrateEntry = shipmentCrateEntry;
			WorkOrderNpcEntry = workOrderNpcEntry;
			ProfessionNpcEntry = professionNpcEntry;
			SubTasks = subTasks;
		}

		public string Name { get; set; }
		public WoWPoint Location { get; set; }
		public int ShipmentCrateEntry { get; set; }
		public int WorkOrderNpcEntry { get; set; }
		public int ProfessionNpcEntry { get; set; }
		public List<SubTask> SubTasks { get; set; }
	}
}
