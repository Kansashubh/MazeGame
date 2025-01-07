using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TestApp
{
    
    public partial class frmDungeonEscape : Form
    {
        bool Started = false;
        bool GoRight = true;
        bool GoDown = true;
        bool GoLeft = true; 
        bool GoUp = true;
        int Time = 0;
        int MaxTime = 30;
        double Seconds = 0;
        int Score = 0;
        public frmDungeonEscape()
        {
            InitializeComponent();
            picOne.Left = 31;
            picOne.Top = 75;
            lblGameWinLabel.Visible = false;
            lblLoseGameLabel.Visible = false;
            picSizeIncrease.Visible = false;
            
        }

        private void frmMazeRush_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Started)
            {
                if (e.KeyCode == Keys.Enter) 
                {
                    MaxTime = 30;
                    tmrGame.Enabled = true;
                    Started = true;
                    Time = 0;
                    Seconds = 0;
                    picOne.Left = 31;
                    picOne.Top = 75;
                    lblGameWinLabel.Visible = false;
                    lblLoseGameLabel.Visible = false;
                    picOne.Width = 10;
                    picOne.Height = 10;
                    picTwentyOne.Height = 209;
                    picTwentyOne.Width = 10;
                    picTwentyOne.Top = 140;
                    picTwentyOne.Left = 318;
                    picFive.Height = 305;


                    picGateOpener.Visible = true;
                    picG.Visible = true;

                    picThirtySeven.Left = 704;
                    picThirtySeven.Top = 157;
                    picSizeIncrease.Visible = true;
                    picSizeIncrease2.Visible = true;
                    picSizeIncrease3.Visible = true;
                    picSizeIncrease4.Visible = true;
                    picSizeIncrease5.Visible = true;
                    picSizeIncrease6.Visible = true;
                    picTimeIncrease.Visible = true;
                    picTimeIncrease2.Visible = true;
                    picTimeIncrease3.Visible = true;
                    picTimeIncrease4.Visible = true;
                    picTimeIncrease5.Visible = true;
                    picGateClose.Visible = true;
                    
                    picGateClose3.Visible = true;
                    
                    picGateClose5.Visible = true;
                    picOpenGate.Visible = true;
                    lblMaximumTime.Visible = true;
                    lblMaximumTime.Text = "Maximum Time: " + MaxTime + "Seconds";
                    Score = 0;
                    lblScore.Text = "Score: " + Score;
                    
                }
                if (e.KeyCode == Keys.E) 
                {
                    Application.Exit();
                }
                
            }
            else
            {
                if (e.KeyCode == Keys.Right)
                {
                    GoRight = true;
                    if (GoRight)
                    {
                        picOne.Left += 10;
                    }
                    
                }
                if (e.KeyCode == Keys.Left)
                {
                    GoLeft = true;
                    if (GoLeft)
                    {
                        picOne.Left -= 10;
                    }
                    
                }
                if (e.KeyCode == Keys.Up)
                {
                    GoUp = true;
                    if (GoUp)
                    {
                        picOne.Top -= 10;
                    }
                    
                }
                if (e.KeyCode == Keys.Down)
                {
                    GoDown = true;
                    if (GoDown)
                    {
                        picOne.Top += 10;
                    }
                    
                }
                if (e.KeyCode == Keys.E)
                {
                    Application.Exit();
                }
            }
        }

        private void frmMazeRush_KeyUp(object sender, KeyEventArgs e)
        {
            if (Started)
            {
                if (e.KeyCode == Keys.Right)
                {
                    GoRight = false;
                    if (GoRight)
                    {
                        picOne.Left += 10;
                    }

                }
                if (e.KeyCode == Keys.Left)
                {
                    GoLeft = false;
                    if (GoLeft)
                    {
                        picOne.Left -= 10;
                    }

                }
                if (e.KeyCode == Keys.Up)
                {
                    GoUp = false;
                    if (GoUp)
                    {
                        picOne.Top -= 10;
                    }

                }
                if (e.KeyCode == Keys.Down)
                {
                    GoDown = false;
                    if (GoDown)
                    {
                        picOne.Top += 10;
                    }

                }
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if (Started)
            {
                
                Time = Time + 1;
                Seconds = Time * 0.1;
                lblStopWatch.Text = "Time: " + Seconds;

                if (picOne.Bounds.IntersectsWith(picTwo.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picThree.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picFour.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picFive.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picSix.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picSeven.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picEight.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picNine.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTen.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picEleven.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwelve.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picThirteen.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picFourteen.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picFifteen.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picSixteen.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picSeventeen.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picEighteen.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picNineteen.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwenty.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwentyOne.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwentyTwo.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwentyThree.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwentyFour.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwentyFive.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwentySix.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwentySeven.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwentyEight.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picTwentyNine.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picThirty.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picThirtyOne.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picThirtyTwo.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith (picThirtyThree.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                
                if (picOne.Bounds.IntersectsWith(picThirtyFive.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }                
                if (picOne.Bounds.IntersectsWith(picThirtySeven.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picThirtyEight.Bounds))
                {
                    picOne.Left = 31;
                    picOne.Top = 75;
                }
                if (picOne.Bounds.IntersectsWith(picSizeIncrease.Bounds))
                {
                    if (picSizeIncrease.Visible == true)
                    {
                        picSizeIncrease.Visible = false;
                        picOne.Width = picOne.Width + 2;
                        picOne.Height = picOne.Height + 2;
                        Score = Score + 2;
                        lblScore.Text = "Score: " + Score;
                    }
                }
                if (picOne.Bounds.IntersectsWith(picSizeIncrease2.Bounds))
                {
                    if (picSizeIncrease2.Visible == true)
                    {
                        picSizeIncrease2.Visible = false;
                        picOne.Width = picOne.Width + 2;
                        picOne.Height = picOne.Height + 2;
                        Score = Score + 2;
                        lblScore.Text = "Score: " + Score;
                    }
                }
                if (picOne.Bounds.IntersectsWith(picSizeIncrease3.Bounds))
                {
                    if (picSizeIncrease3.Visible == true)
                    {
                        picSizeIncrease3.Visible = false;
                        picOne.Width = picOne.Width + 2;
                        picOne.Height = picOne.Height + 2;
                        Score = Score + 2;
                        lblScore.Text = "Score: " + Score;
                    }
                }
                if (picOne.Bounds.IntersectsWith(picSizeIncrease4.Bounds))
                {
                    if (picSizeIncrease4.Visible == true)
                    {
                        picSizeIncrease4.Visible = false;
                        picOne.Width = picOne.Width + 2;
                        picOne.Height = picOne.Height + 2;
                        Score = Score + 2;
                        lblScore.Text = "Score: " + Score;
                    }
                    
                }
                if (picOne.Bounds.IntersectsWith(picSizeIncrease5.Bounds))
                {
                    if (picSizeIncrease5.Visible == true)
                    {
                        picSizeIncrease5.Visible = false;
                        picOne.Width = picOne.Width + 2;
                        picOne.Height = picOne.Height + 2;
                        Score = Score + 2;
                        lblScore.Text = "Score: " + Score;
                    }
                }
                if (picOne.Bounds.IntersectsWith(picSizeIncrease6.Bounds))
                {
                    if (picSizeIncrease6.Visible == true)
                    {
                        picSizeIncrease6.Visible = false;
                        picOne.Width = picOne.Width + 2;
                        picOne.Height = picOne.Height + 2;
                        Score = Score + 2;
                        lblScore.Text = "Score: " + Score;
                    }
                }
                if (picOne.Bounds.IntersectsWith(picTimeIncrease.Bounds))
                {
                    if (picTimeIncrease.Visible == true)
                    {
                        picTimeIncrease.Visible = false;
                        MaxTime += 5;
                        lblMaximumTime.Text = "Maximum Time: " + MaxTime + " Seconds";
                        Score = Score + 5;
                        lblScore.Text = "Score: " + Score;
                    }
                }
                if (picOne.Bounds.IntersectsWith(picTimeIncrease2.Bounds))
                {
                    if (picTimeIncrease2.Visible == true)
                    {
                        picTimeIncrease2.Visible = false;
                        MaxTime += 5;
                        lblMaximumTime.Text = "Maximum Time: " + MaxTime + " Seconds";
                        Score = Score + 5;
                        lblScore.Text = "Score: " + Score;
                    }
                }
                if (picOne.Bounds.IntersectsWith(picTimeIncrease3.Bounds))
                {
                    if (picTimeIncrease3.Visible == true)
                    {
                        picTimeIncrease3.Visible = false;
                        MaxTime += 5;
                        lblMaximumTime.Text = "Maximum Time: " + MaxTime + " Seconds";
                        Score = Score + 5;
                        lblScore.Text = "Score: " + Score;
                    }
                }
                if (picOne.Bounds.IntersectsWith(picTimeIncrease4.Bounds))
                {
                    if (picTimeIncrease4.Visible == true)
                    {
                        picTimeIncrease4.Visible = false;
                        MaxTime += 5;
                        lblMaximumTime.Text = "Maximum Time: " + MaxTime + " Seconds";
                        Score = Score + 5;
                        lblScore.Text = "Score: " + Score;
                    }
                }
                if (picOne.Bounds.IntersectsWith(picTimeIncrease5.Bounds))
                {
                    if (picTimeIncrease5.Visible == true)
                    {
                        picTimeIncrease5.Visible = false;
                        MaxTime += 5;
                        lblMaximumTime.Text = "Maximum Time: " + MaxTime + " Seconds";
                        Score = Score + 5;
                        lblScore.Text = "Score: " + Score;
                    }
                }
                                
                if (picOne.Bounds.IntersectsWith(picGateClose.Bounds))
                {
                    if (picGateClose.Visible == true) 
                    { 
                        picGateClose.Visible = false;
                        picTwentyOne.Width = 10;
                        picTwentyOne.Height = 298;
                        picTwentyOne.Left = 318;
                        picTwentyOne.Top = 106;

                    }
                }
                if (picOne.Bounds.IntersectsWith(picG.Bounds))
                {
                    if (picG.Visible == true)
                    {
                        if (picTwentyOne.Width == 10 && picTwentyOne.Height == 298 && picTwentyOne.Left == 318 && picTwentyOne.Top == 106)
                        {
                            picG.Visible = false;
                            picTwentyOne.Height = 209;
                            picTwentyOne.Width = 10;
                            picTwentyOne.Top = 140;
                            picTwentyOne.Left = 318;
                        }
                        
                    }
                }
                
                if (picOne.Bounds.IntersectsWith(picGateClose3.Bounds))
                {
                    if (picGateClose3.Visible == true)
                    {
                        picGateClose3.Visible = false;
                        picFive.Height = 343;
                    }
                }
                if (picOne.Bounds.IntersectsWith(picGateOpener.Bounds))
                {
                    if (picFive.Height == 343)
                    {
                        if (picGateOpener.Visible == true)
                        {
                            picGateOpener.Visible = false;
                            picFive.Height = 305;
                        }
                    }
                }
                if (picOne.Bounds.IntersectsWith(picGateClose5.Bounds))
                {
                    if (picGateClose5.Visible == true)
                    {
                        picGateClose5.Visible = false;
                        picThirtySeven.Top = 133;
                    }
                }

                if (picOne.Bounds.IntersectsWith(picOpenGate.Bounds))
                {
                    if (picOpenGate.Visible == true)
                    {
                        if (picThirtySeven.Top == 133)
                        {
                            picOpenGate.Visible = false;
                            picThirtySeven.Top = 157;
                        }
                        
                        
                    }
                    
                }

                if (picOne.Bounds.IntersectsWith(picFinish.Bounds))
                {
                    tmrGame.Enabled = false;
                    Started = false;
                    lblGameWinLabel.Visible = true;
                }
                if (Seconds >= MaxTime)
                {
                    lblLoseGameLabel.Visible = true;
                    tmrGame.Enabled = false;
                    Started = false;
                }

                this.Refresh();
            }
        }
    }
}
