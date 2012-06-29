namespace WMI_Monitor_Csharp
{
    partial class FormShort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShort));
            this.cpucorename = new System.Windows.Forms.Label();
            this.cpucoretemp = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.osramused = new System.Windows.Forms.Label();
            this.osramsize = new System.Windows.Forms.Label();
            this.osramfreeprct = new System.Windows.Forms.Label();
            this.gpu1pb = new System.Windows.Forms.ProgressBar();
            this.gpucorefreq = new System.Windows.Forms.Label();
            this.gpucoreload = new System.Windows.Forms.Label();
            this.gpucoretemp = new System.Windows.Forms.Label();
            this.cpu4pb = new System.Windows.Forms.ProgressBar();
            this.cpu3pb = new System.Windows.Forms.ProgressBar();
            this.cpu2pb = new System.Windows.Forms.ProgressBar();
            this.cpu1pb = new System.Windows.Forms.ProgressBar();
            this.cputotalpb = new System.Windows.Forms.ProgressBar();
            this.cpucorefreq = new System.Windows.Forms.Label();
            this.cputotalload = new System.Windows.Forms.Label();
            this.cputotalname = new System.Windows.Forms.Label();
            this.cputotaltemp = new System.Windows.Forms.Label();
            this.cpucoreload = new System.Windows.Forms.Label();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonLongForm = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.areaMove = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer6 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.systemip = new System.Windows.Forms.Label();
            this.systemdate = new System.Windows.Forms.Label();
            this.systemname = new System.Windows.Forms.Label();
            this.systemtime = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineSecHand = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineHourHand = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineMinHand = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timerFast = new System.Windows.Forms.Timer(this.components);
            this.timerSlow = new System.Windows.Forms.Timer(this.components);
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpucorename
            // 
            this.cpucorename.AccessibleName = "cpucorename";
            this.cpucorename.AutoSize = true;
            this.cpucorename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cpucorename.ForeColor = System.Drawing.Color.White;
            this.cpucorename.Location = new System.Drawing.Point(6, 25);
            this.cpucorename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpucorename.Name = "cpucorename";
            this.cpucorename.Size = new System.Drawing.Size(69, 15);
            this.cpucorename.TabIndex = 0;
            this.cpucorename.Text = "cpucorename";
            // 
            // cpucoretemp
            // 
            this.cpucoretemp.AccessibleName = "cpucoretemp";
            this.cpucoretemp.AutoSize = true;
            this.cpucoretemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cpucoretemp.ForeColor = System.Drawing.Color.White;
            this.cpucoretemp.Location = new System.Drawing.Point(56, 25);
            this.cpucoretemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpucoretemp.Name = "cpucoretemp";
            this.cpucoretemp.Size = new System.Drawing.Size(67, 15);
            this.cpucoretemp.TabIndex = 1;
            this.cpucoretemp.Text = "cpucoretemp";
            this.cpucoretemp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX.LineColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY.LineColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 69.26087F;
            chartArea1.Position.Width = 95F;
            chartArea1.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.AutoFitMinFontSize = 6;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 141);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.LegendText = "CPU";
            series1.Name = "cpuchart";
            series1.XValueMember = "XValue";
            series1.YValueMembers = "CPUYValue";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.RoyalBlue;
            series2.Legend = "Legend1";
            series2.LegendText = "GPU";
            series2.Name = "gpuchart";
            series2.XValueMember = "XValue";
            series2.YValueMembers = "GPUYValue";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.LegendText = "RAM";
            series3.Name = "memchart";
            series3.XValueMember = "XValue";
            series3.YValueMembers = "MEMYValue";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(216, 77);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // osramused
            // 
            this.osramused.AccessibleName = "osramused";
            this.osramused.AutoSize = true;
            this.osramused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.osramused.ForeColor = System.Drawing.Color.White;
            this.osramused.Location = new System.Drawing.Point(98, 118);
            this.osramused.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.osramused.Name = "osramused";
            this.osramused.Size = new System.Drawing.Size(58, 15);
            this.osramused.TabIndex = 25;
            this.osramused.Text = "osramused";
            this.osramused.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // osramsize
            // 
            this.osramsize.AccessibleName = "osramsize";
            this.osramsize.AutoSize = true;
            this.osramsize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.osramsize.ForeColor = System.Drawing.Color.White;
            this.osramsize.Location = new System.Drawing.Point(6, 118);
            this.osramsize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.osramsize.Name = "osramsize";
            this.osramsize.Size = new System.Drawing.Size(54, 15);
            this.osramsize.TabIndex = 24;
            this.osramsize.Text = "osramsize";
            this.osramsize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // osramfreeprct
            // 
            this.osramfreeprct.AccessibleName = "oframfreeprct";
            this.osramfreeprct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.osramfreeprct.ForeColor = System.Drawing.Color.White;
            this.osramfreeprct.Location = new System.Drawing.Point(181, 118);
            this.osramfreeprct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.osramfreeprct.Name = "osramfreeprct";
            this.osramfreeprct.Size = new System.Drawing.Size(39, 15);
            this.osramfreeprct.TabIndex = 23;
            this.osramfreeprct.Text = "osramfreeprct";
            this.osramfreeprct.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpu1pb
            // 
            this.gpu1pb.AccessibleName = "gpu1pb";
            this.gpu1pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpu1pb.Location = new System.Drawing.Point(181, 96);
            this.gpu1pb.Name = "gpu1pb";
            this.gpu1pb.Size = new System.Drawing.Size(40, 9);
            this.gpu1pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.gpu1pb.TabIndex = 18;
            // 
            // gpucorefreq
            // 
            this.gpucorefreq.AccessibleName = "gpucorefreq";
            this.gpucorefreq.AutoSize = true;
            this.gpucorefreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.gpucorefreq.ForeColor = System.Drawing.Color.White;
            this.gpucorefreq.Location = new System.Drawing.Point(64, 93);
            this.gpucorefreq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpucorefreq.Name = "gpucorefreq";
            this.gpucorefreq.Size = new System.Drawing.Size(63, 15);
            this.gpucorefreq.TabIndex = 17;
            this.gpucorefreq.Text = "gpucorefreq";
            this.gpucorefreq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpucoreload
            // 
            this.gpucoreload.AccessibleName = "gpucoreload";
            this.gpucoreload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.gpucoreload.ForeColor = System.Drawing.Color.White;
            this.gpucoreload.Location = new System.Drawing.Point(135, 93);
            this.gpucoreload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpucoreload.Name = "gpucoreload";
            this.gpucoreload.Size = new System.Drawing.Size(45, 15);
            this.gpucoreload.TabIndex = 15;
            this.gpucoreload.Text = "gpucoreload";
            this.gpucoreload.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpucoretemp
            // 
            this.gpucoretemp.AccessibleName = "gpucoretemp";
            this.gpucoretemp.AutoSize = true;
            this.gpucoretemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.gpucoretemp.ForeColor = System.Drawing.Color.White;
            this.gpucoretemp.Location = new System.Drawing.Point(6, 93);
            this.gpucoretemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpucoretemp.Name = "gpucoretemp";
            this.gpucoretemp.Size = new System.Drawing.Size(68, 15);
            this.gpucoretemp.TabIndex = 14;
            this.gpucoretemp.Text = "gpucoretemp";
            // 
            // cpu4pb
            // 
            this.cpu4pb.AccessibleName = "cpu4pb";
            this.cpu4pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu4pb.Location = new System.Drawing.Point(180, 72);
            this.cpu4pb.Name = "cpu4pb";
            this.cpu4pb.Size = new System.Drawing.Size(40, 9);
            this.cpu4pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpu4pb.TabIndex = 12;
            // 
            // cpu3pb
            // 
            this.cpu3pb.AccessibleName = "cpu3pb";
            this.cpu3pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu3pb.Location = new System.Drawing.Point(180, 57);
            this.cpu3pb.Name = "cpu3pb";
            this.cpu3pb.Size = new System.Drawing.Size(40, 9);
            this.cpu3pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpu3pb.TabIndex = 11;
            // 
            // cpu2pb
            // 
            this.cpu2pb.AccessibleName = "cpu2pb";
            this.cpu2pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu2pb.Location = new System.Drawing.Point(180, 43);
            this.cpu2pb.Name = "cpu2pb";
            this.cpu2pb.Size = new System.Drawing.Size(40, 9);
            this.cpu2pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpu2pb.TabIndex = 10;
            // 
            // cpu1pb
            // 
            this.cpu1pb.AccessibleName = "cpu1pb";
            this.cpu1pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu1pb.Location = new System.Drawing.Point(180, 29);
            this.cpu1pb.Name = "cpu1pb";
            this.cpu1pb.Size = new System.Drawing.Size(40, 9);
            this.cpu1pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpu1pb.TabIndex = 9;
            // 
            // cputotalpb
            // 
            this.cputotalpb.AccessibleName = "cputotalpb";
            this.cputotalpb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cputotalpb.Location = new System.Drawing.Point(180, 14);
            this.cputotalpb.Name = "cputotalpb";
            this.cputotalpb.Size = new System.Drawing.Size(40, 9);
            this.cputotalpb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cputotalpb.TabIndex = 8;
            // 
            // cpucorefreq
            // 
            this.cpucorefreq.AccessibleName = "cpucorefreq";
            this.cpucorefreq.AutoSize = true;
            this.cpucorefreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cpucorefreq.ForeColor = System.Drawing.Color.White;
            this.cpucorefreq.Location = new System.Drawing.Point(90, 25);
            this.cpucorefreq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpucorefreq.Name = "cpucorefreq";
            this.cpucorefreq.Size = new System.Drawing.Size(62, 15);
            this.cpucorefreq.TabIndex = 6;
            this.cpucorefreq.Text = "cpucorefreq";
            this.cpucorefreq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cputotalload
            // 
            this.cputotalload.AccessibleName = "cputotalload";
            this.cputotalload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cputotalload.ForeColor = System.Drawing.Color.White;
            this.cputotalload.Location = new System.Drawing.Point(133, 10);
            this.cputotalload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cputotalload.Name = "cputotalload";
            this.cputotalload.Size = new System.Drawing.Size(45, 15);
            this.cputotalload.TabIndex = 5;
            this.cputotalload.Text = "cputotalload";
            this.cputotalload.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cputotalname
            // 
            this.cputotalname.AccessibleName = "cputotalname";
            this.cputotalname.AutoSize = true;
            this.cputotalname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cputotalname.ForeColor = System.Drawing.Color.White;
            this.cputotalname.Location = new System.Drawing.Point(6, 10);
            this.cputotalname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cputotalname.Name = "cputotalname";
            this.cputotalname.Size = new System.Drawing.Size(69, 15);
            this.cputotalname.TabIndex = 3;
            this.cputotalname.Text = "cputotalname";
            // 
            // cputotaltemp
            // 
            this.cputotaltemp.AccessibleName = "cputotaltemp";
            this.cputotaltemp.AutoSize = true;
            this.cputotaltemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cputotaltemp.ForeColor = System.Drawing.Color.White;
            this.cputotaltemp.Location = new System.Drawing.Point(75, 10);
            this.cputotaltemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cputotaltemp.Name = "cputotaltemp";
            this.cputotaltemp.Size = new System.Drawing.Size(67, 15);
            this.cputotaltemp.TabIndex = 4;
            this.cputotaltemp.Text = "cputotaltemp";
            // 
            // cpucoreload
            // 
            this.cpucoreload.AccessibleName = "cpucoreload";
            this.cpucoreload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cpucoreload.ForeColor = System.Drawing.Color.White;
            this.cpucoreload.Location = new System.Drawing.Point(134, 25);
            this.cpucoreload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpucoreload.Name = "cpucoreload";
            this.cpucoreload.Size = new System.Drawing.Size(45, 15);
            this.cpucoreload.TabIndex = 2;
            this.cpucoreload.Text = "cpucoreload";
            this.cpucoreload.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 9;
            this.lineShape5.X2 = 219;
            this.lineShape5.Y1 = 137;
            this.lineShape5.Y2 = 137;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 9;
            this.lineShape2.X2 = 219;
            this.lineShape2.Y1 = 113;
            this.lineShape2.Y2 = 113;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 9;
            this.lineShape1.X2 = 219;
            this.lineShape1.Y1 = 89;
            this.lineShape1.Y2 = 89;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(236, 400);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Controls.Add(this.shapeContainer6);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 40);
            this.panel3.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonAbout);
            this.splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonMin);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLongForm);
            this.splitContainer1.Panel2.Controls.Add(this.buttonMove);
            this.splitContainer1.Panel2.Controls.Add(this.buttonClose);
            this.splitContainer1.Panel2.Controls.Add(this.shapeContainer2);
            this.splitContainer1.Panel2MinSize = 10;
            this.splitContainer1.Size = new System.Drawing.Size(213, 18);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 9;
            // 
            // buttonAbout
            // 
            this.buttonAbout.AccessibleDescription = "buttonAbout";
            this.buttonAbout.AccessibleName = "buttonAbout";
            this.buttonAbout.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.SysIcon;
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAbout.Location = new System.Drawing.Point(2, 0);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(18, 18);
            this.buttonAbout.TabIndex = 8;
            this.toolTipButton.SetToolTip(this.buttonAbout, "System Monitor Application\r\nby Mark Becker\r\n© June 2012");
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.AccessibleDescription = "buttonMin";
            this.buttonMin.AccessibleName = "buttonMin";
            this.buttonMin.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.minButtonOff;
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMin.Location = new System.Drawing.Point(137, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(18, 18);
            this.buttonMin.TabIndex = 9;
            this.toolTipButton.SetToolTip(this.buttonMin, "Move App");
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonLongForm
            // 
            this.buttonLongForm.AccessibleDescription = "buttonLongForm";
            this.buttonLongForm.AccessibleName = "buttonLongForm";
            this.buttonLongForm.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.formLongButtonOff;
            this.buttonLongForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLongForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLongForm.Location = new System.Drawing.Point(117, 0);
            this.buttonLongForm.Name = "buttonLongForm";
            this.buttonLongForm.Size = new System.Drawing.Size(18, 18);
            this.buttonLongForm.TabIndex = 7;
            this.toolTipButton.SetToolTip(this.buttonLongForm, "View Long Form");
            this.buttonLongForm.UseVisualStyleBackColor = true;
            this.buttonLongForm.Click += new System.EventHandler(this.buttonLongForm_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.AccessibleDescription = "buttonMove";
            this.buttonMove.AccessibleName = "buttonMove";
            this.buttonMove.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.moveButtonOff;
            this.buttonMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMove.Location = new System.Drawing.Point(97, 0);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(18, 18);
            this.buttonMove.TabIndex = 6;
            this.toolTipButton.SetToolTip(this.buttonMove, "Move App");
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleDescription = "Close";
            this.buttonClose.AccessibleName = "buttonClose";
            this.buttonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClose.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.closeButtonOff;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(157, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(18, 18);
            this.buttonClose.TabIndex = 5;
            this.toolTipButton.SetToolTip(this.buttonClose, "Close App");
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.areaMove});
            this.shapeContainer2.Size = new System.Drawing.Size(178, 18);
            this.shapeContainer2.TabIndex = 8;
            this.shapeContainer2.TabStop = false;
            // 
            // areaMove
            // 
            this.areaMove.AccessibleName = "areaMove";
            this.areaMove.BorderColor = System.Drawing.Color.Transparent;
            this.areaMove.Location = new System.Drawing.Point(0, 0);
            this.areaMove.Name = "areaMove";
            this.areaMove.Size = new System.Drawing.Size(98, 18);
            this.areaMove.Click += new System.EventHandler(this.areaMove_Click);
            // 
            // shapeContainer6
            // 
            this.shapeContainer6.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer6.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer6.Name = "shapeContainer6";
            this.shapeContainer6.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape5});
            this.shapeContainer6.Size = new System.Drawing.Size(230, 40);
            this.shapeContainer6.TabIndex = 0;
            this.shapeContainer6.TabStop = false;
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.rectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape5.BorderColor = System.Drawing.Color.White;
            this.rectangleShape5.BorderWidth = 2;
            this.rectangleShape5.CornerRadius = 10;
            this.rectangleShape5.Location = new System.Drawing.Point(1, 3);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(227, 33);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.systemip);
            this.panel2.Controls.Add(this.systemdate);
            this.panel2.Controls.Add(this.systemname);
            this.panel2.Controls.Add(this.systemtime);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Location = new System.Drawing.Point(3, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 121);
            this.panel2.TabIndex = 12;
            // 
            // systemip
            // 
            this.systemip.AccessibleName = "systemip";
            this.systemip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.systemip.ForeColor = System.Drawing.Color.White;
            this.systemip.Location = new System.Drawing.Point(99, 73);
            this.systemip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systemip.Name = "systemip";
            this.systemip.Size = new System.Drawing.Size(120, 15);
            this.systemip.TabIndex = 7;
            this.systemip.Text = "systemip";
            this.systemip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // systemdate
            // 
            this.systemdate.AccessibleName = "systemdate";
            this.systemdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.systemdate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemdate.ForeColor = System.Drawing.Color.White;
            this.systemdate.Location = new System.Drawing.Point(19, 9);
            this.systemdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systemdate.Name = "systemdate";
            this.systemdate.Size = new System.Drawing.Size(200, 19);
            this.systemdate.TabIndex = 6;
            this.systemdate.Text = "systemdate";
            this.systemdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // systemname
            // 
            this.systemname.AccessibleName = "systemname";
            this.systemname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.systemname.ForeColor = System.Drawing.Color.White;
            this.systemname.Location = new System.Drawing.Point(99, 56);
            this.systemname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systemname.Name = "systemname";
            this.systemname.Size = new System.Drawing.Size(120, 15);
            this.systemname.TabIndex = 4;
            this.systemname.Text = "systemname";
            this.systemname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // systemtime
            // 
            this.systemtime.AccessibleName = "systemtime";
            this.systemtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.systemtime.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemtime.ForeColor = System.Drawing.Color.White;
            this.systemtime.Location = new System.Drawing.Point(89, 30);
            this.systemtime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systemtime.Name = "systemtime";
            this.systemtime.Size = new System.Drawing.Size(130, 19);
            this.systemtime.TabIndex = 5;
            this.systemtime.Text = "systemtime";
            this.systemtime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineSecHand,
            this.lineHourHand,
            this.lineMinHand,
            this.ovalShape1,
            this.rectangleShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(230, 121);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineSecHand
            // 
            this.lineSecHand.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineSecHand.Name = "lineSecHand";
            this.lineSecHand.X1 = 46;
            this.lineSecHand.X2 = 46;
            this.lineSecHand.Y1 = 68;
            this.lineSecHand.Y2 = 100;
            // 
            // lineHourHand
            // 
            this.lineHourHand.BorderColor = System.Drawing.Color.AliceBlue;
            this.lineHourHand.BorderWidth = 3;
            this.lineHourHand.Name = "lineHourHand";
            this.lineHourHand.X1 = 46;
            this.lineHourHand.X2 = 69;
            this.lineHourHand.Y1 = 68;
            this.lineHourHand.Y2 = 68;
            // 
            // lineMinHand
            // 
            this.lineMinHand.BorderColor = System.Drawing.Color.AliceBlue;
            this.lineMinHand.BorderWidth = 3;
            this.lineMinHand.Name = "lineMinHand";
            this.lineMinHand.X1 = 46;
            this.lineMinHand.X2 = 46;
            this.lineMinHand.Y1 = 68;
            this.lineMinHand.Y2 = 40;
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.Transparent;
            this.ovalShape1.BackgroundImage = global::WMI_Monitor_Csharp.Properties.Resources.clockFace;
            this.ovalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.BorderColor = System.Drawing.Color.Transparent;
            this.ovalShape1.Location = new System.Drawing.Point(9, 31);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(76, 76);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.rectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape4.BorderColor = System.Drawing.Color.White;
            this.rectangleShape4.BorderWidth = 2;
            this.rectangleShape4.CornerRadius = 10;
            this.rectangleShape4.Location = new System.Drawing.Point(1, 2);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(227, 115);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.cpucorefreq);
            this.panel1.Controls.Add(this.osramused);
            this.panel1.Controls.Add(this.cpucoretemp);
            this.panel1.Controls.Add(this.osramsize);
            this.panel1.Controls.Add(this.cpucorename);
            this.panel1.Controls.Add(this.osramfreeprct);
            this.panel1.Controls.Add(this.cpucoreload);
            this.panel1.Controls.Add(this.gpu1pb);
            this.panel1.Controls.Add(this.cputotaltemp);
            this.panel1.Controls.Add(this.gpucorefreq);
            this.panel1.Controls.Add(this.cputotalname);
            this.panel1.Controls.Add(this.gpucoreload);
            this.panel1.Controls.Add(this.cputotalload);
            this.panel1.Controls.Add(this.gpucoretemp);
            this.panel1.Controls.Add(this.cputotalpb);
            this.panel1.Controls.Add(this.cpu4pb);
            this.panel1.Controls.Add(this.cpu1pb);
            this.panel1.Controls.Add(this.cpu3pb);
            this.panel1.Controls.Add(this.cpu2pb);
            this.panel1.Controls.Add(this.shapeContainer3);
            this.panel1.Location = new System.Drawing.Point(3, 176);
            this.panel1.MinimumSize = new System.Drawing.Size(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 221);
            this.panel1.TabIndex = 12;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape2,
            this.lineShape1,
            this.rectangleShape3});
            this.shapeContainer3.Size = new System.Drawing.Size(230, 221);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.BorderColor = System.Drawing.Color.White;
            this.rectangleShape3.BorderWidth = 2;
            this.rectangleShape3.CornerRadius = 10;
            this.rectangleShape3.Location = new System.Drawing.Point(1, 2);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(227, 221);
            // 
            // timerFast
            // 
            this.timerFast.Enabled = true;
            this.timerFast.Interval = 1000;
            this.timerFast.Tick += new System.EventHandler(this.timerFast_Tick);
            // 
            // timerSlow
            // 
            this.timerSlow.Enabled = true;
            this.timerSlow.Interval = 10000;
            this.timerSlow.Tick += new System.EventHandler(this.timerSlow_Tick);
            // 
            // FormShort
            // 
            this.AccessibleName = "FormShort";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(248, 435);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1080, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormShort";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "System Info Short";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpucorename;
        private System.Windows.Forms.Label cpucoretemp;
        private System.Windows.Forms.Label cpucoreload;
        private System.Windows.Forms.Label cputotalload;
        private System.Windows.Forms.Label cputotalname;
        private System.Windows.Forms.Label cputotaltemp;
        private System.Windows.Forms.Label cpucorefreq;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timerFast;
        private System.Windows.Forms.ProgressBar cputotalpb;
        private System.Windows.Forms.ProgressBar cpu1pb;
        private System.Windows.Forms.ProgressBar cpu4pb;
        private System.Windows.Forms.ProgressBar cpu3pb;
        private System.Windows.Forms.ProgressBar cpu2pb;
        private System.Windows.Forms.Timer timerSlow;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonMove;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Label systemip;
        private System.Windows.Forms.Label systemdate;
        private System.Windows.Forms.Label systemtime;
        private System.Windows.Forms.Label systemname;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineSecHand;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineHourHand;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineMinHand;
        private System.Windows.Forms.ProgressBar gpu1pb;
        private System.Windows.Forms.Label gpucorefreq;
        private System.Windows.Forms.Label gpucoreload;
        private System.Windows.Forms.Label gpucoretemp;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label osramused;
        private System.Windows.Forms.Label osramsize;
        private System.Windows.Forms.Label osramfreeprct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonLongForm;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape areaMove;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private System.Windows.Forms.Button buttonMin;

    }
}

