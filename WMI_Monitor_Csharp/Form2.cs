using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;

namespace WMI_Monitor_Csharp
{
    public partial class FormShort : Form
    {
        ManagementScope scope;
        SelectQuery query;
        ManagementObjectSearcher searcher;

        String cputotalnameStr, cputotalloadStr;
        String cpucorefreqStr, cpucorenameStr, cpucoretempStr, cpucoreloadStr;
        String gpucorenameStr, gpucoretempStr, gpucoreloadStr, gpucorefreqcoreStr, gpucorefreqmemStr;
        String osramusedStr, osramsizeStr, osramfreeprctStr;
        String systemnameStr;
        String systemipStr;
        int cputotalpbNum, cpuCount, cntr, gpu1pbNum, osramfreeprctNUM, xPos, yPos;
        Control pb;
        List<XY> chartXY;
        Boolean redrawForm = true;

        DateTime sysdate;
        int hour, minute, sec;
        float hourPartial;
        float minutePartial;

        float hourRadian, minuteRadian, secondRadian;
        float lengthofHourHand, lengthofMinuteHand, lengthofSecondHand;
        float hourStartPointX, hourStartPointY;
        float minuteStartPointX, minuteStartPointY;
        float secondStartPointX, secondStartPointY;
        float hourEndPointX, hourEndPointY;
        float minuteEndPointX, minuteEndPointY;
        float secondEndPointX, secondEndPointY;

        public FormShort(int xPosInit, int yPosInit)
        {
            InitializeComponent();
            this.Hide();
            //=================================================== 
            // Setup stuff
            //===================================================
            xPos = xPosInit;
            yPos = yPosInit;
            addButtonListeners();
            clearFormTextLabels();
            clearFormTempStrings();
            clearFormTempNumbers();
            initChartInfo();
            setAnalogClock();
            runOpenHardwareMonitor_Sensor();
            runWMI_Win32_OperatingSystem();
            runWMI_Win32_NetworkAdapterConfiguration();
            addFormListeners();
            startupLocation();
            resizeFormBackground();
            
            //=================================================== 
            // Done with static
            //===================================================
        }

        public class XY
        {
            public double X;
            public double cpuY;
            public double gpuY;
            public double memY;

            public double XValue
            {
                get { return X; }
                set { X = value; }
            }

            public double CPUYValue
            {
                get { return cpuY; }
                set { cpuY = value; }
            }

            public double GPUYValue
            {
                get { return gpuY; }
                set { gpuY = value; }
            }

            public double MEMYValue
            {
                get { return memY; }
                set { memY = value; }
            }
            public XY(double X, double cpuY, double gpuY, double memY)
            {
                this.X = X;
                this.cpuY = cpuY;
                this.gpuY = gpuY;
                this.memY = memY;
            }
        }

        private void timerFast_Tick(object sender, EventArgs e)
        {
            setAnalogClock();
            runWMI_Win32_OperatingSystem();
            runOpenHardwareMonitor_Sensor();
            updateChartInfo();
            if (redrawForm) { resizeFormBackground(); }  
        }

        private void timerSlow_Tick(object sender, EventArgs e)
        {
        }

        //=====================================================
        // Setup Stuff
        //=====================================================

        private void startupLocation()
        {
            this.Top = yPos;
            this.Left = xPos;
            //this.Top = 0;
            //this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10;
        }
        
        private void addFormListeners()
        {
           cpucoretemp.SizeChanged += new EventHandler(resizeFormHandler);
        }

        private void addButtonListeners()
        {
            buttonMove.MouseDown += new System.Windows.Forms.MouseEventHandler(buttonMove_MouseDown);
            buttonMove.MouseEnter += new EventHandler(buttonMove_MouseEnter);
            buttonMove.MouseLeave += new EventHandler(buttonMove_MouseLeave);
            areaMove.MouseDown += new System.Windows.Forms.MouseEventHandler(areaMove_MouseDown);
            buttonClose.MouseEnter += new EventHandler(buttonClose_MouseEnter);
            buttonClose.MouseLeave += new EventHandler(buttonClose_MouseLeave);
            buttonMin.MouseEnter += new EventHandler(buttonMin_MouseEnter);
            buttonMin.MouseLeave += new EventHandler(buttonMin_MouseLeave);
            buttonLongForm.MouseEnter += new EventHandler(buttonLongForm_MouseEnter);
            buttonLongForm.MouseLeave += new EventHandler(buttonLongForm_MouseLeave);
        }

        private void clearFormTextLabels()
        {
            cputotalname.Text = cputotaltemp.Text = cputotalload.Text = "";
            cpucorefreq.Text = cpucorename.Text = cpucoretemp.Text = cpucoreload.Text = "";
            gpucoretemp.Text = gpucoreload.Text = gpucorefreq.Text = "";
            osramused.Text = osramsize.Text = osramfreeprct.Text = "";
            systemname.Text = systemtime.Text = systemdate.Text = "";
            systemip.Text = "";
        }

