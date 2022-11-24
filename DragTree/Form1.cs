using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DragTree 
{
    public partial class Form1 : Form
    {
        int Time;
        // TODO - create an int variable to track currentRow,
        int currentRow = 1;
        // TODO - create a Stopwatch object called stopwatch 
        Stopwatch stopWatch = new Stopwatch();

        // TODO - create a timer on the form called lightTimer (interval 400ms)
        // TODO - create the tick event for the lightTimer


        // place the following comments in the lighTimer tick event
        // TODO - create a switch block that checks currentRow. In each case
        // it will light up the appropriate lights, (labels). 

        // TODO - increment the currentRow value by 1
        // currentRow++;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

           
            //Thread.Sleep(500);
            //Refresh();

            //row2col1.BackColor = Color.Goldenrod;
            //row2col2.BackColor = Color.Goldenrod;
            //Thread.Sleep(500);
            //Refresh();

            //row3col1.BackColor = Color.Goldenrod;
            //row3col2.BackColor = Color.Goldenrod;
            //Thread.Sleep(500);
            //Refresh();

            //row4col1.BackColor = Color.LimeGreen;
            //row4col2.BackColor = Color.LimeGreen;
            //Thread.Sleep(500);
            //Refresh();

            // TODO - start the timer
            if (lightTimer.Enabled == false)
            {
                lightTimer.Enabled = true;

            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // TODO - stop the stopwatch
            if (lightTimer.Enabled == true)
            {
                startButton.Text = "Start";
                lightTimer.Enabled = false;

                stopWatch.Stop();
                timeLabel.Text = stopWatch.Elapsed + "";
                timeLabel.Text = stopWatch.ElapsedMilliseconds + "";
                timeLabel.Text = stopWatch.Elapsed.ToString(@"s\.fff");


            }
            // TODO - check if the ellapsed time in milliseconds is > 0. 
            // If yes show the time.
            // If no show "FOUL START" 
            else if (Time >= 0) 
            {
                outputLabel.Text = "Foul Start";
            }


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // TODO - reset the stopwatch
            stopWatch.Reset();

            // TODO - put rows 1-3 colours back to DimGray and row 4 back to DarkOliveGreen
            row1col1.BackColor = Color.DimGray;
            row1col2.BackColor = Color.DimGray;

            row2col1.BackColor = Color.DimGray;
            row2col2.BackColor = Color.DimGray;

            row3col1.BackColor = Color.DimGray;
            row3col2.BackColor = Color.DimGray;

            row4col1.BackColor = Color.DarkOliveGreen;
            row4col2.BackColor = Color.DarkOliveGreen;

            // TODO - reset row value and timeLabel text
            timeLabel.Text = "0.000";

        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            // TODO - create a switch block that checks currentRow. In each case
            // it will light up the appropriate lights, (labels).
            // 
            switch(currentRow)
            {
                case 1:
                    row1col1.BackColor = Color.Goldenrod;
                    row1col2.BackColor = Color.Goldenrod;
                    break;
                case 2:
                    row2col1.BackColor = Color.Goldenrod;
                    row2col2.BackColor = Color.Goldenrod;
                    break;
                case 3:
                    row3col1.BackColor = Color.Goldenrod;
                    row3col2.BackColor = Color.Goldenrod;
                    break;
                case 4:
                    row4col1.BackColor = Color.LimeGreen;
                    row4col2.BackColor = Color.LimeGreen;
                    stopWatch.Start();
                    break;
            }

            currentRow++;

            // TODO - increment the currentRow value by 1
            // currentRow++;


        }
    }
}
