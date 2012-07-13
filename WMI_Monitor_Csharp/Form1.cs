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
    public partial class FormLong : Form
    {
        ManagementScope scope;
        SelectQuery query;
        ManagementObjectSearcher searcher;

        String cpunameStr, cputotalnameStr, cputotalloadStr;
        String cpucorefreqStr, cpucorenameStr, cpucoretempStr, cpucoreloadStr;
        String gpunameStr, gpucorenameStr, gpucoretempStr, gpucoreloadStr, gpumemStr, gpumempercStr, gpucorefreqcoreStr, gpucorefreqmemStr;
        String hddnameStr, hddfreespaceStr, hddsizeStr, hddfreeprctStr;
        String osramusedStr, osramsizeStr, osramfreeprctStr;
        String ramnameStr, ramfreqStr, ramsizeStr;
        String fannameStr, fanspeedStr, fanspeedmaxStr;
        String systemnameStr;
        String systemipStr, systemuptimeStr;
        int cputotalpbNum, cpuCount, cntr, gpu1pbNum, gpu2pbNum, osramfreeprctNUM, xPos, yPos;
        UInt32 gpumemnum;
        Control pb;
        List<XY> chartXY;
        Boolean redrawForm = true;        

        DateTime sysDate, sysBootDate;
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

        public FormLong(int xPosInit, int yPosInit)
        {
            InitializeComponent();
            this.Hide();
            //=================================================== 
            // Setup stuff
            //===================================================

            this.ResizeRedraw = true;
            xPos = xPosInit;
            yPos = yPosInit;
            addButtonListeners();
            clearFormTextLabels();
            clearFormTempStrings();
            clearFormTempNumbers();
            initChartInfo();
            getSystemBootTime();
            setAnalogClock();
            runOpenHardwareMonitor_Sensor();
            runOpenHardwareMonitor_Hardware();
            runWMI_Win32_VideoController();
            runWMI_Win32_LogicalDisk();
            runWMI_Win32_OperatingSystem();
            runWMI_Win32_PhysicalMemory();
            runWMI_Win32_NetworkAdapterConfiguration();
            runWin32_PerfFormattedData_PerfProc_Process();
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
            runOpenHardwareMonitor_Hardware();
            runWin32_PerfFormattedData_PerfProc_Process();
            updateChartInfo();
            if (redrawForm) { resizeFormBackground(); }
        }

        private void timerSlow_Tick(object sender, EventArgs e)
        {
            runWMI_Win32_LogicalDisk();
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
            fanname.SizeChanged += new EventHandler(resizeFormHandler);
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
            buttonShortForm.MouseEnter += new EventHandler(buttonShortForm_MouseEnter);
            buttonShortForm.MouseLeave += new EventHandler(buttonShortForm_MouseLeave);
        }

        private void clearFormTextLabels()
        {
            cpuname.Text = cputotalname.Text = cputotaltemp.Text = cputotalload.Text = "";
            cpucorefreq.Text = cpucorename.Text = cpucoretemp.Text = cpucoreload.Text = "";
            gpuname.Text = gpucoretemp.Text = gpucoreload.Text = gpucorefreq.Text = "";
            hddname.Text = hddfreespace.Text = hddsize.Text = hddfreeprct.Text = "";
            osramused.Text = osramsize.Text = osramfreeprct.Text = "";
            ramname.Text = ramfreq.Text = ramsize.Text = "";
            fanname.Text = fanspeed.Text = fanspeedmax.Text = "";
            systemname.Text = systemtime.Text = systemdate.Text = "";
            systemip.Text = systemuptime.Text = systemboottime.Text = "";
        }

        private void clearFormTempStrings()
        {
            cpunameStr = cputotalnameStr = cputotalloadStr = "";
            cpucorefreqStr = cpucorenameStr = cpucoretempStr = cpucoreloadStr = "";
            gpunameStr = gpucorenameStr = gpucoretempStr = gpucoreloadStr = gpumemStr = gpumempercStr = gpucorefreqcoreStr = gpucorefreqmemStr = "";
            hddnameStr = hddfreespaceStr = hddsizeStr = hddfreeprctStr = "";
            osramusedStr = osramsizeStr = osramfreeprctStr = "";
            ramnameStr = ramfreqStr = ramsizeStr = "";
            fannameStr = fanspeedStr = fanspeedmaxStr = "";
            systemnameStr = "";
            systemipStr = systemuptimeStr = "";
        }

        private void clearFormTempNumbers()
        {
            cputotalpbNum = gpu1pbNum =  gpu2pbNum = osramfreeprctNUM = 0;
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

        private void getSystemBootTime()
        {
            scope = new ManagementScope("\\root\\cimv2");
            query = new SelectQuery("Win32_OperatingSystem");
            searcher = new ManagementObjectSearcher(scope, query);
            String lastBootUpTime = "";
            foreach (ManagementBaseObject envVar in searcher.Get())
            {
                lastBootUpTime = (String)envVar["LastBootUpTime"];
            }
            sysBootDate = new DateTime(
                Int32.Parse(lastBootUpTime.Substring(0, 4)),
                Int32.Parse(lastBootUpTime.Substring(4, 2)),
                Int32.Parse(lastBootUpTime.Substring(6, 2)),
                Int32.Parse(lastBootUpTime.Substring(8, 2)),
                Int32.Parse(lastBootUpTime.Substring(10, 2)),
                Int32.Parse(lastBootUpTime.Substring(12, 2)));
            systemboottime.Text = "Boot " + (String)sysBootDate.ToString("hh:mm:ss tt");
        }

        private void setAnalogClock()
        {
            sysDate = DateTime.Now;
            hour = sysDate.Hour % 12;
            hourPartial = sysDate.Hour % 12 + (float)sysDate.Minute / 60;
            minute = sysDate.Minute;
            minutePartial = sysDate.Minute + (float)sysDate.Second / 60;
            sec = sysDate.Second;

            systemdate.Text = sysDate.ToString("D");
            systemtime.Text = "Now " + sysDate.ToString("T");

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
            gpucorenameStr = gpucoretempStr = gpucoreloadStr = gpumemStr = gpumempercStr = "";
            gpu1pbNum = 0;
            gpucorefreqcoreStr = gpucorefreqmemStr = "";
            fannameStr = fanspeedStr = fanspeedmaxStr = "";
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
                    gpucoretempStr += ("" + envVar["Value"] + (char)176 + "C\r\n");
                }
                else if (envVar["SensorType"].Equals("Load") && nameStr.IndexOf("GPU") > -1)
                {
                    if (nameStr.Equals("GPU Core"))
                    {
                        float dbl = (float)envVar["Value"];
                        gpu1pbNum = (int)dbl;
                        gpucoreloadStr += ("" + (String)(dbl.ToString("F1")) + " %\r\n");
                    } 
                    if (nameStr.Equals("GPU Memory"))
                    {
                        float dbl = (float)envVar["Value"];
                        float memused = (((float)gpumemnum * (float)(dbl/100.00))/1024)/1024 ;
                        gpu2pbNum = (int)dbl;
                        gpumemStr += ("Memory:  " + memused.ToString("F0") +
                            " MB / " + ((gpumemnum/1024)/1024).ToString("F0") + " MB");
                        gpumempercStr += (String)(dbl.ToString("F1")) + " %";
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
                else if (envVar["SensorType"].Equals("Fan") || envVar["SensorType"].Equals("Control"))
                {
                    fannameStr += (nameStr + "\r\n");
                    if (nameStr.Equals("GPU Fan"))
                    {
                        fanspeedStr += ("" + envVar["Value"] + " %\r\n");
                        fanspeedmaxStr += ("" + envVar["Max"] + " %  Max\r\n");
                    }
                    else
                    {
                        fanspeedStr += ("" + ((float)envVar["Value"]).ToString("F0") + " RPM\r\n");
                        fanspeedmaxStr += ("" + ((float)envVar["Max"]).ToString("F0") + " RPM  Max\r\n");
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
            gpumem.Text = gpumemStr;
            gpumemperc.Text = gpumempercStr;
            gpu1pb.Value = gpu1pbNum;
            gpu2pb.Value = gpu2pbNum;
            gpucorefreq.Text = "" + gpucorefreqcoreStr + gpucorefreqmemStr;
            fanname.Text = fannameStr;
            fanspeed.Text = fanspeedStr;
            fanspeedmax.Text = fanspeedmaxStr;
            if (gpumemStr.Length <= 0) { gpumem.Text = "Memory:  " + ((gpumemnum / 1024) / 1024).ToString("F0") + " MB"; gpu2pb.Visible = false; }
            cpu4pb.Visible = (cpuCount >= 4);
            cpu3pb.Visible = (cpuCount >= 3);
        }

        private void runOpenHardwareMonitor_Hardware()
        {
            scope = new ManagementScope("\\root\\OpenHardwareMonitor");
            query = new SelectQuery("Hardware");
            searcher = new ManagementObjectSearcher(scope, query);
            cpunameStr = "";
            gpunameStr = "";
            foreach (ManagementBaseObject envVar in searcher.Get())
            {
                if (envVar["HardwareType"].Equals("CPU"))
                {
                    cpunameStr += ((String)envVar["Name"] + "\r\n");
                }
                else if (envVar["HardwareType"].Equals("GpuAti") || envVar["HardwareType"].Equals("GpuNvidia"))
                {
                    gpunameStr += ("" + envVar["Name"] + "");
                }
            }
            cpuname.Text = cpunameStr;
            gpuname.Text = gpunameStr;
        }

        private void runWMI_Win32_LogicalDisk()
        {
            scope = new ManagementScope("\\root\\cimv2");
            query = new SelectQuery("Win32_LogicalDisk");
            searcher = new ManagementObjectSearcher(scope, query);
            hddnameStr = hddfreespaceStr = hddsizeStr = hddfreeprctStr = "";
            foreach (ManagementBaseObject envVar in searcher.Get())
            {
                UInt64 fs, s;
                double dfs, ds, dfsp;
                if (envVar["FreeSpace"] != null)
                {
                    fs = (UInt64)envVar["FreeSpace"];
                    s = (UInt64)envVar["Size"];
                    fs = (fs / 1024) / 1024;
                    s = (s / 1024) / 1024;
                    dfs = ((double)fs / 1024.0);
                    ds = ((double)s / 1024.0);
                    dfsp = (dfs / ds) * 100;
                    hddnameStr += ("" + (String)envVar["Name"] + " (" + (String)envVar["VolumeName"] + ")\r\n");
                    hddfreespaceStr += ("" + dfs.ToString("F1") + " GB /\r\n");
                    hddsizeStr += ("" + ds.ToString("F1") + " GB\r\n");
                    hddfreeprctStr += ("" + dfsp.ToString("F1") + " %\r\n");
                }
            }
            hddname.Text = hddnameStr;
            hddfreespace.Text = hddfreespaceStr;
            hddsize.Text = hddsizeStr;
            hddfreeprct.Text = hddfreeprctStr;
        }

        private void runWMI_Win32_OperatingSystem()
        {
            scope = new ManagementScope("\\root\\cimv2");
            query = new SelectQuery("Win32_OperatingSystem");
            searcher = new ManagementObjectSearcher(scope, query);
            osramsizeStr = osramusedStr = osramfreeprctStr = "";
            systemnameStr = systemuptimeStr = "";
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
                    osramsizeStr += ("Total: " + dm.ToString("F2") + " GB\r\n");
                    osramusedStr += ("Used: " + dum.ToString("F2") + " GB\r\n"); ;
                    osramfreeprctStr += ("" + dfmp.ToString("F1") + " %\r\n");
                }
                systemnameStr = (String)envVar["CSName"];
            }
            // Figure out uptime
            sysDate = DateTime.Now;
            int daDif = ((TimeSpan)(sysDate - sysBootDate)).Days;
            int hoDif = ((TimeSpan)(sysDate - sysBootDate)).Hours;
            int miDif = ((TimeSpan)(sysDate - sysBootDate)).Minutes;
            int seDif = ((TimeSpan)(sysDate - sysBootDate)).Seconds;
            systemuptimeStr = "Uptime " + daDif.ToString("00") + "d:" + hoDif.ToString("00")
                + "h:" + miDif.ToString("00") + "m:" + seDif.ToString("00") + "s";

            osramsize.Text = osramsizeStr;
            osramused.Text = osramusedStr;
            osramfreeprct.Text = osramfreeprctStr;
            systemname.Text = systemnameStr;
            systemuptime.Text = systemuptimeStr;
        }

        private void runWMI_Win32_PhysicalMemory()
        {
            scope = new ManagementScope("\\root\\cimv2");
            query = new SelectQuery("Win32_PhysicalMemory");
            searcher = new ManagementObjectSearcher(scope, query);
            ramnameStr = ramfreqStr = ramsizeStr = "";
            foreach (ManagementBaseObject envVar in searcher.Get())
            {
                UInt64 f, c;
                double df, dc, dfcp;
                if (envVar["Capacity"] != null)
                {
                    f = (UInt32)envVar["Speed"];
                    c = (UInt64)envVar["Capacity"];
                    df = ((double)f / 1024.0);
                    dc = (((double)c / 1024.0) / 1024.0) / 1024.0;
                    dfcp = (df / dc) * 100;
                    ramnameStr += ("" + (String)envVar["BankLabel"] + "\r\n");
                    ramfreqStr += ("" + f.ToString("F0") + " MHz\r\n");
                    ramsizeStr += ("" + dc.ToString("F2") + " GB\r\n");
                }
            }
            ramname.Text = ramnameStr;
            ramfreq.Text = ramfreqStr;
            ramsize.Text = ramsizeStr;
        }

        private void runWin32_PerfFormattedData_PerfProc_Process()
        {
            scope = new ManagementScope("\\root\\cimv2");
            query = new SelectQuery("Win32_PerfFormattedData_PerfProc_Process");
            searcher = new ManagementObjectSearcher(scope, query);
            String[] sysProcess = { "", "", "", "", "" };
            UInt64[] sysProcessMax = { 0, 0, 0, 0, 0 };
            String outStr = "";
            String outMaxStr = "";
            int len = sysProcessMax.Length;
            foreach (ManagementBaseObject envVar in searcher.Get())
            {
                UInt64 tempVal = (UInt64)envVar["WorkingSetPrivate"];
                String tempName = (String)envVar["Name"];
                if (!tempName.ToString().Equals("_Total"))
                {
                    int i = 0;
                    Boolean test = true;
                    while ((i < len) && test)
                    {
                        if (tempVal > sysProcessMax[i])
                        {
                            test = false;
                            for (int j = len - 1; j > i; j--)
                            {
                                sysProcessMax[j] = sysProcessMax[(j - 1)];
                                sysProcess[j] = sysProcess[(j - 1)];
                            }
                            sysProcessMax[i] = tempVal;
                            sysProcess[i] = tempName;
                        }
                        i++;
                    }
                }
            }
            outStr = "1. " + sysProcess[0];
            outMaxStr = "" + ((sysProcessMax[0] / 1024) / 1024) + " MB";
            for (int i = 1; i < len; i++)
            {
                outStr += "\n\r" + i + ". " + sysProcess[i];
                outMaxStr += "\n\r" + ((sysProcessMax[i] / 1024) / 1024) + " MB";
            }
            topsysname.Text = outStr;
            topsysnum.Text = outMaxStr;
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

        private void runWMI_Win32_VideoController()
        {
            scope = new ManagementScope("\\root\\cimv2");
            query = new SelectQuery("Win32_VideoController");
            searcher = new ManagementObjectSearcher(scope, query);
            gpumemnum = 0;
            foreach (ManagementBaseObject envVar in searcher.Get())
            {
                if ((envVar["AdapterRAM"] != null) && (envVar["AdapterRAM"].ToString().IndexOf("VNC") < 0))
                {
                    gpumemnum = (UInt32)envVar["AdapterRAM"];
                }                
            }
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
            panel3.Height = cpucoretemp.Height + cpucoretemp.Location.Y + 10;
            panel6.Height = ramsize.Height + ramsize.Location.Y + 4;
            panel7.Height = hddfreespace.Height + hddfreespace.Location.Y + 10;
            panel8.Height = fanspeed.Height + fanspeed.Location.Y + 10;
            panel9.Height = topsysname.Height + topsysname.Location.Y + 10;
            rectangleShape2.Height = panel3.Height - 4;
            rectangleShape6.Height = panel6.Height - 4;
            rectangleShape7.Height = panel7.Height - 4;
            rectangleShape8.Height = panel8.Height - 4;
            rectangleShape9.Height = panel9.Height - 4;
            if (fanspeed.Text.Length <= 0) { panel8.Visible = false; }
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

        private void buttonShortForm_MouseEnter(object sender, EventArgs e)
        {
            buttonShortForm.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.formShortButtonOn;
        }

        private void buttonShortForm_MouseLeave(object sender, EventArgs e)
        {
            buttonShortForm.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.formShortButtonOff;
        }

        private void buttonShortForm_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();            
        }

        public void ThreadProc()
        {
            xPos = this.Location.X;
            yPos = this.Location.Y;
            FormShort f = new FormShort(xPos, yPos);
            //f.SetDesktopLocation(this.Location.X, this.Location.Y);
            Application.Run(f);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Monitor Application\nby Mark Becker\n© June 2012");
        } 

        private void FormLong_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            } else if (WindowState != FormWindowState.Minimized)
            {
                this.Show();
            }
            this.ShowInTaskbar = false;
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

        private void toolStripMenuItemGoToShort_Click(object sender, EventArgs e)
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

        //added to set 'taskbar click' to minimize
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