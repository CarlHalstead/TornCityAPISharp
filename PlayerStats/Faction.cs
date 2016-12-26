namespace TornCityAPISharp.PlayerStats
{
	/// <summary>
	/// This class holds simple information about the faction
	/// </summary>
	public class Faction
	{
		/// <summary>
		/// This is your factions position
		/// </summary>
		public string position { get; set; }
		/// <summary>
		/// This is your factions ID
		/// </summary>
		public int faction_id { get; set; }
		/// <summary>
		/// Days in the faction
		/// </summary>
		public int days_in_faction { get; set; }
		/// <summary>
		/// Name of the faction
		/// </summary>
		public string faction_name { get; set; }
	}
}