        private void clearFormTempStrings()
        {
            cputotalnameStr = cputotalloadStr = "";
            cpucorefreqStr = cpucorenameStr = cpucoretempStr = cpucoreloadStr = "";
            gpucorenameStr = gpucoretempStr = gpucoreloadStr = gpucorefreqcoreStr = gpucorefreqmemStr = "";
            osramusedStr = osramsizeStr = osramfreeprctStr = "";
            systemnameStr = "";
            systemipStr = "";
        }

        private void clearFormTempNumbers()
        {
            cputotalpbNum = gpu1pbNum = osramfreeprctNUM = 0;
        }

        private void initChartInfo()
        {
            chartXY = new List<XY>();

            for (int i = 0; i < 50; i++)
            {
                chartXY.Add(new XY(i, 0, 0, 0));
            }

            chart1.DataSource = chartXY;
            chart1.DataBind();
        }

        private void setAnalogClock()
        {
            sysdate = DateTime.Now;
            hour = sysdate.Hour % 12;
            hourPartial = sysdate.Hour % 12 + (float)sysdate.Minute / 60;
            minute = sysdate.Minute;
            minutePartial = sysdate.Minute + (float)sysdate.Second / 60;
            sec = sysdate.Second;

            systemdate.Text = sysdate.ToString("D");
            systemtime.Text = "Now " + sysdate.ToString("T");

            hourRadian = hourPartial * 360 / 12 * (float)Math.PI / 180;
            minuteRadian = minutePartial * 360 / 60 * (float)Math.PI / 180;
            secondRadian = sec * 360 / 60 * (float)Math.PI / 180;
            lengthofHourHand = (float)25; // lineHourHand;
            lengthofMinuteHand = (float)32; // lineMinHand;
            lengthofSecondHand = (float)32; // lineSecHand;
            hourStartPointX = lineHourHand.X1;
            hourStartPointY = lineHourHand.Y1;
            minuteStartPointX = lineMinHand.X1;
            minuteStartPointY = lineMinHand.Y1;
            secondStartPointX = lineSecHand.X1;
            secondStartPointY = lineSecHand.Y1;
            hourEndPointX = lengthofHourHand * (float)Math.Sin(hourRadian);
            hourEndPointY = lengthofHourHand * (float)Math.Cos(hourRadian);
            minuteEndPointX = lengthofMinuteHand * (float)Math.Sin(minuteRadian);
            minuteEndPointY = lengthofMinuteHand * (float)Math.Cos(minuteRadian);
            secondEndPointX = lengthofSecondHand * (float)Math.Sin(secondRadian);
            secondEndPointY = lengthofSecondHand * (float)Math.Cos(secondRadian);
            lineHourHand.X2 = (int)hourStartPointX + (int)hourEndPointX;
            lineHourHand.Y2 = (int)hourStartPointY - (int)hourEndPointY;
            lineMinHand.X2 = (int)minuteStartPointX + (int)minuteEndPointX;
            lineMinHand.Y2 = (int)minuteStartPointY - (int)minuteEndPointY;
            lineSecHand.X2 = (int)secondStartPointX + (int)secondEndPointX;
            lineSecHand.Y2 = (int)secondStartPointY - (int)secondEndPointY;
        }

