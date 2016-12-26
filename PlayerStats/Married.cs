namespace TornCityAPISharp.PlayerStats
{
	/// <summary>
	/// Marriage information
	/// </summary>
	public class Married
	{
		/// <summary>
		/// ID of the spouse
		/// </summary>
		public int spouse_id { get; set; }
		/// <summary>
		/// name of the spouse
		/// </summary>
		public string spouse_name { get; set; }
		/// <summary>
		/// time together
		/// </summary>
		public int duration { get; set; }
	}
}
