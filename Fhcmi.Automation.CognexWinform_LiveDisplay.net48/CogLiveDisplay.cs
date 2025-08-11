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
using Cognex.VisionPro.Display;

namespace Fhcmi.Automation.CognexWinform_LiveDisplay.net48
{
    public partial class LiveDisplay : Form
    {
        #region Fields

        ICogFrameGrabber myFrameGrabber = null;
        ICogAcqFifo myFifo;

        #endregion

        #region Properties

        public string TargetCameraDeviceUserID { get; set; } = "EpoxyCAM";
        public double Exposure { get; set; } = 0.5;
        
        #endregion

        #region Constructors

        public LiveDisplay()
        {
            InitializeComponent();
            InitDisplay();
            InitCamera();
        }

        #endregion

        #region Methods


        private void InitDisplay() //configure cogdisplay
        {
            cogDisplay1.AutoFit = true;
            cogDisplay1.MouseWheelMode = CogDisplayMouseWheelModeConstants.None;
            cogDisplay1.MouseMode = CogDisplayMouseModeConstants.Pointer;
            cogDisplay1.Dock = DockStyle.Fill;
            cogDisplay1.HorizontalScrollBar = false;
            cogDisplay1.VerticalScrollBar = false;
        }
        private void InitCamera() //find the correct camera and intialize fifo
        {
            using (var fgs = new CogFrameGrabbers())
            {
                foreach(ICogFrameGrabber fg in fgs)
                {
                    var access = fg.OwnedGigEAccess;
                    string deviceUserID = access.GetFeature("DeviceUserID");
                    //MessageBox.Show($"Found GigE camera id={deviceUserID}");
                    if (deviceUserID == TargetCameraDeviceUserID)
                    {
                        if (myFrameGrabber == null)
                        {
                            myFrameGrabber = fg;
                        }
                        break;
                    }

                }
            }

            try
            {
                CogStringCollection AvailableVideoFormats = myFrameGrabber.AvailableVideoFormats;

                myFifo = myFrameGrabber.CreateAcqFifo(AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
                SetExposure(Exposure);

                cogDisplay1.StartLiveDisplay(myFifo);
            }

            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void SetExposure(double val) // set exposure of the camera
        {
            myFifo.OwnedExposureParams.Exposure = val;

        }
        #endregion
    }
}