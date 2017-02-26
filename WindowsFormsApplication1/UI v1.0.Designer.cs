namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Commodities", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Credit", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node15");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node16");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Emerging Markets", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node17");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node18");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Equities", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node19");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node20");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node21");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Foreign Exchange", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Node22");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node23");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node24");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Futures and Options", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Node25");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Node26");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Node27");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Rates", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 142);
            this.panel3.TabIndex = 1;
            this.panel3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 717);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1108, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "This section is for notifications such as the stock market or HSBC news popups.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.BackColor = System.Drawing.Color.DimGray;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.Transparent;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HotTracking = true;
            this.treeView1.ItemHeight = 80;
            this.treeView1.Location = new System.Drawing.Point(10, 152);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node8";
            treeNode1.Text = "Node8";
            treeNode2.Name = "Node9";
            treeNode2.Text = "Node9";
            treeNode3.Name = "Node10";
            treeNode3.Text = "Node10";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Commodities";
            treeNode5.Name = "Node11";
            treeNode5.Text = "Node11";
            treeNode6.Name = "Node12";
            treeNode6.Text = "Node12";
            treeNode7.Name = "Node13";
            treeNode7.Text = "Node13";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Credit";
            treeNode9.Name = "Node14";
            treeNode9.Text = "Node14";
            treeNode10.Name = "Node15";
            treeNode10.Text = "Node15";
            treeNode11.Name = "Node16";
            treeNode11.Text = "Node16";
            treeNode12.Name = "Node2";
            treeNode12.Text = "Emerging Markets";
            treeNode13.Name = "Node7";
            treeNode13.Text = "Node7";
            treeNode14.Name = "Node17";
            treeNode14.Text = "Node17";
            treeNode15.Name = "Node18";
            treeNode15.Text = "Node18";
            treeNode16.Name = "Node3";
            treeNode16.Text = "Equities";
            treeNode17.Name = "Node19";
            treeNode17.Text = "Node19";
            treeNode18.Name = "Node20";
            treeNode18.Text = "Node20";
            treeNode19.Name = "Node21";
            treeNode19.Text = "Node21";
            treeNode20.Name = "Node4";
            treeNode20.Text = "Foreign Exchange";
            treeNode21.Name = "Node22";
            treeNode21.Text = "Node22";
            treeNode22.Name = "Node23";
            treeNode22.Text = "Node23";
            treeNode23.Name = "Node24";
            treeNode23.Text = "Node24";
            treeNode24.Name = "Node5";
            treeNode24.Text = "Futures and Options";
            treeNode25.Name = "Node25";
            treeNode25.Text = "Node25";
            treeNode26.Name = "Node26";
            treeNode26.Text = "Node26";
            treeNode27.Name = "Node27";
            treeNode27.Text = "Node27";
            treeNode28.Name = "Node6";
            treeNode28.Text = "Rates";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode16,
            treeNode20,
            treeNode24,
            treeNode28});
            this.treeView1.Size = new System.Drawing.Size(239, 565);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // Form1
            // 
            this.AccessibleName = "Home";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1128, 766);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.Panel panel3;
    }
}

