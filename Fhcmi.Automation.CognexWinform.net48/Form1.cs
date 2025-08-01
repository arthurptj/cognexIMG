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

namespace Fhcmi.Automation.CognexWinform.net48
{
    public partial class Form1 : Form
    {
        #region Fields

        CogFrameGrabbers myFrameGrabbers;
        ICogFrameGrabber myFrameGrabber = null;
        ICogAcqFifo myFifo;
        string FrontCamSerial = "H2856761";
        string BackCamSerial = "H2650398";
        string EpoxyCamSerial = "H2827415";

        #endregion

        #region Properties

        public string TargetCameraDeviceUserID { get; set; }
        
        #endregion


        #region Constructors

        public Form1()
        {
            InitializeComponent();
            InitDisplay();
            InitCamera();
        }

        #endregion

        #region Methods

        private void InitDisplay()
        {
            //configure cogdisplay
            cogDisplay1.AutoFit = true;
            cogDisplay1.MouseWheelMode = CogDisplayMouseWheelModeConstants.None;
            cogDisplay1.MouseMode = CogDisplayMouseModeConstants.Pointer;
            cogDisplay1.Dock = DockStyle.Fill;
            cogDisplay1.HorizontalScrollBar = false;
            cogDisplay1.VerticalScrollBar = false;
        }
        private void InitCamera()
        {
            using (var fgs = new CogFrameGrabbers())
            {
                foreach(ICogFrameGrabber fg in fgs)
                {
                    var access = fg.OwnedGigEAccess;
                    string deviceUserID = access.GetFeature("DeviceUserID");
                    MessageBox.Show($"Found GigE camera id={deviceUserID}");
                    if (myFrameGrabber == null)
                        myFrameGrabber = fg;
                }
            }

            //myFrameGrabbers = new CogFrameGrabbers();

            //if (myFrameGrabbers.Count < 3)
            //{
            //    MessageBox.Show("Can't find all three cameras", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
            //    return;
            //}

            //for (int i = 0; i <= myFrameGrabbers.Count; i++)
            //{
            //    ICogFrameGrabber grabber = myFrameGrabbers[i];

            //    if (grabber.SerialNumber == EpoxyCamSerial)
            //    {
            //        myFrameGrabber = grabber;
            //        break;
            //    }

            //}

            CogStringCollection AvailableVideoFormats = myFrameGrabber.AvailableVideoFormats;

            myFifo = myFrameGrabber.CreateAcqFifo(AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
            SetExposure(1);

            cogDisplay1.StartLiveDisplay(myFifo);

        }

        private void SetExposure(int val)
        {
            myFifo.OwnedExposureParams.Exposure = val;

        }

        #endregion
    }
}

