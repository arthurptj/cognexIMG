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

        #region Constructors

        public LiveDisplay()
        {
            InitializeComponent();
            InitDisplay();
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

        public string InitCamera(string name, double exposure = 0.5) //find the correct camera and intialize fifo
        {
            using (var fgs = new CogFrameGrabbers())
            {
                foreach (ICogFrameGrabber fg in fgs)
                {
                    var access = fg.OwnedGigEAccess;
                    string deviceUserID = access.GetFeature("DeviceUserID");
                    //MessageBox.Show($"Found GigE camera id={deviceUserID}");
                    if (deviceUserID == name)
                    {
                        if (myFrameGrabber == null)
                        {
                            myFrameGrabber = fg;
                        }
                        break;
                    }

                }
            }

            if (myFrameGrabber == null) return $"Unable to find camera '{name}'";

            CogStringCollection AvailableVideoFormats = myFrameGrabber.AvailableVideoFormats;

            myFifo = myFrameGrabber.CreateAcqFifo(AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
            SetExposure(exposure);

            cogDisplay1.StartLiveDisplay(myFifo);

            return "";
        }

        private void SetExposure(double val) // set exposure of the camera
        {
            myFifo.OwnedExposureParams.Exposure = val;

        }
        public CogDisplay Display => cogDisplay1;

        #endregion
    }
}