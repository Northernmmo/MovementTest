using Styx;
using Styx.WoWInternals.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementTest
{
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
		public Job(GarrisonBuildingType building, WoWPoint location, int shipmentCrateEntry, int workOrderNpcEntry, int professionNpcEntry, bool alreadyMoved, bool needToPickupShipments, bool needToStartWorkOrders)
		{
			Building = building;
			Location = location;
			ShipmentCrateEntry = shipmentCrateEntry;
			WorkOrderNpcEntry = workOrderNpcEntry;
			ProfessionNpcEntry = professionNpcEntry;
			AlreadyMoved = alreadyMoved;
			NeedToPickupShipments = needToPickupShipments;
			NeedToStartWorkOrders = needToStartWorkOrders;
		}

		public GarrisonBuildingType Building { get; set; }
		public WoWPoint Location { get; set; }
		public int ShipmentCrateEntry { get; set; }
		public int WorkOrderNpcEntry { get; set; }
		public int ProfessionNpcEntry { get; set; }
		public bool AlreadyMoved { get; set; }
		public bool NeedToPickupShipments { get; set; }
		public bool NeedToStartWorkOrders { get; set; }
	}
}
