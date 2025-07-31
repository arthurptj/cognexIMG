using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
namespace Fhcmi.Automation.CognexWinform.net48
{
    public partial class Form1 : Form
    {
        CogFrameGrabbers myFrameGrabbers;
        ICogFrameGrabber myFrameGrabber;       
        ICogAcqFifo myFifo;

        public Form1()
        {
            InitializeComponent();
            EnableControls(false);
        }

        private void InitCamera()
        {
            myFrameGrabbers = new CogFrameGrabbers();
            myFrameGrabber = myFrameGrabbers[0];

            CogStringCollection AvailableVideoFormats = myFrameGrabber.AvailableVideoFormats;
            myFifo = myFrameGrabber.CreateAcqFifo(AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey,0,false);
            SetExposure(10);
            
        }

        private ICogImage TakePic()
        {
            ICogImage image = null;
            int trignum;
            trignum = 1;
            image = myFifo.Acquire(out trignum);
            return image;
        }

        private void SetExposure(int val)
        {
            myFifo.OwnedExposureParams.Exposure = val;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            InitCamera();
            lbStatus.Text = myFrameGrabber.SerialNumber;
            InputExposure.Value = (decimal)myFifo.OwnedExposureParams.Exposure;
            EnableControls(true);
        }

        private void Trigger_Click(object sender, EventArgs e)
        {
            cogDisplay1.Image = TakePic();
            cogDisplay1.Fit();
        }

        private void InputExposure_ValueChanged(object sender, EventArgs e)
        {
            SetExposure((int)InputExposure.Value);
        }

        private void EnableControls(bool isConnect)
        {
            btConnect.Enabled = !isConnect;
            Trigger.Enabled = isConnect;
            InputExposure.Enabled = isConnect;
            btStream.Enabled = isConnect;
        }

        private void btStream_Click(object sender, EventArgs e)
        {
            if (myFifo == null)
            {
                MessageBox.Show("Camera not initialized.");
                return;
            }

            try
            {
                // Make sure trigger is disabled (free-run mode)
                myFifo.OwnedTriggerParams.TriggerEnabled = false;

                // Optional: Set exposure again
                SetExposure((int)InputExposure.Value);

                // Start live display
                cogDisplay1.StartLiveDisplay(myFifo, false);
                cogDisplay1.Fit(); // Ensure image is visible
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start live feed: " + ex.Message);
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            cogDisplay1.StopLiveDisplay();
            myFrameGrabber.Disconnect(true);

        }
    }
}
