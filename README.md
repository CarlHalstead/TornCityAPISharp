# TornCityAPISharp
## A (incomplete) C# Wrapper for Torn City API

### Can do:
- Asynchronous Gathering of Statistics
- Player Statistics
- General Torn Statistics
- Simple Faction Statistics (name, ID, leader, best chain, rank)
- Check if internet is working
- Check if API key is there

### Can't do
- Much else (yet)

## Dependencies
### You Need:
- JSON.Net installed in your project
- Import the TornCityAPISharp namespace

## Example Code
```
// Immediately set the API key within the wrapper
private void Form1_Load(object sender, EventArgs e)
{
	API.apiKey = "YourKey";
}

// An Async method to avoid application freezing
private async void GetGeneralStatisticsAsync()
{
	// Retrieve Torn Wide statistics, these may include:
	// - Player within specific jobs, Casino, Hospital, Unemployed etc.
	// - Total crimes committed
	var general = await GeneralStatistics.GetGeneralStatisticsAsync();
	Console.WriteLine(general.job_casino);
}

// An Async method to avoid application freezing
private async void GetFactionStats()
{
	// Retrieve simple specific info about your faction.
	// These may include:
	// - Faction Name/ ID
	// - Leader ID
	// - Best Chain
	// - Respect/ Rank
	var factionName = await FactionStatistics.GetFactionStatisticsAsync(FactionStatistics.FactionData.name);
	Console.WriteLine(factionName);
}
```
