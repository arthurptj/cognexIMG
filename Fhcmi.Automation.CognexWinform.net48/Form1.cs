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

        private void Demo_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InputBrightness_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InitCamera()
        {
            myFrameGrabbers = new CogFrameGrabbers();
            myFrameGrabber = myFrameGrabbers[0];

            CogStringCollection AvailableVideoFormats = myFrameGrabber.AvailableVideoFormats;
            myFifo = myFrameGrabber.CreateAcqFifo(AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey,0,false);
            SetExposure(100);
            
        }

        private ICogImage TakePic()
        {
            ICogImage image = null;
            int trignum;
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
        }
    }
}
