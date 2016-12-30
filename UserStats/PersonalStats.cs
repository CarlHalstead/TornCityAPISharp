using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{

    public class Personalstats
    {
        [JsonProperty("bazaarcustomers")]
        public int BazaarCustomers { get; set; }

        [JsonProperty("bazaarsales")]
        public int BazaarSales { get; set; }

        [JsonProperty("bazaarprofit")]
        public long BazaarProfit { get; set; }

        [JsonProperty("useractivity")]
        public int UserActivity { get; set; }

        [JsonProperty("itemsbought")]
        public int ItemsBought { get; set; }

        [JsonProperty("pointsbought")]
        public int PointsBought { get; set; }

        [JsonProperty("itemsboughtabroad")]
        public int ItemsBoughtAbroad { get; set; }

        [JsonProperty("weaponsbought")]
        public int WeaponsBought { get; set; }

        [JsonProperty("trades")]
        public int Trades { get; set; }

        [JsonProperty("itemssent")]
        public int ItemsSent { get; set; }

        [JsonProperty("auctionswon")]
        public int AuctionsWon { get; set; }

        [JsonProperty("auctionsells")]
        public int AuctionSells { get; set; }

        [JsonProperty("pointssold")]
        public int PointsSold { get; set; }

        [JsonProperty("attackswon")]
        public int AttacksWon { get; set; }

        [JsonProperty("attackslost")]
        public int AttacksLost { get; set; }

        [JsonProperty("attacksdraw")]
        public int AttacksDraw { get; set; }

        [JsonProperty("bestkillstreak")]
        public int BestKillStreak { get; set; }

        [JsonProperty("moneymugged")]
        public int MoneyMugged { get; set; }

        [JsonProperty("attacksstealthed")]
        public int AttacksStealthed { get; set; }

        [JsonProperty("attackcriticalhits")]
        public int AttackCriticalHits { get; set; }

        [JsonProperty("respectforfaction")]
        public int RespectForFaction { get; set; }

        [JsonProperty("defendswon")]
        public int DefendsWon { get; set; }

        [JsonProperty("defendslost")]
        public int DefendsLost { get; set; }

        [JsonProperty("defendsstalemated")]
        public int DefendsStalemated { get; set; }

        [JsonProperty("roundsfired")]
        public int RoundsFired { get; set; }

        [JsonProperty("yourunaway")]
        public int YouRunAway { get; set; }

        [JsonProperty("theyrunaway")]
        public int TheyRunAway { get; set; }

        [JsonProperty("highestbeaten")]
        public int HighestBeaten { get; set; }

        [JsonProperty("peoplebusted")]
        public int PeopleBusted { get; set; }

        [JsonProperty("failedbusts")]
        public int FailedBusts { get; set; }

        [JsonProperty("peoplebought")]
        public int PeopleBought { get; set; }

        [JsonProperty("peopleboughtspent")]
        public int PeopleBoughtSpent { get; set; }

        [JsonProperty("virusescoded")]
        public int VirusesCoded { get; set; }

        [JsonProperty("cityfinds")]
        public int CityFinds { get; set; }

        [JsonProperty("traveltimes")]
        public int TravelTimes { get; set; }

        [JsonProperty("bountiesplaced")]
        public int BountiesPlaced { get; set; }

        [JsonProperty("bountiesreceived")]
        public int BountiesReceived { get; set; }

        [JsonProperty("bountiescollected")]
        public int BountiesCollected { get; set; }

        [JsonProperty("totalbountyreward")]
        public int TotalBountyReward { get; set; }

        [JsonProperty("revives")]
        public int Revives { get; set; }

        [JsonProperty("revivesreceived")]
        public int RevivesReceived { get; set; }

        [JsonProperty("medicalitemsused")]
        public int MedicalItemsUsed { get; set; }

        [JsonProperty("statenhancersused")]
        public int StatEnhancersUsed { get; set; }

        [JsonProperty("trainsreceived")]
        public int TrainsReceived { get; set; }

        [JsonProperty("totalbountyspent")]
        public int TotalBountySpent { get; set; }

        [JsonProperty("drugsused")]
        public int DrugsUsed { get; set; }

        [JsonProperty("overdosed")]
        public int Overdosed { get; set; }

        [JsonProperty("meritsbought")]
        public int Meritsbought { get; set; }

        [JsonProperty("logins")]
        public int Logins { get; set; }

        [JsonProperty("personalsplaced")]
        public int PersonalsPlaced { get; set; }

        [JsonProperty("classifiedadsplaced")]
        public int ClassifiedAdsPlaced { get; set; }

        [JsonProperty("mailssent")]
        public int MailsSent { get; set; }

        [JsonProperty("friendmailssent")]
        public int friendmailssent { get; set; }

        [JsonProperty("factionmailssent")]
        public int FactionMailsSent { get; set; }

        [JsonProperty("companymailssent")]
        public int CompanyMailsSent { get; set; }

        [JsonProperty("spousemailssent")]
        public int SpouseMailsSent { get; set; }

        [JsonProperty("largestmug")]
        public int LargestMug { get; set; }

        [JsonProperty("medstolen")]
        public int MedStolen { get; set; }

        [JsonProperty("cantaken")]
        public int CanTaken { get; set; }

        [JsonProperty("exttaken")]
        public int ExtTaken { get; set; }

        [JsonProperty("xantaken")]
        public int XanTaken { get; set; }

        [JsonProperty("victaken")]
        public int VicTaken { get; set; }

        [JsonProperty("chahits")]
        public int ChaHits { get; set; }

        [JsonProperty("heahits")]
        public int HeaHits { get; set; }

        [JsonProperty("axehits")]
        public int AxeHits { get; set; }

        [JsonProperty("grehits")]
        public int GreHits { get; set; }

        [JsonProperty("machits")]
        public int MacHits { get; set; }

        [JsonProperty("pishits")]
        public int PisHits { get; set; }

        [JsonProperty("rifhits")]
        public int RifHits { get; set; }

        [JsonProperty("shohits")]
        public int ShoHits { get; set; }

        [JsonProperty("smghits")]
        public int SmgHits { get; set; }

        [JsonProperty("piehits")]
        public int PieHits { get; set; }

        [JsonProperty("slahits")]
        public int SlaHits { get; set; }

        [JsonProperty("argtravel")]
        public int ArgTravel { get; set; }

        [JsonProperty("mextravel")]
        public int MexTravel { get; set; }

        [JsonProperty("hawtravel")]
        public int HawTravel { get; set; }

        [JsonProperty("japtravel")]
        public int JapTravel { get; set; }

        [JsonProperty("lontravel")]
        public int LonTravel { get; set; }

        [JsonProperty("soutravel")]
        public int SouTravel { get; set; }

        [JsonProperty("switravel")]
        public int SwiTravel { get; set; }

        [JsonProperty("chitravel")]
        public int ChiTravel { get; set; }

        [JsonProperty("cantravel")]
        public int CanTravel { get; set; }

        [JsonProperty("dumpfinds")]
        public int DumpFinds { get; set; }

        [JsonProperty("dumpsearches")]
        public int DumpSearches { get; set; }

        [JsonProperty("itemsdumped")]
        public int ItemsDumped { get; set; }

        [JsonProperty("daysbeendonator")]
        public int DaysBeenDonator { get; set; }

        [JsonProperty("caytravel")]
        public int CayTravel { get; set; }

        [JsonProperty("jailed")]
        public int Jailed { get; set; }

        [JsonProperty("hospital")]
        public int Hospital { get; set; }

        [JsonProperty("spydone")]
        public int SpyDone { get; set; }

        [JsonProperty("lsdtaken")]
        public int LsdTaken { get; set; }

        [JsonProperty("networth")]
        public long Networth { get; set; }

        [JsonProperty("bloodwithdrawn")]
        public int BloodWithdrawn { get; set; }

        [JsonProperty("missioncreditsearned")]
        public int MissionCreditsearned { get; set; }

        [JsonProperty("contractscompleted")]
        public int ContractsCompleted { get; set; }

        [JsonProperty("dukecontractscompleted")]
        public int DukeContractsCompleted { get; set; }

        [JsonProperty("missionscompleted")]
        public int MissionsCompleted { get; set; }

        [JsonProperty("attacksassisted")]
        public int AttacksAssisted { get; set; }

        [JsonProperty("refills")]
        public int Refills { get; set; }
    }

}