        private void runOpenHardwareMonitor_Sensor()
        {
            scope = new ManagementScope("\\root\\OpenHardwareMonitor");
            query = new SelectQuery("Sensor");
            searcher = new ManagementObjectSearcher(scope, query);
            double tot = 0.0;
            cpuCount = 0;
            cntr = 1;
            cpucorenameStr = cpucoretempStr = cputotalnameStr = "";
            cputotalloadStr = cpucoreloadStr = cpucorefreqStr = "";
            gpucorenameStr = gpucoretempStr = gpucoreloadStr = "";
            gpu1pbNum = 0;
            gpucorefreqcoreStr = gpucorefreqmemStr = "";
            foreach (ManagementBaseObject envVar in searcher.Get())
            {
                String nameStr = (String)envVar["Name"];
                if (envVar["SensorType"].Equals("Temperature") && nameStr.IndexOf("CPU Core #") > -1)
                {
                    float flt = (float)envVar["Value"];
                    tot += (double)(0.0 + flt);
                    cpuCount += 1;
                    String shortName = nameStr;
                    shortName = shortName.Substring(4);
                    cpucorenameStr += (shortName + "\r\n");
                    cpucoretempStr += ("" + envVar["Value"] + (char)176 + "C\r\n");
                }
                else if (envVar["SensorType"].Equals("Load") && nameStr.IndexOf("CPU Total") > -1)
                {
                    cputotalnameStr += nameStr;
                    float flt = (float)envVar["Value"];
                    cputotalpbNum = (int)flt;
                    cputotalloadStr += ("" + (String)(flt.ToString("F1")) + " %");
                }
                else if (envVar["SensorType"].Equals("Load") && nameStr.IndexOf("CPU Core #") > -1)
                {
                    float dbl = (float)envVar["Value"];
                    cpucoreloadStr += ("" + (String)(dbl.ToString("F1")) + " %\r\n");
                    pb = Controls.Find("cpu" + cntr + "pb", true)[0];
                    (pb as ProgressBar).Value = (int)dbl;
                    cntr += 1;
                }
                else if (envVar["SensorType"].Equals("Clock") && nameStr.IndexOf("CPU Core #") > -1)
                {
                    float c = (float)envVar["Value"];
                    c /= (float)1024.0;
                    cpucorefreqStr += ("" + (String)(c.ToString("F2")) + " GHz\r\n");
                }
                else if (envVar["SensorType"].Equals("Temperature") && nameStr.IndexOf("GPU") > -1)
                {
                    gpucorenameStr += (nameStr + "\r\n");
                    gpucoretempStr += ("GPU:  " + envVar["Value"] + (char)176 + "C\r\n");
                }
                else if (envVar["SensorType"].Equals("Load") && nameStr.IndexOf("GPU") > -1)
                {
                    if (nameStr.Equals("GPU Core"))
                    {
                        float dbl = (float)envVar["Value"];
                        gpu1pbNum = (int)dbl;
                        gpucoreloadStr += ("" + (String)(dbl.ToString("F1")) + " %\r\n");
                    }
                }
                else if (envVar["SensorType"].Equals("Clock") && nameStr.IndexOf("GPU") > -1)
                {
                    if (nameStr.IndexOf("GPU Core") > -1)
                    {
                        float c = (float)envVar["Value"];
                        gpucorefreqcoreStr += ("" + (String)(c.ToString("F0")) + "MHz");
                    }
                    else if (nameStr.IndexOf("GPU Memory") > -1)
                    {
                        float m = (float)envVar["Value"] / (float)1024;
                        gpucorefreqmemStr += (" / " + (String)(m.ToString("F1")) + "GHz\r\n");
                    }
                }
            }
            if (tot > 0)
            {
                cputotaltemp.Text = ("" + (tot / (double)cpuCount).ToString("F0") + (char)176 + "C\r\n");
            }
            cpucorename.Text = cpucorenameStr;
            cpucoretemp.Text = cpucoretempStr;
            cputotalname.Text = cputotalnameStr;
            cputotalload.Text = cputotalloadStr;
            cputotalpb.Value = cputotalpbNum;
            cntr = 1;
            cpucoreload.Text = cpucoreloadStr;
            cpucoreload.Height = 16 * cpuCount;
            cpucorefreq.Text = cpucorefreqStr;
            gpucoretemp.Text = gpucoretempStr;
            gpucoreload.Text = gpucoreloadStr;
            gpu1pb.Value = gpu1pbNum;
            gpucorefreq.Text = "" + gpucorefreqcoreStr + gpucorefreqmemStr;
            cpu4pb.Visible = (cpuCount >= 4);
            cpu3pb.Visible = (cpuCount >= 3);
        }

        private void runWMI_Win32_OperatingSystem()
        {
            scope = new ManagementScope("\\root\\cimv2");
            query = new SelectQuery("Win32_OperatingSystem");
            searcher = new ManagementObjectSearcher(scope, query);
            osramsizeStr = osramusedStr = osramfreeprctStr = "";
            systemnameStr = "";
            osramfreeprctNUM = 0;
            foreach (ManagementBaseObject envVar in searcher.Get())
            {
                UInt64 fm, m, um;
                double dfm, dm, dum, dfmp;
                if (envVar["FreePhysicalMemory"] != null)
                {
                    fm = (UInt64)envVar["FreePhysicalMemory"];
                    m = (UInt64)envVar["TotalVisibleMemorySize"];
                    um = m - fm;
                    dfm = ((double)fm / 1024.0) / 1024.0;
                    dm = ((double)m / 1024.0) / 1024.0;
                    dum = ((double)um / 1024.0) / 1024.0;
                    dfmp = (dum / dm) * 100;
                    osramfreeprctNUM = (int)dfmp;
                    osramsizeStr += ("RAM:   " + dm.ToString("F2") + " GB\r\n");
                    osramusedStr += ("Used: " + dum.ToString("F2") + " GB\r\n"); ;
                    osramfreeprctStr += ("" + dfmp.ToString("F1") + " %\r\n");
                }
                systemnameStr = (String)envVar["CSName"];
            }
            osramsize.Text = osramsizeStr;
            osramused.Text = osramusedStr;
            osramfreeprct.Text = osramfreeprctStr;
            systemname.Text = systemnameStr;
        }

