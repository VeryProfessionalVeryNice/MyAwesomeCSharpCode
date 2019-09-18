using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Developed by Andrew Miller
/// Last updated September 18 2019
/// Professor Riley
/// This class will define the form
/// </summary>
namespace SportsTester
{
    public partial class Form1 : Form
    {
        //declare array to hold test data
        Team[] teamList = new Team[100];
        //variable to track crrent list box row
        int currentRow;
    
        public Form1()
        {
            InitializeComponent();
        }
        //load the form by preparingtest data
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSubmit.Visible = false;
            teamList = SportsTester.BuildData();
            foreach (var item in teamList)
            {
                if (item is SubTeam)
                {
                    SubTeam teamItem = (SubTeam)item;
                    lstBxTeams.Items.Add(item);
                }
                else {
                    SubTeam2 teamItem = (SubTeam2)item;
                    lstBxTeams.Items.Add(item);
                        }
            }
            EnDisFields(false);
        }

        public void EnDisFields(bool action)
        {
            this.txtBxTeamName.Enabled = action;
            this.txtBxCoach.Enabled = action;
            this.txtBxRosterSize.Enabled = action;
            this.txtBxSportName.Enabled = action;
            this.txtBxProfessional.Enabled = action;
            this.txtBxAssistant.Enabled = action;
            this.txtBxCheerleaders.Enabled = action;
            this.txtBxSponsor.Enabled = action;
            this.txtBxUniform.Enabled = action;

        }

        private void lstBxSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentRow = lstBxTeams.SelectedIndex;
            Team item = (Team)lstBxTeams.SelectedItem;
            if (item is SubTeam)
            {
                SubTeam teamItem = (SubTeam)item;
                LoadTeamData(teamItem);
                LoadSub1Data(teamItem);

            }
            else
            {
                SubTeam2 teamItem = (SubTeam2)item;
                LoadTeamData(teamItem);
                LoadSub2Data(teamItem);
            } // end else
        } // end of method
        /// <summary>
        /// put data from team object into form text boxes
        /// </summary>
        /// <param name="item"></param>
        private void LoadTeamData(Team item)
        {
            txtBxTeamName.Text = item.TeamName;
            txtBxCoach.Text = item.CoachName;
            txtBxRosterSize.Text = item.CurrentRosterSize.ToString();
            txtBxSportName.Text = item.SportName;
            
            txtBxProfessional.Text = item.ProfessionalTeam.ToString();
        } // end of method
        /// <summary>
        /// put data from sub team 1 into form text boxes
        /// </summary>
        /// <param name="item"></param>
        private void LoadSub1Data(SubTeam item)
        {
            grpSubTeam1.Visible = true;
            grpSubTeam2.Visible = false;

            txtBxAssistant.Text = item.AssistantCoaches.ToString();
            txtBxCheerleaders.Text = item.HaveCheerleaders.ToString();
        }
        /// <summary>
        /// put data from sub team 2 games into form text boxes
        /// </summary>
        /// <param name="item"></param>
        private void LoadSub2Data(SubTeam2 item)
        {
            grpSubTeam1.Visible =false ;
            grpSubTeam2.Visible = true;

            txtBxSponsor.Text = item.NameMainSponsor;
            txtBxUniform.Text = item.DollarsUniformBudget.ToString();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSubmit.Visible = true;
            EnDisFields(true);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // TODO: Add code to add a new game object to the array and list
            int rosterInt = Convert.ToInt16(txtBxRosterSize.Text);
            int budgetInt;
            int assitantInt;
            bool proBool = txtBxProfessional.Text == "True";
            bool cheerleadersBool = txtBxCheerleaders.Text == "True";
            // validate form data
            

            if (int.TryParse(txtBxRosterSize.Text, out rosterInt))
            {
                if (int.TryParse(txtBxAssistant.Text, out assitantInt))
                {
                    // use form data to create a new instance
                    Team newTeam = new SubTeam(txtBxTeamName.Text, rosterInt, txtBxCoach.Text, txtBxSportName.Text,
                        proBool, assitantInt, cheerleadersBool);
                    // add the new instance to the list box
                    lstBxTeams.Items.Add(newTeam);
                }
                else if (int.TryParse(txtBxUniform.Text, out budgetInt))
                {
                    // use form data to create a new instance
                    Team newTeam = new SubTeam2(txtBxTeamName.Text, rosterInt, txtBxCoach.Text, txtBxSportName.Text, proBool,
                        txtBxSponsor.Text, budgetInt);
                    // add the new instance to the list box
                    lstBxTeams.Items.Add(newTeam);
                }
               
            }

            // set current row to zero
            currentRow = 0;


            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // TODO: Add code to update the current row
            
           
            // update the game instance in the listbox
            int rosterInt = Convert.ToInt16(txtBxRosterSize.Text);
            int budgetInt;
            int assitantInt;
            bool proBool = txtBxProfessional.Text == "True";
            bool cheerleadersBool = txtBxCheerleaders.Text == "True";
            // validate form data

            // validate form data
            if (int.TryParse(txtBxRosterSize.Text, out rosterInt))
            {
                if (int.TryParse(txtBxAssistant.Text, out assitantInt))
                {
                    // use form data to create a new instance
                    Team newTeam = new SubTeam(txtBxTeamName.Text, rosterInt, txtBxCoach.Text, txtBxSportName.Text,
                        proBool, assitantInt, cheerleadersBool);
                    // delete old record and add the new instance to the list box
                    currentRow = lstBxTeams.SelectedIndex;
                    lstBxTeams.Items.RemoveAt(currentRow);
                    // above line deletes entry but then gives error from LoadTeamData() since it now sees nulls instead of expected values
                    lstBxTeams.Items.Add(newTeam);
                }
                else if (int.TryParse(txtBxUniform.Text, out budgetInt))
                {
                    // use form data to create a new instance
                    Team newTeam = new SubTeam2(txtBxTeamName.Text, rosterInt, txtBxCoach.Text, txtBxSportName.Text, proBool,
                        txtBxSponsor.Text, budgetInt);
                    // delete old record and add the new instance to the list box
                    currentRow = lstBxTeams.SelectedIndex;
                    lstBxTeams.Items.RemoveAt(currentRow);
                    // above line deletes entry but then gives error from LoadTeamData() since it now sees nulls instead of expected values
                    lstBxTeams.Items.Add(newTeam);
                }

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the current row
            currentRow = lstBxTeams.SelectedIndex;
            //lstBxTeams.Items.RemoveAt(currentRow);
           // above line deletes entry but then gives error from LoadTeamData() since it now sees nulls instead of expected values
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
    }
}
