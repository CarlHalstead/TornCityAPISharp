using System.Collections.Generic;

namespace TornCityAPISharp.PlayerStats
{
	public class PlayerBase
	{
		public string rank { get; set; }
		public int level { get; set; }
		public string gender { get; set; }
		public string property { get; set; }
		public string signup { get; set; }
		public int awards { get; set; }
		public int friends { get; set; }
		public int enemies { get; set; }
		public int forum_posts { get; set; }
		public int karma { get; set; }
		public int age { get; set; }
		public string role { get; set; }
		public int donator { get; set; }
		public int player_id { get; set; }
		public string name { get; set; }
		public int property_id { get; set; }
		public string last_action { get; set; }
		public Life life { get; set; }
		public List<string> status { get; set; }
		public Job job { get; set; }
		public Faction faction { get; set; }
		public Married married { get; set; }
		public Icons icons { get; set; }
	}
}
