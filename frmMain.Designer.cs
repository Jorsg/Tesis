namespace SOFMTest
{
    partial class frmMain
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbInputParams = new System.Windows.Forms.GroupBox();
            this.lblActivationFunctionType = new System.Windows.Forms.Label();
            this.rbDiscreteFunction = new System.Windows.Forms.RadioButton();
            this.tbEpsilon = new System.Windows.Forms.TextBox();
            this.tbIterationsNumber = new System.Windows.Forms.TextBox();
            this.tbNumberOfCards = new System.Windows.Forms.TextBox();
            this.lblIterationNumberCaption = new System.Windows.Forms.Label();
            this.lblNamberOfCardsCaption = new System.Windows.Forms.Label();
            this.chbNormalize = new System.Windows.Forms.CheckBox();
            this.btnLoadDataAndCreateNetwork = new System.Windows.Forms.Button();
            this.gbPatterns = new System.Windows.Forms.GroupBox();
            this.lbPatterns = new System.Windows.Forms.ListBox();
            this.gbKohonen = new System.Windows.Forms.GroupBox();
            this.panelLegend = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.chbVisualization = new System.Windows.Forms.CheckBox();
            this.outputDataChart = new Steema.TeeChart.TChart();
            this.inputDataChart = new Steema.TeeChart.TChart();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.points2 = new Steema.TeeChart.Styles.Points();
            this.points3 = new Steema.TeeChart.Styles.Points();
            this.points1 = new Steema.TeeChart.Styles.Points();
            this.points4 = new Steema.TeeChart.Styles.Points();
            this.sofmVisualizer = new SOFMTest.SOFMVisualizer();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbInputParams.SuspendLayout();
            this.gbPatterns.SuspendLayout();
            this.gbKohonen.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbInputParams);
            this.splitContainer1.Panel1.Controls.Add(this.gbPatterns);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbKohonen);
            this.splitContainer1.Size = new System.Drawing.Size(1253, 863);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbInputParams
            // 
            this.gbInputParams.Controls.Add(this.lblActivationFunctionType);
            this.gbInputParams.Controls.Add(this.rbDiscreteFunction);
            this.gbInputParams.Controls.Add(this.tbEpsilon);
            this.gbInputParams.Controls.Add(this.tbIterationsNumber);
            this.gbInputParams.Controls.Add(this.tbNumberOfCards);
            this.gbInputParams.Controls.Add(this.lblIterationNumberCaption);
            this.gbInputParams.Controls.Add(this.lblNamberOfCardsCaption);
            this.gbInputParams.Controls.Add(this.chbNormalize);
            this.gbInputParams.Controls.Add(this.btnLoadDataAndCreateNetwork);
            this.gbInputParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInputParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInputParams.Location = new System.Drawing.Point(0, 0);
            this.gbInputParams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInputParams.Name = "gbInputParams";
            this.gbInputParams.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInputParams.Size = new System.Drawing.Size(394, 292);
            this.gbInputParams.TabIndex = 0;
            this.gbInputParams.TabStop = false;
            this.gbInputParams.Text = "Input data";
            // 
            // lblActivationFunctionType
            // 
            this.lblActivationFunctionType.AutoSize = true;
            this.lblActivationFunctionType.Location = new System.Drawing.Point(33, 82);
            this.lblActivationFunctionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivationFunctionType.Name = "lblActivationFunctionType";
            this.lblActivationFunctionType.Size = new System.Drawing.Size(58, 17);
            this.lblActivationFunctionType.TabIndex = 2;
            this.lblActivationFunctionType.Text = "Función";
            // 
            // rbDiscreteFunction
            // 
            this.rbDiscreteFunction.AutoSize = true;
            this.rbDiscreteFunction.Checked = true;
            this.rbDiscreteFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDiscreteFunction.Location = new System.Drawing.Point(37, 106);
            this.rbDiscreteFunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDiscreteFunction.Name = "rbDiscreteFunction";
            this.rbDiscreteFunction.Size = new System.Drawing.Size(134, 21);
            this.rbDiscreteFunction.TabIndex = 3;
            this.rbDiscreteFunction.TabStop = true;
            this.rbDiscreteFunction.Tag = "0";
            this.rbDiscreteFunction.Text = "Discrete function";
            this.rbDiscreteFunction.UseVisualStyleBackColor = true;
            // 
            // tbEpsilon
            // 
            this.tbEpsilon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEpsilon.Location = new System.Drawing.Point(162, 169);
            this.tbEpsilon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEpsilon.Name = "tbEpsilon";
            this.tbEpsilon.Size = new System.Drawing.Size(77, 22);
            this.tbEpsilon.TabIndex = 9;
            this.tbEpsilon.Text = "0.0000001";
            this.tbEpsilon.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // tbIterationsNumber
            // 
            this.tbIterationsNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIterationsNumber.Location = new System.Drawing.Point(38, 169);
            this.tbIterationsNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIterationsNumber.Name = "tbIterationsNumber";
            this.tbIterationsNumber.Size = new System.Drawing.Size(77, 22);
            this.tbIterationsNumber.TabIndex = 8;
            this.tbIterationsNumber.Text = "100";
            this.tbIterationsNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // tbNumberOfCards
            // 
            this.tbNumberOfCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumberOfCards.Location = new System.Drawing.Point(37, 43);
            this.tbNumberOfCards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNumberOfCards.Name = "tbNumberOfCards";
            this.tbNumberOfCards.Size = new System.Drawing.Size(270, 22);
            this.tbNumberOfCards.TabIndex = 1;
            this.tbNumberOfCards.Text = "64";
            this.tbNumberOfCards.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // lblIterationNumberCaption
            // 
            this.lblIterationNumberCaption.AutoSize = true;
            this.lblIterationNumberCaption.Location = new System.Drawing.Point(34, 149);
            this.lblIterationNumberCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIterationNumberCaption.Name = "lblIterationNumberCaption";
            this.lblIterationNumberCaption.Size = new System.Drawing.Size(203, 17);
            this.lblIterationNumberCaption.TabIndex = 7;
            this.lblIterationNumberCaption.Text = "Number of iterations or Epsilon";
            // 
            // lblNamberOfCardsCaption
            // 
            this.lblNamberOfCardsCaption.AutoSize = true;
            this.lblNamberOfCardsCaption.Location = new System.Drawing.Point(33, 23);
            this.lblNamberOfCardsCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamberOfCardsCaption.Name = "lblNamberOfCardsCaption";
            this.lblNamberOfCardsCaption.Size = new System.Drawing.Size(291, 17);
            this.lblNamberOfCardsCaption.TabIndex = 0;
            this.lblNamberOfCardsCaption.Text = "El número de neuronas en la capa de salida.";
            // 
            // chbNormalize
            // 
            this.chbNormalize.AutoSize = true;
            this.chbNormalize.Checked = true;
            this.chbNormalize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNormalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbNormalize.Location = new System.Drawing.Point(36, 213);
            this.chbNormalize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbNormalize.Name = "chbNormalize";
            this.chbNormalize.Size = new System.Drawing.Size(136, 21);
            this.chbNormalize.TabIndex = 10;
            this.chbNormalize.Text = "Datos de entrada";
            this.chbNormalize.UseVisualStyleBackColor = true;
            // 
            // btnLoadDataAndCreateNetwork
            // 
            this.btnLoadDataAndCreateNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDataAndCreateNetwork.Location = new System.Drawing.Point(13, 253);
            this.btnLoadDataAndCreateNetwork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadDataAndCreateNetwork.Name = "btnLoadDataAndCreateNetwork";
            this.btnLoadDataAndCreateNetwork.Size = new System.Drawing.Size(377, 28);
            this.btnLoadDataAndCreateNetwork.TabIndex = 11;
            this.btnLoadDataAndCreateNetwork.Text = "Load data and form the map...";
            this.btnLoadDataAndCreateNetwork.UseVisualStyleBackColor = true;
            this.btnLoadDataAndCreateNetwork.Click += new System.EventHandler(this.btnLoadDataAndCreateNetwork_Click);
            // 
            // gbPatterns
            // 
            this.gbPatterns.Controls.Add(this.lbPatterns);
            this.gbPatterns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbPatterns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPatterns.Location = new System.Drawing.Point(0, 300);
            this.gbPatterns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPatterns.Name = "gbPatterns";
            this.gbPatterns.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPatterns.Size = new System.Drawing.Size(394, 563);
            this.gbPatterns.TabIndex = 1;
            this.gbPatterns.TabStop = false;
            this.gbPatterns.Text = "Vectores de Entrada";
            // 
            // lbPatterns
            // 
            this.lbPatterns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPatterns.FormattingEnabled = true;
            this.lbPatterns.ItemHeight = 16;
            this.lbPatterns.Location = new System.Drawing.Point(4, 19);
            this.lbPatterns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPatterns.Name = "lbPatterns";
            this.lbPatterns.Size = new System.Drawing.Size(386, 540);
            this.lbPatterns.TabIndex = 0;
            this.lbPatterns.SelectedIndexChanged += new System.EventHandler(this.lbPatterns_SelectedIndexChanged);
            this.lbPatterns.Leave += new System.EventHandler(this.lbPatterns_Leave);
            // 
            // gbKohonen
            // 
            this.gbKohonen.AutoSize = true;
            this.gbKohonen.Controls.Add(this.panelLegend);
            this.gbKohonen.Controls.Add(this.statusStrip);
            this.gbKohonen.Controls.Add(this.chbVisualization);
            this.gbKohonen.Controls.Add(this.outputDataChart);
            this.gbKohonen.Controls.Add(this.inputDataChart);
            this.gbKohonen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbKohonen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbKohonen.Location = new System.Drawing.Point(0, 0);
            this.gbKohonen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKohonen.Name = "gbKohonen";
            this.gbKohonen.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKohonen.Size = new System.Drawing.Size(854, 863);
            this.gbKohonen.TabIndex = 0;
            this.gbKohonen.TabStop = false;
            this.gbKohonen.Text = "Kohonen map";
            // 
            // panelLegend
            // 
            this.panelLegend.AutoSize = true;
            this.panelLegend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLegend.Location = new System.Drawing.Point(549, 346);
            this.panelLegend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(2, 2);
            this.panelLegend.TabIndex = 5;
            this.panelLegend.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.pbStatus});
            this.statusStrip.Location = new System.Drawing.Point(4, 837);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(846, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // pbStatus
            // 
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(133, 20);
            this.pbStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbStatus.Visible = false;
            // 
            // chbVisualization
            // 
            this.chbVisualization.AutoSize = true;
            this.chbVisualization.Checked = true;
            this.chbVisualization.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVisualization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbVisualization.Location = new System.Drawing.Point(8, 661);
            this.chbVisualization.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbVisualization.Name = "chbVisualization";
            this.chbVisualization.Size = new System.Drawing.Size(105, 21);
            this.chbVisualization.TabIndex = 2;
            this.chbVisualization.Text = "Visualization";
            this.toolTip.SetToolTip(this.chbVisualization, "Uncheck it to speed up calculations");
            this.chbVisualization.UseVisualStyleBackColor = true;
            this.chbVisualization.CheckedChanged += new System.EventHandler(this.chbVisualization_CheckedChanged);
            // 
            // outputDataChart
            // 
            // 
            // 
            // 
            this.outputDataChart.Aspect.ElevationFloat = 345D;
            this.outputDataChart.Aspect.RotationFloat = 345D;
            this.outputDataChart.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
            this.outputDataChart.Axes.Bottom.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Bottom.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Bottom.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Bottom.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Bottom.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Depth.Automatic = true;
            // 
            // 
            // 
            this.outputDataChart.Axes.Depth.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Depth.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Depth.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Depth.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Depth.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
            this.outputDataChart.Axes.DepthTop.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.DepthTop.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.DepthTop.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.DepthTop.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Left.Automatic = true;
            // 
            // 
            // 
            this.outputDataChart.Axes.Left.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Left.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Left.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Left.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Left.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Right.Automatic = true;
            // 
            // 
            // 
            this.outputDataChart.Axes.Right.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Right.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Right.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Right.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Right.Title.Shadow.Visible = false;
            this.outputDataChart.Axes.Right.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Top.Automatic = true;
            // 
            // 
            // 
            this.outputDataChart.Axes.Top.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Top.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Top.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Axes.Top.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Axes.Top.Title.Shadow.Visible = false;
            this.outputDataChart.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Footer.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Footer.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Header.Font.Shadow.Visible = false;
            this.outputDataChart.Header.Lines = new string[] {
        ""};
            // 
            // 
            // 
            this.outputDataChart.Header.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Legend.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.outputDataChart.Legend.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Legend.Title.Shadow.Visible = false;
            this.outputDataChart.Legend.Visible = false;
            this.outputDataChart.Location = new System.Drawing.Point(8, 346);
            this.outputDataChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputDataChart.Name = "outputDataChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.outputDataChart.Panel.ImageBevel.Width = 1;
            // 
            // 
            // 
            this.outputDataChart.Panel.Pen.Visible = true;
            // 
            // 
            // 
            this.outputDataChart.Panel.Shadow.Visible = false;
            this.outputDataChart.Series.Add(this.points2);
            this.outputDataChart.Series.Add(this.points3);
            this.outputDataChart.Size = new System.Drawing.Size(533, 308);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.SubFooter.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.SubFooter.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.SubHeader.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.SubHeader.Shadow.Visible = false;
            this.outputDataChart.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.outputDataChart.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.outputDataChart.Walls.Back.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.outputDataChart.Walls.Bottom.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.outputDataChart.Walls.Left.Shadow.Visible = false;
            // 
            // 
            // 
            this.outputDataChart.Walls.Right.AutoHide = false;
            // 
            // 
            // 
            this.outputDataChart.Walls.Right.Shadow.Visible = false;
            // 
            // inputDataChart
            // 
            // 
            // 
            // 
            this.inputDataChart.Aspect.ElevationFloat = 345D;
            this.inputDataChart.Aspect.RotationFloat = 345D;
            this.inputDataChart.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
            this.inputDataChart.Axes.Bottom.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Bottom.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Bottom.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Bottom.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Bottom.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Depth.Automatic = true;
            // 
            // 
            // 
            this.inputDataChart.Axes.Depth.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Depth.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Depth.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Depth.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Depth.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
            this.inputDataChart.Axes.DepthTop.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.DepthTop.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.DepthTop.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.DepthTop.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Left.Automatic = true;
            // 
            // 
            // 
            this.inputDataChart.Axes.Left.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Left.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Left.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Left.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Left.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Right.Automatic = true;
            // 
            // 
            // 
            this.inputDataChart.Axes.Right.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Right.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Right.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Right.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Right.Title.Shadow.Visible = false;
            this.inputDataChart.Axes.Right.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Top.Automatic = true;
            // 
            // 
            // 
            this.inputDataChart.Axes.Top.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Top.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Top.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Axes.Top.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Axes.Top.Title.Shadow.Visible = false;
            this.inputDataChart.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Footer.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Footer.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Header.Font.Shadow.Visible = false;
            this.inputDataChart.Header.Lines = new string[] {
        ""};
            // 
            // 
            // 
            this.inputDataChart.Header.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Legend.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.inputDataChart.Legend.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Legend.Title.Shadow.Visible = false;
            this.inputDataChart.Legend.Visible = false;
            this.inputDataChart.Location = new System.Drawing.Point(8, 31);
            this.inputDataChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputDataChart.Name = "inputDataChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.inputDataChart.Panel.ImageBevel.Width = 1;
            // 
            // 
            // 
            this.inputDataChart.Panel.Pen.Visible = true;
            // 
            // 
            // 
            this.inputDataChart.Panel.Shadow.Visible = false;
            this.inputDataChart.Series.Add(this.points1);
            this.inputDataChart.Series.Add(this.points4);
            this.inputDataChart.Size = new System.Drawing.Size(533, 308);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.SubFooter.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.SubFooter.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.SubHeader.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.SubHeader.Shadow.Visible = false;
            this.inputDataChart.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.inputDataChart.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.inputDataChart.Walls.Back.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.inputDataChart.Walls.Bottom.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.inputDataChart.Walls.Left.Shadow.Visible = false;
            // 
            // 
            // 
            this.inputDataChart.Walls.Right.AutoHide = false;
            // 
            // 
            // 
            this.inputDataChart.Walls.Right.Shadow.Visible = false;
            // 
            // points2
            // 
            // 
            // 
            // 
            this.points2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(153)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.points2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.points2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.points2.Marks.Callout.Distance = 0;
            this.points2.Marks.Callout.Draw3D = false;
            this.points2.Marks.Callout.Length = 0;
            this.points2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Marks.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.points2.Pointer.Dark3D = false;
            this.points2.Pointer.Draw3D = false;
            this.points2.Pointer.HorizSize = 2;
            // 
            // 
            // 
            this.points2.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.points2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.points2.Pointer.VertSize = 2;
            this.points2.Pointer.Visible = true;
            this.points2.Title = "point1";
            // 
            // 
            // 
            this.points2.XValues.DataMember = "X";
            this.points2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.points2.YValues.DataMember = "Y";
            // 
            // points3
            // 
            // 
            // 
            // 
            this.points3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.points3.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.points3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.points3.Marks.Callout.Distance = 0;
            this.points3.Marks.Callout.Draw3D = false;
            this.points3.Marks.Callout.Length = 0;
            this.points3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points3.Marks.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.points3.Pointer.Draw3D = false;
            // 
            // 
            // 
            this.points3.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.points3.Pointer.Pen.Transparency = 50;
            this.points3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.points3.Pointer.Visible = true;
            this.points3.Title = "point2";
            // 
            // 
            // 
            this.points3.XValues.DataMember = "X";
            this.points3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.points3.YValues.DataMember = "Y";
            // 
            // points1
            // 
            // 
            // 
            // 
            this.points1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(77)))), ((int)(((byte)(153)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.points1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.points1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.points1.Marks.Callout.Distance = 0;
            this.points1.Marks.Callout.Draw3D = false;
            this.points1.Marks.Callout.Length = 0;
            this.points1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.points1.Pointer.Dark3D = false;
            this.points1.Pointer.Draw3D = false;
            this.points1.Pointer.HorizSize = 2;
            this.points1.Pointer.InflateMargins = false;
            // 
            // 
            // 
            this.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.points1.Pointer.VertSize = 2;
            this.points1.Pointer.Visible = true;
            this.points1.Title = "point1";
            // 
            // 
            // 
            this.points1.XValues.DataMember = "X";
            this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.points1.YValues.DataMember = "Y";
            // 
            // points4
            // 
            // 
            // 
            // 
            this.points4.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.points4.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.points4.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.points4.Marks.Callout.Distance = 0;
            this.points4.Marks.Callout.Draw3D = false;
            this.points4.Marks.Callout.Length = 0;
            this.points4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points4.Marks.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points4.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.points4.Pointer.Draw3D = false;
            // 
            // 
            // 
            this.points4.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.points4.Pointer.Pen.Transparency = 50;
            this.points4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.points4.Pointer.Visible = true;
            this.points4.Title = "point2";
            // 
            // 
            // 
            this.points4.XValues.DataMember = "X";
            this.points4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.points4.YValues.DataMember = "Y";
            // 
            // sofmVisualizer
            // 
            this.sofmVisualizer.Location = new System.Drawing.Point(412, 25);
            this.sofmVisualizer.Matrix = null;
            this.sofmVisualizer.Name = "sofmVisualizer";
            this.sofmVisualizer.Size = new System.Drawing.Size(225, 250);
            this.sofmVisualizer.TabIndex = 4;
            this.sofmVisualizer.ZoomFactor = 25;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 863);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "SOFM Demo Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbInputParams.ResumeLayout(false);
            this.gbInputParams.PerformLayout();
            this.gbPatterns.ResumeLayout(false);
            this.gbKohonen.ResumeLayout(false);
            this.gbKohonen.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbPatterns;
        private System.Windows.Forms.ListBox lbPatterns;
        private System.Windows.Forms.GroupBox gbKohonen;
        private Steema.TeeChart.TChart outputDataChart;
        private Steema.TeeChart.TChart inputDataChart;
        private System.Windows.Forms.GroupBox gbInputParams;
        private System.Windows.Forms.Label lblActivationFunctionType;
        private System.Windows.Forms.RadioButton rbDiscreteFunction;
        private System.Windows.Forms.TextBox tbEpsilon;
        private System.Windows.Forms.TextBox tbIterationsNumber;
        private System.Windows.Forms.TextBox tbNumberOfCards;
        private System.Windows.Forms.Label lblIterationNumberCaption;
        private System.Windows.Forms.Label lblNamberOfCardsCaption;
        private System.Windows.Forms.CheckBox chbNormalize;
        private System.Windows.Forms.Button btnLoadDataAndCreateNetwork;
        private Steema.TeeChart.Styles.Points points2;
        private Steema.TeeChart.Styles.Points points3;
        private Steema.TeeChart.Styles.Points points1;
        private Steema.TeeChart.Styles.Points points4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.CheckBox chbVisualization;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar pbStatus;
        private System.Windows.Forms.ToolTip toolTip;
        private SOFMVisualizer sofmVisualizer;
        private System.Windows.Forms.Panel panelLegend;
    }
}

