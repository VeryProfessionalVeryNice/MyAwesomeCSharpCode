using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTester
     
{/// <summary>
/// Developed by Andrew Miller
/// Last updated September 18 2019
/// Professor Riley
/// This class will be used to define sports teams
/// </summary>
    public abstract class Team
{

    private string teamName;
    private int currentRosterSize;
    private string coachName;
    private string sportName;
    private bool professionalTeam;

        /// <summary>
        /// public properties
        /// </summary>
        public string TeamName { get => teamName; set => teamName = value; }
        public int CurrentRosterSize { get => currentRosterSize; set => currentRosterSize = value; }
        public string CoachName { get => coachName; set => coachName = value; }
        public string SportName { get => sportName; set => sportName = value; }
        public bool ProfessionalTeam { get => professionalTeam; set => professionalTeam = value; }
        /// <summary>
        /// full team constructor
        /// </summary>
        /// <param name="teamName"></param>
        /// <param name="currentRosterSize"></param>
        /// <param name="coachName"></param>
        /// <param name="sportName"></param>
        /// <param name="professionalTeam"></param>
        public Team(string teamName, int currentRosterSize, string coachName, string sportName, bool professionalTeam)
        {
            this.teamName = teamName;
            this.currentRosterSize = currentRosterSize;
            this.coachName = coachName;
            this.sportName = sportName;
            this.professionalTeam = professionalTeam;
        }
        /// <summary>
        /// no-arg constructor
        /// </summary>
        public Team()
        {
            this.teamName = "Default Team Name";
            this.currentRosterSize = 90210;
            this.coachName = "Placeholder Coach Name";
            this.sportName = "Sport Name";
            this.professionalTeam = true;
        }
        /// <summary>
        /// override tostring method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string teamBasics = "";
            teamBasics += $" Team Name: {teamName}\r\n";
            teamBasics += $" Roster Size: {currentRosterSize}\r\n";
            teamBasics += $" Coach: {coachName}\r\n";
            teamBasics += $" Sport: {sportName}\r\n";
            teamBasics += $" Professional?: {professionalTeam}\r\n";
            return teamBasics;
        }


        public abstract string TeamAnnounce();
       

        public virtual string TeamAssesment()
        {
            return "They have a great team this year.";
        }

       
}
}
