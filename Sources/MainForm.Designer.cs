namespace AggloCluster
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPreprocess = new System.Windows.Forms.TabPage();
            this.chkBlackPoints = new System.Windows.Forms.CheckBox();
            this.txtMarkerSize = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDefaultScale = new System.Windows.Forms.Button();
            this.txtYMax = new System.Windows.Forms.TextBox();
            this.txtYMin = new System.Windows.Forms.TextBox();
            this.btnRescale = new System.Windows.Forms.Button();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.txtXMin = new System.Windows.Forms.TextBox();
            this.chkEnableGrid = new System.Windows.Forms.CheckBox();
            this.btnGenerateDistanceMatrixFile = new System.Windows.Forms.Button();
            this.chkMinMaxNormalization = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboAttribute2 = new System.Windows.Forms.ComboBox();
            this.cboAttribute1 = new System.Windows.Forms.ComboBox();
            this.chkNormalize = new System.Windows.Forms.CheckBox();
            this.lblNumberOfPatterns = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.tabCluster = new System.Windows.Forms.TabPage();
            this.btnShowDendrogram = new System.Windows.Forms.Button();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFinishTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClusters = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnExecuteClustering = new System.Windows.Forms.Button();
            this.cboStrategy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabClusterValidity = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartKMeans = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfKMeansClusters = new System.Windows.Forms.TextBox();
            this.btnKMeansClustering = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.lblExternalIndexValue = new System.Windows.Forms.Label();
            this.rbRandIndex = new System.Windows.Forms.RadioButton();
            this.rbJaccardIndex = new System.Windows.Forms.RadioButton();
            this.btnValidateClassGroup = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtValidationResults = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.rbDunnIndex = new System.Windows.Forms.RadioButton();
            this.rbDaviesBouldin = new System.Windows.Forms.RadioButton();
            this.lblIndexValue = new System.Windows.Forms.Label();
            this.btnValidateClustering = new System.Windows.Forms.Button();
            this.rbAgnes = new System.Windows.Forms.RadioButton();
            this.rbKMeans = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartAgnes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStartAgnes = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAgnesNumberOfGroups = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboAgnesStrategy = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPreprocess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabCluster.SuspendLayout();
            this.tabClusterValidity.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKMeans)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAgnes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPreprocess);
            this.tabControl1.Controls.Add(this.tabCluster);
            this.tabControl1.Controls.Add(this.tabClusterValidity);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 550);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPreprocess
            // 
            this.tabPreprocess.BackColor = System.Drawing.Color.LightGray;
            this.tabPreprocess.Controls.Add(this.chkBlackPoints);
            this.tabPreprocess.Controls.Add(this.txtMarkerSize);
            this.tabPreprocess.Controls.Add(this.label16);
            this.tabPreprocess.Controls.Add(this.btnDefaultScale);
            this.tabPreprocess.Controls.Add(this.txtYMax);
            this.tabPreprocess.Controls.Add(this.txtYMin);
            this.tabPreprocess.Controls.Add(this.btnRescale);
            this.tabPreprocess.Controls.Add(this.txtXMax);
            this.tabPreprocess.Controls.Add(this.txtXMin);
            this.tabPreprocess.Controls.Add(this.chkEnableGrid);
            this.tabPreprocess.Controls.Add(this.btnGenerateDistanceMatrixFile);
            this.tabPreprocess.Controls.Add(this.chkMinMaxNormalization);
            this.tabPreprocess.Controls.Add(this.label12);
            this.tabPreprocess.Controls.Add(this.label11);
            this.tabPreprocess.Controls.Add(this.cboAttribute2);
            this.tabPreprocess.Controls.Add(this.cboAttribute1);
            this.tabPreprocess.Controls.Add(this.chkNormalize);
            this.tabPreprocess.Controls.Add(this.lblNumberOfPatterns);
            this.tabPreprocess.Controls.Add(this.label5);
            this.tabPreprocess.Controls.Add(this.chart1);
            this.tabPreprocess.Controls.Add(this.dataGridView);
            this.tabPreprocess.Controls.Add(this.label1);
            this.tabPreprocess.Controls.Add(this.btnOpenFile);
            this.tabPreprocess.Controls.Add(this.txtFilePath);
            this.tabPreprocess.Location = new System.Drawing.Point(4, 22);
            this.tabPreprocess.Name = "tabPreprocess";
            this.tabPreprocess.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreprocess.Size = new System.Drawing.Size(914, 524);
            this.tabPreprocess.TabIndex = 0;
            this.tabPreprocess.Text = "Preprocess";
            // 
            // chkBlackPoints
            // 
            this.chkBlackPoints.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkBlackPoints.AutoSize = true;
            this.chkBlackPoints.Location = new System.Drawing.Point(820, 203);
            this.chkBlackPoints.Name = "chkBlackPoints";
            this.chkBlackPoints.Size = new System.Drawing.Size(85, 17);
            this.chkBlackPoints.TabIndex = 23;
            this.chkBlackPoints.Text = "Black Points";
            this.chkBlackPoints.UseVisualStyleBackColor = true;
            // 
            // txtMarkerSize
            // 
            this.txtMarkerSize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMarkerSize.Location = new System.Drawing.Point(711, 479);
            this.txtMarkerSize.Name = "txtMarkerSize";
            this.txtMarkerSize.Size = new System.Drawing.Size(38, 20);
            this.txtMarkerSize.TabIndex = 22;
            this.txtMarkerSize.TextChanged += new System.EventHandler(this.txtMarkerSize_TextChanged);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(641, 482);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Marker size:";
            // 
            // btnDefaultScale
            // 
            this.btnDefaultScale.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDefaultScale.Location = new System.Drawing.Point(830, 106);
            this.btnDefaultScale.Name = "btnDefaultScale";
            this.btnDefaultScale.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultScale.TabIndex = 20;
            this.btnDefaultScale.Text = "Default";
            this.btnDefaultScale.UseVisualStyleBackColor = true;
            this.btnDefaultScale.Click += new System.EventHandler(this.btnDefaultScale_Click);
            // 
            // txtYMax
            // 
            this.txtYMax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtYMax.Location = new System.Drawing.Point(867, 50);
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.Size = new System.Drawing.Size(31, 20);
            this.txtYMax.TabIndex = 19;
            // 
            // txtYMin
            // 
            this.txtYMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtYMin.Location = new System.Drawing.Point(830, 50);
            this.txtYMin.Name = "txtYMin";
            this.txtYMin.Size = new System.Drawing.Size(31, 20);
            this.txtYMin.TabIndex = 18;
            // 
            // btnRescale
            // 
            this.btnRescale.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRescale.Location = new System.Drawing.Point(830, 76);
            this.btnRescale.Name = "btnRescale";
            this.btnRescale.Size = new System.Drawing.Size(75, 23);
            this.btnRescale.TabIndex = 17;
            this.btnRescale.Text = "Rescale";
            this.btnRescale.UseVisualStyleBackColor = true;
            this.btnRescale.Click += new System.EventHandler(this.btnRescale_Click);
            // 
            // txtXMax
            // 
            this.txtXMax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtXMax.Location = new System.Drawing.Point(867, 25);
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.Size = new System.Drawing.Size(31, 20);
            this.txtXMax.TabIndex = 16;
            // 
            // txtXMin
            // 
            this.txtXMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtXMin.Location = new System.Drawing.Point(830, 25);
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.Size = new System.Drawing.Size(31, 20);
            this.txtXMin.TabIndex = 15;
            // 
            // chkEnableGrid
            // 
            this.chkEnableGrid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkEnableGrid.AutoSize = true;
            this.chkEnableGrid.Location = new System.Drawing.Point(819, 176);
            this.chkEnableGrid.Name = "chkEnableGrid";
            this.chkEnableGrid.Size = new System.Drawing.Size(79, 17);
            this.chkEnableGrid.TabIndex = 14;
            this.chkEnableGrid.Text = "Enable grid";
            this.chkEnableGrid.UseVisualStyleBackColor = true;
            this.chkEnableGrid.CheckedChanged += new System.EventHandler(this.chkEnableGrid_CheckedChanged);
            // 
            // btnGenerateDistanceMatrixFile
            // 
            this.btnGenerateDistanceMatrixFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerateDistanceMatrixFile.Location = new System.Drawing.Point(412, 477);
            this.btnGenerateDistanceMatrixFile.Name = "btnGenerateDistanceMatrixFile";
            this.btnGenerateDistanceMatrixFile.Size = new System.Drawing.Size(207, 23);
            this.btnGenerateDistanceMatrixFile.TabIndex = 13;
            this.btnGenerateDistanceMatrixFile.Text = "Generate Distance Matrix CSV File";
            this.btnGenerateDistanceMatrixFile.UseVisualStyleBackColor = true;
            this.btnGenerateDistanceMatrixFile.Click += new System.EventHandler(this.btnGenerateDistanceMatrixFile_Click);
            // 
            // chkMinMaxNormalization
            // 
            this.chkMinMaxNormalization.AutoSize = true;
            this.chkMinMaxNormalization.Location = new System.Drawing.Point(183, 477);
            this.chkMinMaxNormalization.Name = "chkMinMaxNormalization";
            this.chkMinMaxNormalization.Size = new System.Drawing.Size(128, 17);
            this.chkMinMaxNormalization.TabIndex = 12;
            this.chkMinMaxNormalization.Text = "min-max normalization";
            this.chkMinMaxNormalization.UseVisualStyleBackColor = true;
            this.chkMinMaxNormalization.CheckedChanged += new System.EventHandler(this.chkMinMaxNormalization_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(661, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Column Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Column X";
            // 
            // cboAttribute2
            // 
            this.cboAttribute2.FormattingEnabled = true;
            this.cboAttribute2.Location = new System.Drawing.Point(664, 29);
            this.cboAttribute2.Name = "cboAttribute2";
            this.cboAttribute2.Size = new System.Drawing.Size(76, 21);
            this.cboAttribute2.TabIndex = 9;
            this.cboAttribute2.SelectionChangeCommitted += new System.EventHandler(this.cboAttribute2_SelectionChangeCommitted);
            // 
            // cboAttribute1
            // 
            this.cboAttribute1.FormattingEnabled = true;
            this.cboAttribute1.Location = new System.Drawing.Point(570, 29);
            this.cboAttribute1.Name = "cboAttribute1";
            this.cboAttribute1.Size = new System.Drawing.Size(76, 21);
            this.cboAttribute1.TabIndex = 8;
            this.cboAttribute1.SelectionChangeCommitted += new System.EventHandler(this.cboAttribute1_SelectionChangeCommitted);
            // 
            // chkNormalize
            // 
            this.chkNormalize.AutoSize = true;
            this.chkNormalize.Location = new System.Drawing.Point(27, 477);
            this.chkNormalize.Name = "chkNormalize";
            this.chkNormalize.Size = new System.Drawing.Size(134, 17);
            this.chkNormalize.TabIndex = 7;
            this.chkNormalize.Text = "z-score standardization";
            this.chkNormalize.UseVisualStyleBackColor = true;
            this.chkNormalize.CheckedChanged += new System.EventHandler(this.chkNormalize_CheckedChanged);
            // 
            // lblNumberOfPatterns
            // 
            this.lblNumberOfPatterns.AutoSize = true;
            this.lblNumberOfPatterns.Location = new System.Drawing.Point(519, 31);
            this.lblNumberOfPatterns.Name = "lblNumberOfPatterns";
            this.lblNumberOfPatterns.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOfPatterns.TabIndex = 6;
            this.lblNumberOfPatterns.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of patterns:";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea19.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea19);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend19.Name = "Legend1";
            this.chart1.Legends.Add(legend19);
            this.chart1.Location = new System.Drawing.Point(412, 58);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "test1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(394, 402);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(27, 59);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(349, 402);
            this.dataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data set file path";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(301, 26);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open file...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(27, 29);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(268, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // tabCluster
            // 
            this.tabCluster.BackColor = System.Drawing.Color.LightGray;
            this.tabCluster.Controls.Add(this.btnShowDendrogram);
            this.tabCluster.Controls.Add(this.lblTimeElapsed);
            this.tabCluster.Controls.Add(this.label8);
            this.tabCluster.Controls.Add(this.lblFinishTime);
            this.tabCluster.Controls.Add(this.label7);
            this.tabCluster.Controls.Add(this.lblStartTime);
            this.tabCluster.Controls.Add(this.label6);
            this.tabCluster.Controls.Add(this.label3);
            this.tabCluster.Controls.Add(this.txtClusters);
            this.tabCluster.Controls.Add(this.treeView1);
            this.tabCluster.Controls.Add(this.btnExecuteClustering);
            this.tabCluster.Controls.Add(this.cboStrategy);
            this.tabCluster.Controls.Add(this.label2);
            this.tabCluster.Location = new System.Drawing.Point(4, 22);
            this.tabCluster.Name = "tabCluster";
            this.tabCluster.Padding = new System.Windows.Forms.Padding(3);
            this.tabCluster.Size = new System.Drawing.Size(914, 524);
            this.tabCluster.TabIndex = 1;
            this.tabCluster.Text = "Clustering";
            this.tabCluster.Click += new System.EventHandler(this.tabCluster_Click);
            // 
            // btnShowDendrogram
            // 
            this.btnShowDendrogram.Location = new System.Drawing.Point(358, 27);
            this.btnShowDendrogram.Name = "btnShowDendrogram";
            this.btnShowDendrogram.Size = new System.Drawing.Size(135, 23);
            this.btnShowDendrogram.TabIndex = 12;
            this.btnShowDendrogram.Text = "Show Dendrogram";
            this.btnShowDendrogram.UseVisualStyleBackColor = true;
            this.btnShowDendrogram.Click += new System.EventHandler(this.btnShowDendrogram_Click);
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Location = new System.Drawing.Point(509, 500);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(49, 13);
            this.lblTimeElapsed.TabIndex = 11;
            this.lblTimeElapsed.Text = "00:00:00";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Time elapsed: ";
            // 
            // lblFinishTime
            // 
            this.lblFinishTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinishTime.AutoSize = true;
            this.lblFinishTime.Location = new System.Drawing.Point(303, 500);
            this.lblFinishTime.Name = "lblFinishTime";
            this.lblFinishTime.Size = new System.Drawing.Size(49, 13);
            this.lblFinishTime.TabIndex = 9;
            this.lblFinishTime.Text = "00:00:00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Finish time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(101, 500);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(49, 13);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Start time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Singleton Clusters";
            // 
            // txtClusters
            // 
            this.txtClusters.Location = new System.Drawing.Point(638, 60);
            this.txtClusters.Multiline = true;
            this.txtClusters.Name = "txtClusters";
            this.txtClusters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClusters.Size = new System.Drawing.Size(232, 426);
            this.txtClusters.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(46, 60);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(557, 426);
            this.treeView1.TabIndex = 3;
            // 
            // btnExecuteClustering
            // 
            this.btnExecuteClustering.Location = new System.Drawing.Point(245, 27);
            this.btnExecuteClustering.Name = "btnExecuteClustering";
            this.btnExecuteClustering.Size = new System.Drawing.Size(107, 23);
            this.btnExecuteClustering.TabIndex = 2;
            this.btnExecuteClustering.Text = "Start Clustering";
            this.btnExecuteClustering.UseVisualStyleBackColor = true;
            this.btnExecuteClustering.Click += new System.EventHandler(this.btnExecuteClustering_Click);
            // 
            // cboStrategy
            // 
            this.cboStrategy.FormattingEnabled = true;
            this.cboStrategy.Location = new System.Drawing.Point(46, 29);
            this.cboStrategy.Name = "cboStrategy";
            this.cboStrategy.Size = new System.Drawing.Size(193, 21);
            this.cboStrategy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a cluster strategy";
            // 
            // tabClusterValidity
            // 
            this.tabClusterValidity.BackColor = System.Drawing.Color.LightGray;
            this.tabClusterValidity.Controls.Add(this.tabControl2);
            this.tabClusterValidity.Location = new System.Drawing.Point(4, 22);
            this.tabClusterValidity.Name = "tabClusterValidity";
            this.tabClusterValidity.Size = new System.Drawing.Size(914, 524);
            this.tabClusterValidity.TabIndex = 2;
            this.tabClusterValidity.Text = "Validation";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(908, 518);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.chartKMeans);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNumberOfKMeansClusters);
            this.tabPage1.Controls.Add(this.btnKMeansClustering);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "K-Means";
            // 
            // chartKMeans
            // 
            this.chartKMeans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea20.Name = "ChartArea1";
            this.chartKMeans.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chartKMeans.Legends.Add(legend20);
            this.chartKMeans.Location = new System.Drawing.Point(338, 30);
            this.chartKMeans.Name = "chartKMeans";
            this.chartKMeans.Size = new System.Drawing.Size(519, 391);
            this.chartKMeans.TabIndex = 3;
            this.chartKMeans.Text = "chart2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of clusters";
            // 
            // txtNumberOfKMeansClusters
            // 
            this.txtNumberOfKMeansClusters.Location = new System.Drawing.Point(38, 32);
            this.txtNumberOfKMeansClusters.Name = "txtNumberOfKMeansClusters";
            this.txtNumberOfKMeansClusters.Size = new System.Drawing.Size(46, 20);
            this.txtNumberOfKMeansClusters.TabIndex = 1;
            // 
            // btnKMeansClustering
            // 
            this.btnKMeansClustering.Location = new System.Drawing.Point(90, 29);
            this.btnKMeansClustering.Name = "btnKMeansClustering";
            this.btnKMeansClustering.Size = new System.Drawing.Size(108, 23);
            this.btnKMeansClustering.TabIndex = 0;
            this.btnKMeansClustering.Text = "Start Clustering";
            this.btnKMeansClustering.UseVisualStyleBackColor = true;
            this.btnKMeansClustering.Click += new System.EventHandler(this.btnKMeansClustering_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtValidationResults);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.rbAgnes);
            this.tabPage2.Controls.Add(this.rbKMeans);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Validation Indexes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(604, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Clustering Result";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.lblExternalIndexValue);
            this.panel2.Controls.Add(this.rbRandIndex);
            this.panel2.Controls.Add(this.rbJaccardIndex);
            this.panel2.Controls.Add(this.btnValidateClassGroup);
            this.panel2.Location = new System.Drawing.Point(340, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 123);
            this.panel2.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Index value:";
            // 
            // lblExternalIndexValue
            // 
            this.lblExternalIndexValue.Location = new System.Drawing.Point(73, 84);
            this.lblExternalIndexValue.Name = "lblExternalIndexValue";
            this.lblExternalIndexValue.Size = new System.Drawing.Size(54, 13);
            this.lblExternalIndexValue.TabIndex = 8;
            this.lblExternalIndexValue.Text = "0.00";
            // 
            // rbRandIndex
            // 
            this.rbRandIndex.AutoSize = true;
            this.rbRandIndex.Location = new System.Drawing.Point(9, 15);
            this.rbRandIndex.Name = "rbRandIndex";
            this.rbRandIndex.Size = new System.Drawing.Size(96, 17);
            this.rbRandIndex.TabIndex = 8;
            this.rbRandIndex.TabStop = true;
            this.rbRandIndex.Text = "Rand Statistics";
            this.rbRandIndex.UseVisualStyleBackColor = true;
            // 
            // rbJaccardIndex
            // 
            this.rbJaccardIndex.AutoSize = true;
            this.rbJaccardIndex.Location = new System.Drawing.Point(9, 47);
            this.rbJaccardIndex.Name = "rbJaccardIndex";
            this.rbJaccardIndex.Size = new System.Drawing.Size(92, 17);
            this.rbJaccardIndex.TabIndex = 9;
            this.rbJaccardIndex.TabStop = true;
            this.rbJaccardIndex.Text = "Jaccard Index";
            this.rbJaccardIndex.UseVisualStyleBackColor = true;
            // 
            // btnValidateClassGroup
            // 
            this.btnValidateClassGroup.Location = new System.Drawing.Point(139, 77);
            this.btnValidateClassGroup.Name = "btnValidateClassGroup";
            this.btnValidateClassGroup.Size = new System.Drawing.Size(75, 23);
            this.btnValidateClassGroup.TabIndex = 10;
            this.btnValidateClassGroup.Text = "Validate";
            this.btnValidateClassGroup.UseVisualStyleBackColor = true;
            this.btnValidateClassGroup.Click += new System.EventHandler(this.btnValidateClassGroup_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(337, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "External Validation";
            // 
            // txtValidationResults
            // 
            this.txtValidationResults.Location = new System.Drawing.Point(607, 77);
            this.txtValidationResults.Multiline = true;
            this.txtValidationResults.Name = "txtValidationResults";
            this.txtValidationResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValidationResults.Size = new System.Drawing.Size(251, 357);
            this.txtValidationResults.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Internal Validation";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.rbDunnIndex);
            this.panel1.Controls.Add(this.rbDaviesBouldin);
            this.panel1.Controls.Add(this.lblIndexValue);
            this.panel1.Controls.Add(this.btnValidateClustering);
            this.panel1.Location = new System.Drawing.Point(42, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 121);
            this.panel1.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Index value:";
            // 
            // rbDunnIndex
            // 
            this.rbDunnIndex.AutoSize = true;
            this.rbDunnIndex.Location = new System.Drawing.Point(3, 13);
            this.rbDunnIndex.Name = "rbDunnIndex";
            this.rbDunnIndex.Size = new System.Drawing.Size(80, 17);
            this.rbDunnIndex.TabIndex = 0;
            this.rbDunnIndex.TabStop = true;
            this.rbDunnIndex.Text = "Dunn Index";
            this.rbDunnIndex.UseVisualStyleBackColor = true;
            // 
            // rbDaviesBouldin
            // 
            this.rbDaviesBouldin.AutoSize = true;
            this.rbDaviesBouldin.Location = new System.Drawing.Point(3, 45);
            this.rbDaviesBouldin.Name = "rbDaviesBouldin";
            this.rbDaviesBouldin.Size = new System.Drawing.Size(125, 17);
            this.rbDaviesBouldin.TabIndex = 1;
            this.rbDaviesBouldin.TabStop = true;
            this.rbDaviesBouldin.Text = "Davies-Bouldin Index";
            this.rbDaviesBouldin.UseVisualStyleBackColor = true;
            // 
            // lblIndexValue
            // 
            this.lblIndexValue.Location = new System.Drawing.Point(91, 80);
            this.lblIndexValue.Name = "lblIndexValue";
            this.lblIndexValue.Size = new System.Drawing.Size(54, 13);
            this.lblIndexValue.TabIndex = 2;
            this.lblIndexValue.Text = "0.00";
            // 
            // btnValidateClustering
            // 
            this.btnValidateClustering.Location = new System.Drawing.Point(166, 72);
            this.btnValidateClustering.Name = "btnValidateClustering";
            this.btnValidateClustering.Size = new System.Drawing.Size(75, 23);
            this.btnValidateClustering.TabIndex = 3;
            this.btnValidateClustering.Text = "Validate";
            this.btnValidateClustering.UseVisualStyleBackColor = true;
            this.btnValidateClustering.Click += new System.EventHandler(this.btnValidateClustering_Click);
            // 
            // rbAgnes
            // 
            this.rbAgnes.AutoSize = true;
            this.rbAgnes.Location = new System.Drawing.Point(127, 17);
            this.rbAgnes.Name = "rbAgnes";
            this.rbAgnes.Size = new System.Drawing.Size(62, 17);
            this.rbAgnes.TabIndex = 5;
            this.rbAgnes.Text = "AGNES";
            this.rbAgnes.UseVisualStyleBackColor = true;
            // 
            // rbKMeans
            // 
            this.rbKMeans.AutoSize = true;
            this.rbKMeans.Checked = true;
            this.rbKMeans.Location = new System.Drawing.Point(42, 17);
            this.rbKMeans.Name = "rbKMeans";
            this.rbKMeans.Size = new System.Drawing.Size(67, 17);
            this.rbKMeans.TabIndex = 4;
            this.rbKMeans.TabStop = true;
            this.rbKMeans.Text = "K-Means";
            this.rbKMeans.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.chartAgnes);
            this.tabPage3.Controls.Add(this.btnStartAgnes);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtAgnesNumberOfGroups);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cboAgnesStrategy);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(900, 492);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AGNES";
            // 
            // chartAgnes
            // 
            this.chartAgnes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea21.Name = "ChartArea1";
            this.chartAgnes.ChartAreas.Add(chartArea21);
            legend21.Name = "Legend1";
            this.chartAgnes.Legends.Add(legend21);
            this.chartAgnes.Location = new System.Drawing.Point(292, 28);
            this.chartAgnes.Name = "chartAgnes";
            this.chartAgnes.Size = new System.Drawing.Size(519, 391);
            this.chartAgnes.TabIndex = 5;
            this.chartAgnes.Text = "chart2";
            // 
            // btnStartAgnes
            // 
            this.btnStartAgnes.Location = new System.Drawing.Point(78, 75);
            this.btnStartAgnes.Name = "btnStartAgnes";
            this.btnStartAgnes.Size = new System.Drawing.Size(94, 23);
            this.btnStartAgnes.TabIndex = 4;
            this.btnStartAgnes.Text = "Start Clustering";
            this.btnStartAgnes.UseVisualStyleBackColor = true;
            this.btnStartAgnes.Click += new System.EventHandler(this.btnStartAgnes_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Number of clusters";
            // 
            // txtAgnesNumberOfGroups
            // 
            this.txtAgnesNumberOfGroups.Location = new System.Drawing.Point(32, 78);
            this.txtAgnesNumberOfGroups.Name = "txtAgnesNumberOfGroups";
            this.txtAgnesNumberOfGroups.Size = new System.Drawing.Size(40, 20);
            this.txtAgnesNumberOfGroups.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Select a cluster strategy";
            // 
            // cboAgnesStrategy
            // 
            this.cboAgnesStrategy.FormattingEnabled = true;
            this.cboAgnesStrategy.Location = new System.Drawing.Point(32, 28);
            this.cboAgnesStrategy.Name = "cboAgnesStrategy";
            this.cboAgnesStrategy.Size = new System.Drawing.Size(170, 21);
            this.cboAgnesStrategy.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(922, 547);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "AggloCluster 4.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPreprocess.ResumeLayout(false);
            this.tabPreprocess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabCluster.ResumeLayout(false);
            this.tabCluster.PerformLayout();
            this.tabClusterValidity.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKMeans)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAgnes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPreprocess;
        private System.Windows.Forms.TabPage tabCluster;
        private System.Windows.Forms.TabPage tabClusterValidity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClusters;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnExecuteClustering;
        private System.Windows.Forms.ComboBox cboStrategy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnKMeansClustering;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberOfKMeansClusters;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKMeans;
        private System.Windows.Forms.Label lblNumberOfPatterns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFinishTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIndexValue;
        private System.Windows.Forms.RadioButton rbDaviesBouldin;
        private System.Windows.Forms.RadioButton rbDunnIndex;
        private System.Windows.Forms.Button btnValidateClustering;
        private System.Windows.Forms.CheckBox chkNormalize;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnStartAgnes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAgnesNumberOfGroups;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboAgnesStrategy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAgnes;
        private System.Windows.Forms.Button btnShowDendrogram;
        private System.Windows.Forms.ComboBox cboAttribute2;
        private System.Windows.Forms.ComboBox cboAttribute1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbAgnes;
        private System.Windows.Forms.RadioButton rbKMeans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkMinMaxNormalization;
        private System.Windows.Forms.Button btnGenerateDistanceMatrixFile;
        private System.Windows.Forms.TextBox txtValidationResults;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnValidateClassGroup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkEnableGrid;
        private System.Windows.Forms.Button btnRescale;
        private System.Windows.Forms.TextBox txtXMax;
        private System.Windows.Forms.TextBox txtXMin;
        private System.Windows.Forms.TextBox txtYMax;
        private System.Windows.Forms.TextBox txtYMin;
        private System.Windows.Forms.Button btnDefaultScale;
        private System.Windows.Forms.TextBox txtMarkerSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkBlackPoints;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbRandIndex;
        private System.Windows.Forms.RadioButton rbJaccardIndex;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblExternalIndexValue;
    }
}

