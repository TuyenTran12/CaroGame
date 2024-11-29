using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class LeaderBoard : Form
    {
        private readonly DatabaseConnection database;
        private SqlConnection conn;
        public LeaderBoard(string currentUser)
        {
            InitializeComponent();
            database = new DatabaseConnection();
            LoadLeaderboard(currentUser);
        }

        private void LoadLeaderboard(string currentUser)
        {
            try
            {
                conn = database.OpenConnection();

                string query = @"
            SELECT RANK() OVER (ORDER BY score DESC) AS rank, username, score
            FROM Login
            WHERE score > 0
            ORDER BY rank ASC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable leaderboardTable = new DataTable();
                        adapter.Fill(leaderboardTable);

                        bool isCurrentUserRanked = false;

                        // Hiển thị tối đa 5 người chơi
                        for (int i = 0; i < leaderboardTable.Rows.Count && i < 5; i++)
                        {
                            DataRow row = leaderboardTable.Rows[i];
                            int rank = Convert.ToInt32(row["rank"]);
                            string username = row["username"].ToString();
                            int score = Convert.ToInt32(row["score"]);

                            // Cập nhật nhãn tương ứng
                            switch (rank)
                            {
                                case 1:
                                    lbName1.Text = username;
                                    lbScore1.Text = score.ToString();
                                    break;
                                case 2:
                                    lbName2.Text = username;
                                    lbScore2.Text = score.ToString();
                                    break;
                                case 3:
                                    lbName3.Text = username;
                                    lbScore3.Text = score.ToString();
                                    break;
                                case 4:
                                    lbName4.Text = username;
                                    lbScore4.Text = score.ToString();
                                    break;
                                case 5:
                                    lbName5.Text = username;
                                    lbScore5.Text = score.ToString();
                                    break;
                            }

                            // Kiểm tra nếu người dùng hiện tại có trong top
                            if (username.Equals(currentUser, StringComparison.OrdinalIgnoreCase))
                            {
                                isCurrentUserRanked = true;
                                lbTopNow.Text = $"{rank}";
                                lbNameNow.Text = username;
                                lbScoreNow.Text = score.ToString();

                                // Thay đổi màu và giao diện dựa trên rank
                                if (rank == 1)
                                {
                                    ApplyRankStyle(lbTopNow, lbNameNow, lbScoreNow, pnTopNow, pnTop1, lbName1.ForeColor, pnTop1.BackColor);
                                }
                                else if (rank == 2)
                                {
                                    ApplyRankStyle(lbTopNow, lbNameNow, lbScoreNow, pnTopNow, pnTop2, lbName2.ForeColor, pnTop2.BackColor);
                                }
                                else if (rank == 3)
                                {
                                    ApplyRankStyle(lbTopNow, lbNameNow, lbScoreNow, pnTopNow, pnTop3, lbName3.ForeColor, pnTop3.BackColor);
                                }
                            }
                        }

                        // Nếu người chơi hiện tại không nằm trong Top 1-3, hiển thị mặc định
                        if (!isCurrentUserRanked)
                        {
                            lbTopNow.Text = "Rank: N/A";
                            lbNameNow.Text = currentUser;
                            lbScoreNow.Text = "0";
                            ResetDefaultStyle(lbTopNow, lbNameNow, lbScoreNow, pnTopNow);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải leaderboard: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.CloseConnection(conn);
            }
        }

        // Hàm áp dụng style cho Top 1, 2, 3
        private void ApplyRankStyle(Label lbTop, Label lbName, Label lbScore, Panel pnTop, Panel pnSourceTop, Color foreColor, Color backColor)
        {
            lbTop.ForeColor = foreColor;
            lbName.ForeColor = foreColor;
            lbScore.ForeColor = foreColor;

            pnTop.BackColor = backColor;
        }

        // Hàm đặt lại style mặc định cho user không nằm trong Top 1-3
        private void ResetDefaultStyle(Label lbTop, Label lbName, Label lbScore, Panel pnTop)
        {
            lbTop.ForeColor = Color.Black;
            lbName.ForeColor = Color.Black;
            lbScore.ForeColor = Color.Black;

            pnTop.BackColor = SystemColors.Control;
        }

    }
}
