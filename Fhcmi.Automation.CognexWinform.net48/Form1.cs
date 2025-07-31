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

        private Timer streamTimer;
        private bool isStreaming = false;

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
            myFifo = myFrameGrabber.CreateAcqFifo(AvailableVideoFormats[1], CogAcqFifoPixelFormatConstants.Format8Grey,0,false);
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
                // Configure for free-run mode
                myFifo.OwnedTriggerParams.TriggerEnabled = false;
                SetExposure((int)InputExposure.Value);

                // Create and start timer for continuous acquisition
                if (streamTimer == null)
                {
                    streamTimer = new Timer();
                    streamTimer.Interval = 33; // ~30 FPS
                    streamTimer.Tick += StreamTimer_Tick;
                }

                isStreaming = true;
                streamTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start live feed: " + ex.Message);
            }
        }

        private void StreamTimer_Tick(object sender, EventArgs e)
        {
            if (isStreaming && myFifo != null)
            {
                try
                {
                    ICogImage image = TakePic();
                    if (image != null)
                    {
                        cogDisplay1.Image = image;
                    }
                }
                catch (Exception ex)
                {
                    // Handle acquisition errors
                    streamTimer.Stop();
                    isStreaming = false;
                    MessageBox.Show("Streaming error: " + ex.Message);
                }
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Stop live display first
                cogDisplay1.StopLiveDisplay();

                // Disconnect the frame grabber
                if (myFrameGrabber != null)
                {
                    myFrameGrabber.Disconnect(true);
                }

                lbStatus.Text = "Disconnected";
                EnableControls(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during disconnect: " + ex.Message);
            }
        }
    }
}
