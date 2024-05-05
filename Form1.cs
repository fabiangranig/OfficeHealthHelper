using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OfficeHealthHelper
{ 
    enum BodyPosition
    {
        Sitting,
        Standing
    }

    public partial class Form1 : Form
    {
        private int _DefaultStartTime;
        private int _TimerCount;
        private Thread _CountDown;
        private BodyPosition _BodyPosition;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set default variables
            this._DefaultStartTime = 10;
            this._BodyPosition = BodyPosition.Standing;
            this.Icon = Icon.ExtractAssociatedIcon("ico/StandingMan.ico");
            BodyLabelRefresh();
            this._CountDown = new Thread(ThreadCountDown);

            //Set to Timer to 1 hour
            this._TimerCount = this._DefaultStartTime;

            //Start thread
            this._CountDown.Start();
        }

        private void ThreadCountDown()
        {
            while(1 == 1)
            {
                TimerLabelRefresh();
                Thread.Sleep(1000);
                this._TimerCount--;

                if(this._TimerCount == -1)
                {
                    this._TimerCount = this._DefaultStartTime;

                    if(this._BodyPosition == BodyPosition.Sitting)
                    {
                        this._BodyPosition = BodyPosition.Standing;
                        ChangeICON();
                    }
                    else if (this._BodyPosition == BodyPosition.Standing)
                    {
                        this._BodyPosition = BodyPosition.Sitting;
                        ChangeICON();
                    }
                    BodyLabelRefresh();
                }
            }
        }

        private void TimerLabelRefresh()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(TimerLabelRefresh));
            }
            else
            {
                this.label_Timer.Text = this._TimerCount.ToString();
            }
        }

        private void ChangeICON()
        {
            if(InvokeRequired)
            {
                BeginInvoke(new Action(ChangeICON));
            }
            else
            {
                if (this._BodyPosition == BodyPosition.Sitting)
                {
                    this.Icon = Icon.ExtractAssociatedIcon("ico/SittingMan.ico");
                }
                else if (this._BodyPosition == BodyPosition.Standing)
                {
                    this.Icon = Icon.ExtractAssociatedIcon("ico/StandingMan.ico");
                }
            }
        }

        private void BodyLabelRefresh()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(BodyLabelRefresh));
            }
            else
            {
                this.label_Bodyposition.Text = this._BodyPosition.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._CountDown != null && this._CountDown.IsAlive)
            {
                this._CountDown.Abort();
            }
        }
    }
}
