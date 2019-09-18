using System;

namespace SportsTester
{
    /// <summary>
    /// This class defines team1
    /// </summary>
    public class SubTeam : Team, iAnnualBudget
    {
        /// <summary>
        /// private data fields
        /// </summary>
        private int assistantCoaches;
        private bool haveCheerleaders;
        
        public int AssistantCoaches { get => assistantCoaches; set => assistantCoaches = value; }
        public bool HaveCheerleaders { get => haveCheerleaders; set => haveCheerleaders = value; }


    /// <summary>
    /// fully populated constructor
    /// </summary>
    /// <param name="teamName"></param>
    /// <param name="currentRosterSize"></param>
    /// <param name="coachName"></param>
    /// <param name="sportName"></param>
    /// <param name="professionalTeam"></param>
    /// <param name="assistantCoaches"></param>
    /// <param name="haveCheerleaders"></param>
        public SubTeam(string teamName, int currentRosterSize, string coachName, string sportName, 
            bool professionalTeam, int assistantCoaches, bool haveCheerleaders)
            :base (teamName, currentRosterSize, coachName, sportName, professionalTeam)
        {
            this.assistantCoaches = assistantCoaches;
            this.haveCheerleaders = haveCheerleaders;
        }

    /// <summary>
    /// default no-arg constructor
    /// </summary>
        public SubTeam()
        {
            this.assistantCoaches = 2;
            this.haveCheerleaders = true;
        }

    /// <summary>
    /// return string equiv of class
    /// </summary>
    /// <returns></returns>
        public override string ToString()
        {
            string returnString = base.ToString();
            returnString += $" Assistant Coaches:{assistantCoaches}\r\n";
            returnString += $" Has Cheerleaders:{haveCheerleaders}\r\n";
            return returnString;
        }

    /// <summary>
    /// return team announcement
    /// </summary>
    /// <returns></returns>
        public override string TeamAnnounce()
        {
            return $" They are here to play!";
        }

    /// <summary>
    /// override team assesment
    /// </summary>
    /// <returns></returns>
        public override string TeamAssesment()
        {
            return $" A favorite to win it all";
        }
        /// <summary>
        /// implementing budget interface
        /// </summary>
        /// <returns></returns>

        
        int iAnnualBudget.IBudget()
        {
            int totalBudget;
            totalBudget = (-2 * AssistantCoaches) + (5 * CurrentRosterSize);
            return totalBudget;
        }
        /// <summary>
        /// public properties
        /// </summary>
    }

}