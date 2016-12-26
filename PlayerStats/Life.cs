namespace TornCityAPISharp.PlayerStats
{
	/// <summary>
	/// Players life
	/// </summary>
	public class Life
	{
		/// <summary>
		/// current life
		/// </summary>
		public int current { get; set; }
		/// <summary>
		/// maximum life
		/// </summary>
		public int maximum { get; set; }
		/// <summary>
		/// how much it increase each tick
		/// </summary>
		public int increment { get; set; }
		/// <summary>
		/// time between each tick
		/// </summary>
		public int interval { get; set; }
		/// <summary>
		/// time left till tick
		/// </summary>
		public int ticktime { get; set; }
		/// <summary>
		/// time
		/// </summary>
		public int fulltime { get; set; }
	}

}
