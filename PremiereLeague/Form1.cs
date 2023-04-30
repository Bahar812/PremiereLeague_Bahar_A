using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PremiereLeague
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=;database=premier_league ; ";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dataa = new DataTable();
        DataTable dataapemain = new DataTable();
        DataTable dataMatch = new DataTable();
        DataTable timID = new DataTable();
        DataTable playerHome = new DataTable();
        DataTable playerAway = new DataTable();
        DataTable detailMatch = new DataTable();
        string namaTimm ;
        int udah = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(connectionString);
            sqlQuery = "SELECT team_name AS `Nama Tim`, team_id AS `ID Tim` FROM premier_league.team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataa);
            comboBoxTeam.DataSource = dataa;
            comboBoxTeamMatch.DataSource = dataa;
            comboBoxTeam.ValueMember = "ID Tim";
            comboBoxTeam.DisplayMember = "Nama Tim";
            comboBoxTeamMatch.ValueMember = "ID Tim";
            comboBoxTeamMatch.DisplayMember = "Nama Tim";

        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPlayer.Visible = true;
            panelMatch.Visible = false;

            
        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPlayer.Visible = false;
            panelMatch.Visible = true;
           
        }

        
      
        private bool comboTeamSelected = false;
        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                namaTimm = comboBoxTeam.SelectedValue.ToString();
               udah++;
            Lakukan();

        }
        string namaPemainn;
       
        private void comboBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
           // sangat tidak direkomendasikan beralih aja ke selection change commited
        }

        private void Lakukan()
        {
            if (udah > 3)
            {
                comboBoxPlayer.DataSource = null;
                comboBoxPlayer.Items.Clear();
                dataapemain.Clear();
                sqlQuery = "";
                sqlQuery = $"SELECT t.team_id AS `ID Tim`, p.player_name AS `Nama Pemain`, t.team_name, p.player_id AS `ID player`  FROM team t, player p WHERE t.team_id = '{namaTimm}' AND p.team_id = '{namaTimm}' ;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataapemain);
                comboBoxPlayer.DataSource = dataapemain;
                //MessageBox.Show("halo saya sampai " + namaTimm);
                
                comboBoxPlayer.ValueMember = "ID Player";
                comboBoxPlayer.DisplayMember = "Nama Pemain";
            }
           
        }
        DataTable playerData = new DataTable();
        int pertama = 0;
        private void DataPemain(string timID, string playerID )
        {
            playerData.Clear();
            // Membuat label keterangan player secara manual
            Label lblGoal = new Label();
            lblGoal.Text = "Goal Scored: 0";
            lblGoal.Location = new Point(200, 20);
            lblGoal.Size = new Size(170, 12);
            Label lblYellow = new Label();
            lblYellow.Text = "Yellow Card: 0";
            lblYellow.Location = new Point(200, 32);
            lblYellow.Size = new Size(170, 12);
            Label lblRed = new Label();
            lblRed.Text = "Red Card: 0";
            lblRed.Location = new Point(200, 44);
            lblRed.Size = new Size(170, 12);
            Label lblOwnGoal = new Label();
            lblOwnGoal.Text = "Own Goal: 0";
            lblOwnGoal.Location = new Point(200, 56);
            lblOwnGoal.Size = new Size(170, 12);
            Label lblGoalPenalty = new Label();
            lblGoalPenalty.Text = "Goal Penalty: 0";
            lblGoalPenalty.Location = new Point(200, 68);
            lblGoalPenalty.Size = new Size(170, 12);
            Label lblPenaltyMissed = new Label();
            lblPenaltyMissed.Text = "Penalty Missed: 0";
            lblPenaltyMissed.Location = new Point(200, 80);
            lblPenaltyMissed.Size = new Size(170, 12);
            Label lblType = new Label();
            
           
            sqlQuery = $"SELECT p.player_name AS `Name`, t.team_name AS `Team`, p.playing_pos AS `Position`, p.team_number AS `Player Number`, n.nation AS `Nationality`, count(d.type) AS `jumlah`, CASE WHEN d.type = 'CY' THEN 'Yellow Card'WHEN d.type = 'CR' THEN 'RED Card' WHEN d.type = 'GO' THEN 'GOAL' WHEN d.type = 'GW' THEN 'Own Goal' WHEN d.type = 'GP' THEN 'Goal Penalty' WHEN d.type = 'PM' THEN 'Penalty Missed' END AS 'Type' FROM team t JOIN player p ON t.team_id = p.team_id JOIN nationality n ON p.nationality_id = n.nationality_id LEFT JOIN dmatch d ON d.player_id = '{playerID}' WHERE t.team_id = '{timID}' AND p.player_id = '{playerID}' GROUP BY d.type;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(playerData);


            int yellowCard = 0;
            string labelData = "";
           
            foreach (DataRow row in playerData.Rows)
            {
                yellowCard++;
                MessageBox.Show("ini " + yellowCard.ToString());
                if(yellowCard == 1)
                {
                    labelData = $"Name: {row["Name"]}\nTeam: {row["Team"]}\nPosition: {row["Position"]}\nPlayer Number: {row["Player Number"]}\nNationality: {row["Nationality"]}\n";
                }
               

                if (row["type"].ToString() == "GOAL")
                {
                    lblGoal.Text  = $"Goal Scored: {row["jumlah"]}\n";
                    MessageBox.Show("ini goal" );
                }
                else if (row["type"].ToString() == "Yellow Card")
                {
                    lblYellow.Text = $"Yellow Card: {row["jumlah"]}\n";
                    MessageBox.Show("ini y" );
                }
                else if (row["type"].ToString() == "RED Card")
                {
                    lblRed.Text = $"Red Card: {row["jumlah"]}\n";
                    MessageBox.Show("ini r"  );
                }
                else if (row["type"].ToString() == "Own Goal")
                {
                    lblOwnGoal.Text = $"Own Goal: {row["jumlah"]}\n";
                    MessageBox.Show("ini og"  );
                }
                else if (row["type"].ToString() == "Goal Penalty")
                {
                    lblGoalPenalty.Text = $"Goal Penalty: {row["jumlah"]}\n";
                    MessageBox.Show("ini gp"  );
                }
                else if (row["type"].ToString() == "Penalty Missed")
                {
                    lblPenaltyMissed.Text = $"Penalty Missed: {row["jumlah"]}\n";
                    MessageBox.Show("ini pm"  );
                }

                lblType.Text = labelData;
                lblType.Location = new Point(10, 20);
                lblType.Size = new Size(150, 80);

                // mengatur ukuran font
               

                this.panelPopulateData.Controls.Add(lblType);
                this.panelPopulateData.Controls.Add(lblGoal);
                this.panelPopulateData.Controls.Add(lblYellow);
                this.panelPopulateData.Controls.Add(lblRed);
                this.panelPopulateData.Controls.Add(lblGoalPenalty);
                this.panelPopulateData.Controls.Add(lblOwnGoal);
                this.panelPopulateData.Controls.Add(lblPenaltyMissed);
            }
            yellowCard = 0;
            labelData = "";


        }

        private void comboBoxPlayer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            namaPemainn = comboBoxPlayer.SelectedValue.ToString();
            panelPopulateData.Controls.Clear();
                DataPemain(namaTimm, namaPemainn);
            
        }

        private void comboBoxTeam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panelPopulateData.Controls.Clear();
        }

        string teamMatch;
        private void comboBoxTeamMatch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataMatch.Clear();
            dgvMatch.Controls.Clear();
            teamMatch = comboBoxTeamMatch.SelectedValue.ToString();
            sqlQuery = $"SELECT CONCAT(home.team_name, ' vs ', away.team_name) AS versus, m.match_id AS `Match_ID` FROM `match` m JOIN team AS home ON m.team_home =  home.team_id JOIN team AS away ON m.team_away = away.team_id WHERE m.team_home = '{teamMatch}' OR  m.team_away = '{teamMatch}' GROUP BY m.match_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataMatch);
            dgvMatch.DataSource = dataMatch;

            dgvMatch.Columns["versus"].Visible = true;
            dgvMatch.Columns["Match_ID"].Visible = false;
            dgvMatch.Columns["versus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvMatch.Columns["versus"].HeaderText = "Versus";

        }

        string homeID;
        string awayID;
        string detailHome = "";
        string detailAway;
       
        private void dgvMatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Label> lblHome = new List<Label>();
            List<Label> lblAway = new List<Label>();
            playerHome.Clear();
            playerAway.Clear();
            dgvPlayerHome.Controls.Clear();
            dgvPlayerAway.Controls.Clear();
            panelDetailMatch.Controls.Clear();
            lblHome.Clear();
            lblAway.Clear();
            

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMatch.Columns["versus"].Index)
            {
                //List<Label> lblHome = new List<Label>();
               // Label[] lblAway = new Label[100];
                
                string matchId = dgvMatch.Rows[e.RowIndex].Cells["Match_ID"].Value.ToString();
                sqlQuery = $"SELECT m.match_id, home.team_id AS `Team_Home_ID`, away.team_id AS `Team_Away_ID` FROM `match` m JOIN team AS home ON m.team_home =  home.team_id JOIN team AS away ON m.team_away = away.team_id WHERE m.match_id = '{matchId}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(timID);

                foreach(DataRow row in timID.Rows)
                {
                    homeID = $"{row["Team_Home_ID"]}";
                    awayID = $"{row["Team_Away_ID"]}";
                }

                sqlQuery = $"SELECT p.player_name AS 'Player Home' FROM player p LEFT JOIN team h ON h.team_id = p.team_id WHERE h.team_id = '{homeID}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(playerHome);
                dgvPlayerHome.DataSource = playerHome;

                dgvPlayerHome.Columns["Player Home"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                sqlQuery = $"SELECT p.player_name AS 'Player Away' FROM player p LEFT JOIN team h ON h.team_id = p.team_id WHERE h.team_id = '{awayID}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(playerAway);
                dgvPlayerAway.DataSource = playerAway;
                dgvPlayerAway.Columns["Player Away"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                sqlQuery = $"SELECT d.`minute`AS 'Minute', t.team_name AS 'Team_Name', t.team_id AS 'Team_ID', p.player_name AS 'Player_Name', CASE WHEN d.type = 'CY' THEN 'Yellow Card' WHEN d.type = 'CR' THEN 'Red Card' WHEN d.type = 'GO' THEN 'Goal' WHEN d.type = 'GW' THEN 'Own Goal' WHEN d.type = 'GP' THEN 'Goal Penalty' WHEN d.type = 'PM' THEN 'Penalty Missed' END AS 'Type' FROM `match` m JOIN dmatch d ON m.match_id = d.match_id JOIN player p ON d.player_id = p.player_id JOIN team t ON t.team_id = d.team_id  WHERE m.match_id = '{matchId}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(detailMatch);

                int sekaliAja = 0;
                int x = 10;
                Label TitleHome = new Label();
                Label TitleAway = new Label();
               
                int y = 0;
                int yy = 0;

                foreach (DataRow row in detailMatch.Rows)
                {
                    
                    if (row["Team_ID"].ToString() == homeID)
                    {
                        TitleHome.Text = row["Team_Name"].ToString();
                        TitleHome.Location = new Point(15, 5);
                        TitleHome.Font = new Font("Arial", 12);
                        TitleHome.Size = new Size(120, 25);
                        panelDetailMatch.Controls.Add(TitleHome);
                        Label lbl = new Label();
                        y += 20;

                        string detailHome = $"Minute: {row["Minute"]} {row["Player_Name"]} {row["Type"]}\n";
                        lbl.Text = detailHome;
                        lbl.Location = new Point(10, (20 + y));
                        lbl.Size = new Size(220, 20);

                        lblHome.Add(lbl);
                    }

                    if (row["Team_ID"].ToString() == awayID)
                    {
                        TitleAway.Text = row["Team_Name"].ToString();
                        TitleAway.Location = new Point(245, 5);
                        TitleAway.Font = new Font("Arial", 12);
                        TitleAway.Size = new Size(120, 25);
                        panelDetailMatch.Controls.Add(TitleAway);
                        Label lbl = new Label();
                        yy += 20;

                        string detailHome = $"Minute: {row["Minute"]} {row["Player_Name"]} {row["Type"]}\n";
                        lbl.Text = detailHome;
                        lbl.Location = new Point(230, (20 + yy));
                        lbl.Size = new Size(220, 20);

                        lblAway.Add(lbl);
                    }


                }

                panelDetailMatch.Controls.AddRange(lblHome.ToArray());
                panelDetailMatch.Controls.AddRange(lblAway.ToArray());


                // gunakan nilai matchId untuk melakukan operasi selanjutnya
            }
        }
    }
}
