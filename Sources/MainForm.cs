using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AggloCluster
{
    public partial class MainForm : Form
    {
        StringBuilder lines = new StringBuilder(); //variavel utilizada para escrever linhas no textbox
        HashSet<double[]> dataSet;

        SharpCluster.Clusters hierarchicalClusters; // resultado da execucao do algoritmo hierarquico GAS/MUAS

        SharpCluster.Cluster[] clustersToValidate;
        SharpCluster.Cluster[] kmeansClusters; // resultado da execucao do algoritmo k-means
        SharpCluster.Cluster[] agnesClusters; // resultado da execucao do algoritmo agnes

        bool hasClass = false;


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            openFileDialog.CheckFileExists = true;
            txtFilePath.Text = openFileDialog.FileName;

            if (txtFilePath.Text.Trim().Length > 0)
            {
                this.ViewFile(txtFilePath.Text);
            }
        }

        private void ViewFile(string fileName)
        {
            hasClass = false;
            chkEnableGrid.Checked = true;

            int attributeCount = 0;

            dataSet = new HashSet<double[]>();
            double[] dataPoint;

            string textLine = string.Empty;
            string[] splitLine;
            string attribute = string.Empty;

            StreamReader streamReader = new StreamReader(fileName);

            this.dataGridView.Rows.Clear();
            this.dataGridView.Columns.Clear();

            while (streamReader.Peek() > -1)
            {
                textLine = streamReader.ReadLine();

                while (textLine.StartsWith("%"))
                {
                    textLine = streamReader.ReadLine();
                }

                if (textLine.ToLower().StartsWith("@attribute"))
                {
                    attribute = textLine.Split(' ')[1];

                    if (attribute.ToLower().Equals("class"))
                    {
                        hasClass = true;
                    }

                     this.dataGridView.Columns.Add(attribute, attribute);
                    
                }

                if (textLine.Trim().Length > 0 && !textLine.StartsWith("@"))
                {
                    splitLine = textLine.Split(',');
                    this.dataGridView.Rows.Add(splitLine);
                    //dataPoint = new double[] { Convert.ToDouble(splitLine[0]), Convert.ToDouble(splitLine[1]) };
                    attributeCount = splitLine.Length;

                    dataPoint = new double[attributeCount];

                    for (int i = 0; i < attributeCount; i++)
                    {
                        dataPoint[i] = Convert.ToDouble(splitLine[i]);
                    }

                    dataSet.Add(dataPoint);


                }

            }

            FillAttributeCombobox(this.dataGridView.Columns);

            this.ShowChart(dataSet);
            EnableClusterTab(true); //habilita a tabCluster

            lblNumberOfPatterns.Text = dataSet.Count.ToString();
        }

        private void FillAttributeCombobox(DataGridViewColumnCollection columnCollection)
        {
            cboAttribute1.Items.Clear();
            cboAttribute2.Items.Clear();

            foreach (DataGridViewColumn column in columnCollection)
            {
                cboAttribute1.Items.Add(column.HeaderText);
                cboAttribute2.Items.Add(column.HeaderText);
            }

            if (cboAttribute1.Items.Count > 0)
            {
                cboAttribute1.SelectedItem = cboAttribute1.Items[0];
            }

            if (cboAttribute2.Items.Count > 1)
            {
                cboAttribute2.SelectedItem = cboAttribute2.Items[1];
            }

        }

        private void ShowZScoreNormalizedData()
        {
            SharpCluster.Preprocess.ZScore zscore = new SharpCluster.Preprocess.ZScore();
            SharpCluster.PatternMatrix pm =  zscore.Transform(dataSet);
            dataSet = null;
            dataSet = new HashSet<double[]>();
            this.dataGridView.Rows.Clear();

            string[] dataRow = new string[pm.GetPattern(0).GetDimension()];

            foreach (SharpCluster.Pattern pattern in pm)
            {
                for(int i=0; i< pattern.GetAttributes().Count(); i++)
                {
                    dataRow[i] = pattern.GetAttribute(i).ToString();
                }

                this.dataGridView.Rows.Add(dataRow);
                dataSet.Add(pattern.GetAttributes());
            }

            this.ShowChart(dataSet);
            lblNumberOfPatterns.Text = dataSet.Count.ToString();

        }

        private void ShowMinMaxNormalizedData()
        {
            SharpCluster.Preprocess.MinMax minmax = new SharpCluster.Preprocess.MinMax();
            SharpCluster.PatternMatrix pm = minmax.Transform(dataSet);
            dataSet = null;
            dataSet = new HashSet<double[]>();
            this.dataGridView.Rows.Clear();

            string[] dataRow = new string[pm.GetPattern(0).GetDimension()];

            foreach (SharpCluster.Pattern pattern in pm)
            {
                for (int i = 0; i < pattern.GetAttributes().Count(); i++)
                {
                    dataRow[i] = pattern.GetAttribute(i).ToString();
                }

                this.dataGridView.Rows.Add(dataRow);
                dataSet.Add(pattern.GetAttributes());
            }

            this.ShowChart(dataSet);
            lblNumberOfPatterns.Text = dataSet.Count.ToString();

        }

        private void chkEnableGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableGrid.Checked)
            {
                if (dataSet != null)
                {

                    chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                    chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

                    chartKMeans.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                    chartKMeans.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

                    chartAgnes.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                    chartAgnes.ChartAreas[0].AxisY.MajorGrid.Enabled = true;


                    chart1.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
                    chart1.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;

                    chartKMeans.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
                    chartKMeans.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;

                    chartAgnes.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
                    chartAgnes.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
                }

            }
            else
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                chartKMeans.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartKMeans.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                chartAgnes.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartAgnes.ChartAreas[0].AxisY.MajorGrid.Enabled = false;


                chart1.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
                chart1.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;

                chartKMeans.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
                chartKMeans.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;

                chartAgnes.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
                chartAgnes.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;

            }

        }


        private void ShowChart(HashSet<double[]> dataSet)
        {

            chart1.Series["test1"].Points.Clear();

            int i = 0;
            foreach (double[] dataPoint in dataSet)
            {
                chart1.Series["test1"].Points.AddXY(dataPoint[cboAttribute1.SelectedIndex], dataPoint[cboAttribute2.SelectedIndex]);
                chart1.Series["test1"].Points[i].ToolTip = "[" + dataPoint[cboAttribute1.SelectedIndex] + "," + dataPoint[cboAttribute2.SelectedIndex] + "]";
                i++;
            }

            if (chkBlackPoints.Checked)
            {
                chart1.Series["test1"].Color = Color.Black;
            }

            chart1.Series["test1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart1.Series["test1"].MarkerSize = 5;
            txtMarkerSize.Text = chart1.Series["test1"].MarkerSize.ToString();

        }

        private void txtMarkerSize_TextChanged(object sender, EventArgs e)
        {
            if (txtMarkerSize.Text.Trim().Length > 0)
            {
                chart1.Series["test1"].MarkerSize = Convert.ToInt32(txtMarkerSize.Text);

                for (int i = 0; i < chartAgnes.Series.Count; i++)
                {
                    chartAgnes.Series[i].MarkerSize = Convert.ToInt32(txtMarkerSize.Text);
                }

                for (int i = 0; i < chartKMeans.Series.Count; i++)
                {
                    chartKMeans.Series[i].MarkerSize = Convert.ToInt32(txtMarkerSize.Text);
                }


            }

        }


        private void btnExecuteClustering_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            btnExecuteClustering.Enabled = false;
            lines.Clear(); // limpa as linhas
            HashSet<double[]> _dataSet;

            if (txtFilePath.Text.Length > 0)
            {
                if (dataSet == null)
                {
                    _dataSet = this.GenerateDataSet(txtFilePath.Text);
                }
                else
                {
                    _dataSet = dataSet;
                }

                DateTime start = DateTime.Now;
                lblStartTime.Text = start.ToString();

                SharpCluster.Agnes agnes = new SharpCluster.Agnes(_dataSet, hasClass);
                SharpCluster.Clusters clusters = agnes.ExecuteClustering((cboStrategy.SelectedItem as ComboboxItem).Value, 1);

                DateTime end = DateTime.Now;
                lblFinishTime.Text = end.ToString();

                TimeSpan span = end - start;
                lblTimeElapsed.Text = span.TotalSeconds.ToString();

                this.BuildTreeView(clusters);
                this.FillTextBox(clusters.GetClusters());

                hierarchicalClusters = clusters;

            }
            else
            {
                MessageBox.Show("Go to Preprocess and select a file!", "Data set file not found");
            }

            btnExecuteClustering.Enabled = true;

        }


        private void FillTextBox(SharpCluster.Cluster[] clusterCollection)
        {
            foreach (SharpCluster.Cluster cluster in clusterCollection)
            {
                if (cluster.QuantityOfSubClusters() == 0)
                {
                    lines.Append("Cluster" + cluster.Id + " = {[" + cluster.GetPattern(0).GetAttributes()[cboAttribute1.SelectedIndex] + ", " + cluster.GetPattern(0).GetAttributes()[cboAttribute2.SelectedIndex] + "]}*");
                }
                else
                {
                    this.FillTextBox(cluster.GetSubClusters());
                }
            }

            txtClusters.Lines = lines.ToString().Split('*').ToArray();

        }

        private void BuildTreeView(SharpCluster.Clusters clusters)
        {
            treeView1.Nodes.Clear();
            TreeNode rootNode = treeView1.Nodes.Add("Cluster" + clusters.GetClusters()[0].Id.ToString());
            this.AddNodes(clusters.GetClusters()[0].GetSubClusters(), rootNode);
            treeView1.ExpandAll();

        }

        private void AddNodes(SharpCluster.Cluster[] clusters, TreeNode node)
        {

            foreach (var cluster in clusters)
            {
                TreeNode childNode = node.Nodes.Add("Cluster" + cluster.Id.ToString());
                if (cluster.QuantityOfSubClusters() > 0)
                {
                    this.AddNodes(cluster.GetSubClusters(), childNode);
                }
            }
        }


        private HashSet<double[]> GenerateDataSet(string fileName)
        {
            HashSet<double[]> dataSet = new HashSet<double[]>();

            string textLine = string.Empty;
            string[] splitLine;
            StreamReader streamReader = new StreamReader(fileName);

            double[] dataPoint;

            while (streamReader.Peek() > -1)
            {
                textLine = streamReader.ReadLine();

                if (textLine.Trim().Length > 0 && !textLine.StartsWith("@"))
                {
                    splitLine = textLine.Split(',');
                    //dataPoint = new double[] { Convert.ToDouble(splitLine[0]), Convert.ToDouble(splitLine[1]) };
                    dataPoint = new double[splitLine.Length];

                    for (int i = 0; i < splitLine.Length; i++)
                    {
                        dataPoint[i] = Convert.ToDouble(splitLine[i]);
                    }

                    dataSet.Add(dataPoint);
                }

            }


            return dataSet;
        }


        private void FillComboBox()
        {
            cboStrategy.Items.Clear();
            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "Single Linkage";
            item1.Value = SharpCluster.ClusterDistance.Strategy.SingleLinkage;
            cboStrategy.Items.Add(item1);

            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Complete Linkage";
            item2.Value = SharpCluster.ClusterDistance.Strategy.CompleteLinkage;
            cboStrategy.Items.Add(item2);

            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Average Linkage WPGMA";
            item3.Value = SharpCluster.ClusterDistance.Strategy.AverageLinkageWPGMA;
            cboStrategy.Items.Add(item3);

            ComboboxItem item4 = new ComboboxItem();
            item4.Text = "Average Linkage UPGMA";
            item4.Value = SharpCluster.ClusterDistance.Strategy.AverageLinkageUPGMA;
            cboStrategy.Items.Add(item4);

            cboStrategy.SelectedItem = item1;
        }

        private void FillAgnesComboBox()
        {
            cboAgnesStrategy.Items.Clear();
            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "Single Linkage";
            item1.Value = SharpCluster.ClusterDistance.Strategy.SingleLinkage;
            cboAgnesStrategy.Items.Add(item1);

            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Complete Linkage";
            item2.Value = SharpCluster.ClusterDistance.Strategy.CompleteLinkage;
            cboAgnesStrategy.Items.Add(item2);

            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Average Linkage WPGMA";
            item3.Value = SharpCluster.ClusterDistance.Strategy.AverageLinkageWPGMA;
            cboAgnesStrategy.Items.Add(item3);

            ComboboxItem item4 = new ComboboxItem();
            item4.Text = "Average Linkage UPGMA";
            item4.Value = SharpCluster.ClusterDistance.Strategy.AverageLinkageUPGMA;
            cboAgnesStrategy.Items.Add(item4);

            cboAgnesStrategy.SelectedItem = item1;
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public SharpCluster.ClusterDistance.Strategy Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void tabCluster_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillComboBox();
            FillAgnesComboBox();

            EnableClusterTab(false);
            
        }

        private void EnableClusterTab(bool enabled)
        {
            (tabControl1.TabPages[1] as Control).Enabled = enabled;
            (tabControl1.TabPages[2] as Control).Enabled = enabled;
        }

        private void btnKMeansClustering_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            btnKMeansClustering.Enabled = false;
            HashSet<double[]> _dataSet;

            if (txtFilePath.Text.Length > 0)
            {
                if (txtNumberOfKMeansClusters.Text.Trim().Length > 0 && Convert.ToInt32(txtNumberOfKMeansClusters.Text) > 0)
                {
                    if (Convert.ToInt32(txtNumberOfKMeansClusters.Text) > 1)
                    {
                        if (dataSet == null)
                        {
                            _dataSet = this.GenerateDataSet(txtFilePath.Text);
                        }
                        else
                        {
                            _dataSet = dataSet;
                        }
                        

                        SharpCluster.Partitional.KMeans kmeans = new SharpCluster.Partitional.KMeans(_dataSet, hasClass);
                        SharpCluster.Cluster[] clusters = kmeans.ExecuteClustering(Convert.ToInt32(txtNumberOfKMeansClusters.Text));

                        ShowKMeansChart(clusters);
                        kmeansClusters = clusters;
                    }
                    else
                    {
                        MessageBox.Show("Number of cluster must be more than 1.");
                    }
 
                }
                else
                {
                    MessageBox.Show("Enter a number o clusters.");
                }
            }
            else
            {
                MessageBox.Show("Go to Preprocess and select a file!", "Data set file not found");
            }

            btnKMeansClustering.Enabled = true;
        }

        private void ShowKMeansChart(SharpCluster.Cluster[] clusters)
        {
            chartKMeans.Series.Clear();
            int i = 0;

            foreach (SharpCluster.Cluster cluster in clusters)
            {
                chartKMeans.Series.Add("Cluster" + cluster.Id);
                chartKMeans.Series["Cluster" + cluster.Id].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                if (chkBlackPoints.Checked)
                {
                    chartKMeans.Series["Cluster" + cluster.Id].Color = Color.Black;
                }
                


                i = 0;
                foreach (SharpCluster.Pattern pattern in cluster.GetPatterns())
                {
                    chartKMeans.Series["Cluster" + cluster.Id].Points.AddXY(pattern.GetAttribute(cboAttribute1.SelectedIndex), pattern.GetAttribute(cboAttribute2.SelectedIndex));
                    chartKMeans.Series["Cluster" + cluster.Id].Points[i].ToolTip = "["+ pattern.GetAttribute(cboAttribute1.SelectedIndex) + "," + pattern.GetAttribute(cboAttribute2.SelectedIndex) + "]";
                    i++;
                }
                
            }

        }

        private void ShowAgnesChart(SharpCluster.Cluster[] clusters)
        {
            chartAgnes.Series.Clear();
            
            int i = 0;

            foreach (SharpCluster.Cluster cluster in clusters)
            {
                chartAgnes.Series.Add("Cluster" + cluster.Id);
                chartAgnes.Series["Cluster" + cluster.Id].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                if (chkBlackPoints.Checked)
                {
                    chartAgnes.Series["Cluster" + cluster.Id].Color = Color.Black;
                }


                i = 0;
                foreach (SharpCluster.Pattern pattern in cluster.GetPatterns())
                {
                    chartAgnes.Series["Cluster" + cluster.Id].Points.AddXY(pattern.GetAttribute(cboAttribute1.SelectedIndex), pattern.GetAttribute(cboAttribute2.SelectedIndex));
                    chartAgnes.Series["Cluster" + cluster.Id].Points[i].ToolTip = "[" + pattern.GetAttribute(cboAttribute1.SelectedIndex) + "," + pattern.GetAttribute(cboAttribute2.SelectedIndex) + "]";
                    i++;
                }

            }

        }


        private void btnValidateClustering_Click(object sender, EventArgs e)
        {
            if (rbKMeans.Checked)
            {
                clustersToValidate = kmeansClusters;
            }

            if (rbAgnes.Checked)
            {
                clustersToValidate = agnesClusters;
            }

            if (rbDunnIndex.Checked)
            {
                ExecuteDunnIndexValidation();
            }
            else
            {
                if (rbDaviesBouldin.Checked)
                {
                    ExecuteDaviesBouldinIndexValidation();
                }

            }
        }

        private void ExecuteDunnIndexValidation()
        {
            if (clustersToValidate == null)
            {
                MessageBox.Show("There is no clustering to validate!");
            }
            else
            {
                lblIndexValue.Text = SharpCluster.ValidationIndex.DunnIndex.Validate(clustersToValidate).ToString();
            }
        }

        private void ExecuteDaviesBouldinIndexValidation()
        {
            if (clustersToValidate == null)
            {
                MessageBox.Show("There is no clustering to validate!");
            }
            else
            {
                lblIndexValue.Text = SharpCluster.ValidationIndex.DaviesBouldinIndex.Validate(clustersToValidate).ToString();
            }
        }

        private void chkNormalize_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNormalize.Checked)
            {
                ShowZScoreNormalizedData();
            }
            else
            {
                this.ViewFile(txtFilePath.Text);
            }
        }

        private void btnStartAgnes_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            HashSet<double[]> _dataSet;

            if (txtFilePath.Text.Length > 0)
            {
                if (txtAgnesNumberOfGroups.Text.Trim().Length > 0 && Convert.ToInt32(txtAgnesNumberOfGroups.Text) > 0)
                {
                    if (Convert.ToInt32(txtAgnesNumberOfGroups.Text) > 1)
                    {
                        if (dataSet == null)
                        {
                            _dataSet = this.GenerateDataSet(txtFilePath.Text);
                        }
                        else
                        {
                            _dataSet = dataSet;
                        }


                        SharpCluster.Agnes agnes = new SharpCluster.Agnes(_dataSet, hasClass);
                        SharpCluster.Clusters clusters = agnes.ExecuteClustering((cboAgnesStrategy.SelectedItem as ComboboxItem).Value, Convert.ToInt32(txtAgnesNumberOfGroups.Text));

                        //Converte clusters (hierarquico) para clusters (particional) como o k-means, para utilizar Dunn e Davies-Bouldin
                        SharpCluster.Cluster[] flatClusters = agnes.BuildFlatClustersFromHierarchicalClustering(clusters, clusters.GetClusters().Count());

                        ShowAgnesChart(flatClusters);
                        agnesClusters = flatClusters;
                    }
                    else
                    {
                        MessageBox.Show("Number of cluster must be more than 1.");
                    }

                }
                else
                {
                    MessageBox.Show("Enter a number o clusters.");
                }
            }
            else
            {
                MessageBox.Show("Go to Preprocess and select a file!", "Data set file not found");
            }


        }

        private void btnShowDendrogram_Click(object sender, EventArgs e)
        {
            Dendrogram.DendrogramFrm dendrogramFrm = new Dendrogram.DendrogramFrm();
            dendrogramFrm.hierarchicalClusters = this.hierarchicalClusters;
            dendrogramFrm.Show();
           
        }

        private void cboAttribute1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowChart(dataSet);
        }

        private void cboAttribute2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowChart(dataSet);
        }

        private void chkMinMaxNormalization_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMinMaxNormalization.Checked)
            {
                ShowMinMaxNormalizedData();
            }
            else
            {
                this.ViewFile(txtFilePath.Text);
            }

        }

        private void btnGenerateDistanceMatrixFile_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            btnGenerateDistanceMatrixFile.Enabled = false;
            HashSet<double[]> _dataSet;

            if (txtFilePath.Text.Length > 0)
            {
                if (dataSet == null)
                {
                    _dataSet = this.GenerateDataSet(txtFilePath.Text);
                }
                else
                {
                    _dataSet = dataSet;
                }

                SharpCluster.Agnes agnes = new SharpCluster.Agnes(_dataSet);
                agnes.CreateCSVMatrixFile(txtFilePath.Text+"Matrix.csv");

            }
            else
            {
                MessageBox.Show("Data set file not found");
            }

            btnGenerateDistanceMatrixFile.Enabled = true;

        }

        private void btnValidateClassGroup_Click(object sender, EventArgs e)
        {
            txtValidationResults.Clear();

            if (rbKMeans.Checked)
            {
                clustersToValidate = kmeansClusters;
            }

            if (rbAgnes.Checked)
            {
                clustersToValidate = agnesClusters;
            }


            ArrayList agrupamento = new ArrayList();
            Dictionary<String, Double[]> grupo;
            string nomePadrao = "p";
 
            int count = 0;
            foreach (SharpCluster.Cluster cluster in clustersToValidate)
            {
                grupo = null;
                grupo = new Dictionary<string, double[]>();


                foreach (SharpCluster.Pattern pattern in cluster.GetPatterns())
                {
                    grupo.Add(nomePadrao + count, new double[] { pattern.GetAttribute(0), pattern.GetAttribute(1), pattern.ClassAttribute } );
                    txtValidationResults.Text += pattern.GetAttribute(0).ToString() + "," + pattern.GetAttribute(1).ToString() + "," + pattern.ClassAttribute + "\r\n";
                    count++;
                }

                agrupamento.Add(grupo);

                txtValidationResults.Text += "Cluster" + cluster.Id + "\r\n";
                count = 0;
            }


            if (rbRandIndex.Checked)
            {
                SharpCluster.ValidationIndex.RandStatistic rand = new SharpCluster.ValidationIndex.RandStatistic(agrupamento);
                lblExternalIndexValue.Text = Math.Round(rand.CalculaRand(), 4).ToString();
            }

            if (rbJaccardIndex.Checked)
            {
                SharpCluster.ValidationIndex.JaccardIndex jaccard = new SharpCluster.ValidationIndex.JaccardIndex(agrupamento);
                lblExternalIndexValue.Text = Math.Round(jaccard.CalculaJaccard(), 4).ToString();
            }



        }

        private void btnRescale_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(txtXMin.Text);
            chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(txtXMax.Text);

            chart1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(txtYMin.Text);
            chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(txtYMax.Text);


            chartKMeans.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(txtXMin.Text);
            chartKMeans.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(txtXMax.Text);

            chartKMeans.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(txtYMin.Text);
            chartKMeans.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(txtYMax.Text);


            chartAgnes.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(txtXMin.Text);
            chartAgnes.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(txtXMax.Text);

            chartAgnes.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(txtYMin.Text);
            chartAgnes.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(txtYMax.Text);






        }

        private void btnDefaultScale_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = Double.NaN;
            chart1.ChartAreas[0].AxisX.Maximum = Double.NaN;

            chart1.ChartAreas[0].AxisY.Minimum = Double.NaN;
            chart1.ChartAreas[0].AxisY.Maximum = Double.NaN;


            chartKMeans.ChartAreas[0].AxisX.Minimum = Double.NaN;
            chartKMeans.ChartAreas[0].AxisX.Maximum = Double.NaN;

            chartKMeans.ChartAreas[0].AxisY.Minimum = Double.NaN;
            chartKMeans.ChartAreas[0].AxisY.Maximum = Double.NaN;

            chartAgnes.ChartAreas[0].AxisX.Minimum = Double.NaN;
            chartAgnes.ChartAreas[0].AxisX.Maximum = Double.NaN;

            chartAgnes.ChartAreas[0].AxisY.Minimum = Double.NaN;
            chartAgnes.ChartAreas[0].AxisY.Maximum = Double.NaN;

        }

    }
}
