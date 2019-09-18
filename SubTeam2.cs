using System;
using SportsTester;
namespace SportsTester
{
    /// <summary>
    /// this class defines team2
    /// </summary>
    public class SubTeam2 : Team, iAnnualBudget
    {
        /// <summary>
        /// private data fields
        /// </summary>
        private string nameMainSponsor;
        private int dollarsUniformBudget;

       

        /// <summary>
        /// public properties
        /// </summary>
        public string NameMainSponsor { get => nameMainSponsor; set => nameMainSponsor = value; }
        public int DollarsUniformBudget { get => dollarsUniformBudget; set => dollarsUniformBudget = value; }

        /// <summary>
        /// full constructor
        /// </summary>
        /// <param name="teamName"></param>
        /// <param name="currentRosterSize"></param>
        /// <param name="coachName"></param>
        /// <param name="sportName"></param>
        /// <param name="professionalTeam"></param>
        /// <param name="nameMainSponsor"></param>
        /// <param name="dollarsUniformBudget"></param>
        public SubTeam2(string teamName, int currentRosterSize, string coachName, string sportName,
            bool professionalTeam, string nameMainSponsor, int dollarsUniformBudget)
            : base(teamName, currentRosterSize, coachName, sportName, professionalTeam)
        {
            this.nameMainSponsor = nameMainSponsor;
            this.dollarsUniformBudget = dollarsUniformBudget;
        }

        /// <summary>
        /// default no-arg constructor
        /// </summary>
        public SubTeam2()
        {
            this.nameMainSponsor = " Ralph's Tire";
            this.dollarsUniformBudget = 2700;
        }

        /// <summary>
        /// return string equiv of class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string returnString = base.ToString();
            returnString += $" Sponsored By:{nameMainSponsor}\r\n";
            returnString += $" Uniform Budget: ${dollarsUniformBudget}\r\n";
            return returnString;
        }

        /// <summary>
        /// return team announcement
        /// </summary>
        /// <returns></returns>
        public override string TeamAnnounce()
        {
            return $" Get ready for them!";
        }

        /// <summary>
        /// override team assesment
        /// </summary>
        /// <returns></returns>
        public override string TeamAssesment()
        {
            return $" One of the top 5 teams.";
        }

        int iAnnualBudget.IBudget()
        {
            int totalBudget;
            totalBudget = dollarsUniformBudget + (5 * CurrentRosterSize);
            return totalBudget;
            
        }
        /// <summary>
        /// implement budget interface
        /// </summary>
        /// <returns></returns>
        
    }
}