        private void runWMI_Win32_NetworkAdapterConfiguration()
        {
            scope = new ManagementScope("\\root\\cimv2");
            query = new SelectQuery("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
            searcher = new ManagementObjectSearcher(scope, query);
            systemipStr = "";
            foreach (ManagementBaseObject envVar in searcher.Get())
            {
                String[] strArr = (String[])envVar["IPAddress"];
                systemipStr += "IP: " + strArr[0] + "\r\n";
            }
            systemip.Text = systemipStr;
        }

        private void updateChartInfo()
        {
            for (int i = 0; i < 49; i++)
            {
                chartXY.ElementAt(i).CPUYValue = chartXY.ElementAt(i + 1).CPUYValue;
                chartXY.ElementAt(i).GPUYValue = chartXY.ElementAt(i + 1).GPUYValue;
                chartXY.ElementAt(i).MEMYValue = chartXY.ElementAt(i + 1).MEMYValue;
            }
            chartXY.ElementAt(49).CPUYValue = cputotalpbNum;
            chartXY.ElementAt(49).GPUYValue = gpu1pbNum;
            chartXY.ElementAt(49).MEMYValue = osramfreeprctNUM;

            chart1.DataBind();
        }

        private void resizeFormHandler(object sender, EventArgs e)
        {
            redrawForm = true;
        }

        private void resizeFormBackground()
        {
            lineShape1.Y1 = lineShape1.Y2 = cpucoretemp.Height + cpucoretemp.Location.Y + 4;
            gpucoretemp.Top = gpucorefreq.Top = gpucoreload.Top = lineShape1.Y1 + 4;
            gpu1pb.Top = gpucoretemp.Location.Y+2;
            lineShape2.Y1 = lineShape2.Y2 = gpucoretemp.Height + gpucoretemp.Location.Y + 4;
            osramsize.Top = osramused.Top = osramfreeprct.Top = lineShape2.Y1 + 4;
            lineShape5.Y1 = lineShape5.Y2 = osramsize.Location.Y + osramsize.Height + 4;
            chart1.Top = lineShape5.Y1 + 4;
            //panel1.Height = cpucoretemp.Height + cpucoretemp.Location.Y + 4;
            rectangleShape3.Height = panel1.Height - 4;
            redrawForm = false;
        }

        //=====================================================
        // Button Event Stuff
        //=====================================================

        private void buttonClose_Click(object sender, EventArgs e)
        {
            int exitcodeint = 0;
            Environment.Exit(exitcodeint);
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.closeButtonOn;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.closeButtonOff;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonMin_MouseEnter(object sender, EventArgs e)
        {
            buttonMin.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.minButtonOn;
        }

        private void buttonMin_MouseLeave(object sender, EventArgs e)
        {
            buttonMin.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.minButtonOff;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            buttonMove.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.moveButtonOn;
        }

        private void buttonMove_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            buttonMove.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.moveButtonOn;
        }

        private void buttonMove_MouseEnter(object sender, EventArgs e)
        {
            buttonMove.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.moveButtonOn;
        }

        private void buttonMove_MouseLeave(object sender, EventArgs e)
        {
            buttonMove.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.moveButtonOff;
        }

        private void areaMove_Click(object sender, EventArgs e)
        {

        }

        private void areaMove_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void buttonLongForm_MouseEnter(object sender, EventArgs e)
        {
            buttonLongForm.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.formLongButtonOn;
        }

        private void buttonLongForm_MouseLeave(object sender, EventArgs e)
        {
            buttonLongForm.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.formLongButtonOff;
        }

        private void buttonLongForm_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();            
            this.Close();
        }

        public void ThreadProc()
        {
            xPos = this.Location.X;
            yPos = this.Location.Y;
            FormLong f = new FormLong(xPos, yPos);
            //f.SetDesktopLocation(this.Location.X, this.Location.Y);
            Application.Run(f);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Monitor Application\nby Mark Becker\n© June 2012");
        }

        private void FormShort_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                ShowInTaskbar = false;
            } else if (WindowState != FormWindowState.Minimized)
            {
                Show();
                ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItemShowHide_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else if (WindowState != FormWindowState.Minimized)
            {
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
            }
            this.ShowInTaskbar = false;
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            int exitcodeint = 0;
            Environment.Exit(exitcodeint);
        }

        private void toolStripMenuItemGoToLong_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close(); 
        }

        //added to make dragable button
        // from http:// www.codeproject.com/Articles/11114/Move-window-form-without-Titlebar-in-C
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // done added

        //added to set 'taskbar' click to minimize
        // from http: //stackoverflow.com/questions/5180609/how-to-minimize-form-from-taskbar
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        // done added
    }
}