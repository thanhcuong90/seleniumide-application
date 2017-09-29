namespace SeleniumIDEApplication
{
    partial class MainIDE
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Step1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Step2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Testcase 1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("TestSuite 1", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trvTestsuite = new System.Windows.Forms.TreeView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpTestcases = new System.Windows.Forms.TabPage();
            this.lsvTestcases = new System.Windows.Forms.ListView();
            this.tpSteps = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpSourceExport = new System.Windows.Forms.TabPage();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topMain = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTestcaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTestcaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTestcaseAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportTestcaseAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webdriverCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentTestcaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTestcaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testSuiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSuiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTestSuiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.newTestcaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTestcaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpTestcases.SuspendLayout();
            this.tpSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel1.Controls.Add(this.hScrollBar1);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.topMain);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(826, 625);
            this.splitContainer1.SplitterDistance = 474;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trvTestsuite);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 285);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testcase list:";
            // 
            // trvTestsuite
            // 
            this.trvTestsuite.Location = new System.Drawing.Point(6, 19);
            this.trvTestsuite.Name = "trvTestsuite";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Step1";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Step2";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Testcase 1";
            treeNode4.Name = "Node0";
            treeNode4.Text = "TestSuite 1";
            this.trvTestsuite.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.trvTestsuite.Size = new System.Drawing.Size(200, 260);
            this.trvTestsuite.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpTestcases);
            this.tabControl2.Controls.Add(this.tpSteps);
            this.tabControl2.Controls.Add(this.tpSourceExport);
            this.tabControl2.Location = new System.Drawing.Point(230, 134);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(584, 337);
            this.tabControl2.TabIndex = 9;
            // 
            // tpTestcases
            // 
            this.tpTestcases.Controls.Add(this.lsvTestcases);
            this.tpTestcases.Location = new System.Drawing.Point(4, 22);
            this.tpTestcases.Name = "tpTestcases";
            this.tpTestcases.Padding = new System.Windows.Forms.Padding(3);
            this.tpTestcases.Size = new System.Drawing.Size(576, 311);
            this.tpTestcases.TabIndex = 2;
            this.tpTestcases.Text = "Testcases";
            this.tpTestcases.UseVisualStyleBackColor = true;
            // 
            // lsvTestcases
            // 
            this.lsvTestcases.Location = new System.Drawing.Point(4, 6);
            this.lsvTestcases.Name = "lsvTestcases";
            this.lsvTestcases.Size = new System.Drawing.Size(566, 299);
            this.lsvTestcases.TabIndex = 0;
            this.lsvTestcases.UseCompatibleStateImageBehavior = false;
            // 
            // tpSteps
            // 
            this.tpSteps.Controls.Add(this.comboBox2);
            this.tpSteps.Controls.Add(this.comboBox1);
            this.tpSteps.Controls.Add(this.textBox3);
            this.tpSteps.Controls.Add(this.textBox2);
            this.tpSteps.Controls.Add(this.label5);
            this.tpSteps.Controls.Add(this.label4);
            this.tpSteps.Controls.Add(this.label3);
            this.tpSteps.Controls.Add(this.dataGridView1);
            this.tpSteps.Location = new System.Drawing.Point(4, 22);
            this.tpSteps.Name = "tpSteps";
            this.tpSteps.Padding = new System.Windows.Forms.Padding(3);
            this.tpSteps.Size = new System.Drawing.Size(576, 311);
            this.tpSteps.TabIndex = 0;
            this.tpSteps.Text = "Steps";
            this.tpSteps.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(69, 217);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(501, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(390, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(501, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Target:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Command:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Target,
            this.Value});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // Command
            // 
            this.Command.HeaderText = "colComman";
            this.Command.Name = "Command";
            // 
            // Target
            // 
            this.Target.HeaderText = "Target";
            this.Target.Name = "Target";
            // 
            // Value
            // 
            this.Value.HeaderText = "colValue";
            this.Value.Name = "Value";
            // 
            // tpSourceExport
            // 
            this.tpSourceExport.Location = new System.Drawing.Point(4, 22);
            this.tpSourceExport.Name = "tpSourceExport";
            this.tpSourceExport.Padding = new System.Windows.Forms.Padding(3);
            this.tpSourceExport.Size = new System.Drawing.Size(576, 311);
            this.tpSourceExport.TabIndex = 1;
            this.tpSourceExport.Text = "Source Export";
            this.tpSourceExport.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(74, 83);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Next step";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Pause:";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Play current";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Play all";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(740, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base URL";
            // 
            // topMain
            // 
            this.topMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMain.Location = new System.Drawing.Point(0, 24);
            this.topMain.Name = "topMain";
            this.topMain.Size = new System.Drawing.Size(826, 104);
            this.topMain.TabIndex = 0;
            this.topMain.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testSuiteToolStripMenuItem,
            this.newTestcaseToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveTestcaseToolStripMenuItem,
            this.saveTestcaseAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exportTestcaseAsToolStripMenuItem,
            this.recentTestcaseToolStripMenuItem,
            this.addNewTestcaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newTestcaseToolStripMenuItem
            // 
            this.newTestcaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTestcaseToolStripMenuItem1,
            this.addTestcaseToolStripMenuItem});
            this.newTestcaseToolStripMenuItem.Name = "newTestcaseToolStripMenuItem";
            this.newTestcaseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newTestcaseToolStripMenuItem.Text = "Testcase";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveTestcaseToolStripMenuItem
            // 
            this.saveTestcaseToolStripMenuItem.Name = "saveTestcaseToolStripMenuItem";
            this.saveTestcaseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveTestcaseToolStripMenuItem.Text = "&Save Testcase";
            // 
            // saveTestcaseAsToolStripMenuItem
            // 
            this.saveTestcaseAsToolStripMenuItem.Name = "saveTestcaseAsToolStripMenuItem";
            this.saveTestcaseAsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveTestcaseAsToolStripMenuItem.Text = "Save Testcase &As";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
            // 
            // exportTestcaseAsToolStripMenuItem
            // 
            this.exportTestcaseAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webdriverCToolStripMenuItem});
            this.exportTestcaseAsToolStripMenuItem.Name = "exportTestcaseAsToolStripMenuItem";
            this.exportTestcaseAsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exportTestcaseAsToolStripMenuItem.Text = "Export testcase as";
            // 
            // webdriverCToolStripMenuItem
            // 
            this.webdriverCToolStripMenuItem.Name = "webdriverCToolStripMenuItem";
            this.webdriverCToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.webdriverCToolStripMenuItem.Text = "Webdriver C#";
            // 
            // recentTestcaseToolStripMenuItem
            // 
            this.recentTestcaseToolStripMenuItem.Name = "recentTestcaseToolStripMenuItem";
            this.recentTestcaseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.recentTestcaseToolStripMenuItem.Text = "Recent testcase";
            // 
            // addNewTestcaseToolStripMenuItem
            // 
            this.addNewTestcaseToolStripMenuItem.Name = "addNewTestcaseToolStripMenuItem";
            this.addNewTestcaseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNewTestcaseToolStripMenuItem.Text = "Add New Testcase";
            // 
            // testSuiteToolStripMenuItem
            // 
            this.testSuiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSuiteToolStripMenuItem,
            this.addTestSuiteToolStripMenuItem});
            this.testSuiteToolStripMenuItem.Name = "testSuiteToolStripMenuItem";
            this.testSuiteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.testSuiteToolStripMenuItem.Text = "Test Suite";
            // 
            // addNewSuiteToolStripMenuItem
            // 
            this.addNewSuiteToolStripMenuItem.Name = "addNewSuiteToolStripMenuItem";
            this.addNewSuiteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addNewSuiteToolStripMenuItem.Text = "New Suite";
            // 
            // addTestSuiteToolStripMenuItem
            // 
            this.addTestSuiteToolStripMenuItem.Name = "addTestSuiteToolStripMenuItem";
            this.addTestSuiteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTestSuiteToolStripMenuItem.Text = "Add Test Suite";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.documentToolStripMenuItem.Text = "Document";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 147);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reference";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // newTestcaseToolStripMenuItem1
            // 
            this.newTestcaseToolStripMenuItem1.Name = "newTestcaseToolStripMenuItem1";
            this.newTestcaseToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.newTestcaseToolStripMenuItem1.Text = "New Testcase";
            // 
            // addTestcaseToolStripMenuItem
            // 
            this.addTestcaseToolStripMenuItem.Name = "addTestcaseToolStripMenuItem";
            this.addTestcaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTestcaseToolStripMenuItem.Text = "Add Testcase";
            // 
            // MainIDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 625);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainIDE";
            this.Text = "Seleium IDE";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpTestcases.ResumeLayout(false);
            this.tpSteps.ResumeLayout(false);
            this.tpSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter topMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTestcaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTestcaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTestcaseAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpSourceExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tpSteps;
        private System.Windows.Forms.TreeView trvTestsuite;
        private System.Windows.Forms.TabPage tpTestcases;
        private System.Windows.Forms.ListView lsvTestcases;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem exportTestcaseAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webdriverCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentTestcaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTestcaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testSuiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSuiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTestSuiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTestcaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addTestcaseToolStripMenuItem;
    }
}

