using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Leap;

namespace LeapSigningMotion
{
    public partial class FrameDataForm : Form, ILeapEventDelegate
    {

        private Controller controller;
        private LeapEventlistener listener;
        public FrameDataForm()
        {
            InitializeComponent();
            this.controller = new Controller();
            this.listener = new LeapEventlistener(this);
            controller.AddListener(listener);
        }

        delegate void LeapEventDelegate(string eventName);
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void Form1_Load(object sender, EventArgs e) {}

        public void LeapEventNotification(string EventName)
        {
            if (!this.InvokeRequired)
            {
                switch (EventName)
                {
                    case "onInit":
                        Debug.WriteLine("Init");
                        break;

                    case "onConnect":
                        this.connectHandler();
                        break;

                    case "onFrame":
                        if (!this.Disposing)
                            this.newFrameHandler(this.controller.Frame());
                        break;
                }
            }
            else
            {
                BeginInvoke(new LeapEventDelegate (LeapEventNotification), new object[] {EventName});
            }
        }

        void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            this.controller.Config.SetFloat("Gesture.Circle.MinRadius", 40.0f);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        }

        void newFrameHandler(Frame frame)
        {
            this.displayID.Text = frame.Id.ToString();
            this.displayTimestamp.Text = frame.Timestamp.ToString();
            this.displayFPS.Text = frame.CurrentFramesPerSecond.ToString();
            this.displayIsValid.Text = frame.IsValid.ToString();
            this.displayGestureCount.Text = frame.Gestures().Count.ToString();
        }
        
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    if (components != null)
                    {
                        components.Dispose();
                    }
                    this.controller.RemoveListener(this.listener);
                    this.controller.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }
    }

    public interface ILeapEventDelegate
    {
        void LeapEventNotification(string EventName);
    }

    public class LeapEventlistener : Listener
    {
        ILeapEventDelegate eventDelegate;

        public LeapEventlistener(ILeapEventDelegate delegateObject)
        {
            this.eventDelegate = delegateObject;
        }

        public override void OnInit(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onInit");
        }

        public override void OnConnect(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onConnect");
        }

        public override void OnFrame(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onFrame");
        }

        public override void OnExit(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onExit");
        }

        public override void OnDisconnect(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onDisconnect");
        }
    }
}
