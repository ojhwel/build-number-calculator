namespace BuildNumberCalculator
{
    partial class BuildNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildNumberForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLabel = new System.Windows.Forms.Label();
            this.buildNumberLabel = new System.Windows.Forms.Label();
            this.yesterdayCheckBox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Q&uit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(144, 25);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "88:88:88";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // buildNumberLabel
            // 
            this.buildNumberLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildNumberLabel.Location = new System.Drawing.Point(12, 34);
            this.buildNumberLabel.Name = "buildNumberLabel";
            this.buildNumberLabel.Size = new System.Drawing.Size(144, 45);
            this.buildNumberLabel.TabIndex = 2;
            this.buildNumberLabel.Text = "88888";
            this.buildNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buildNumberLabel.Click += new System.EventHandler(this.BuildNumberLabel_Click);
            // 
            // yesterdayCheckBox
            // 
            this.yesterdayCheckBox.AutoSize = true;
            this.yesterdayCheckBox.Location = new System.Drawing.Point(37, 87);
            this.yesterdayCheckBox.Name = "yesterdayCheckBox";
            this.yesterdayCheckBox.Size = new System.Drawing.Size(94, 17);
            this.yesterdayCheckBox.TabIndex = 3;
            this.yesterdayCheckBox.Text = "For y&esterday";
            this.yesterdayCheckBox.UseVisualStyleBackColor = true;
            this.yesterdayCheckBox.CheckedChanged += new System.EventHandler(this.YesterdayCheckBox_CheckedChanged);
            // 
            // BuildNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 116);
            this.Controls.Add(this.yesterdayCheckBox);
            this.Controls.Add(this.buildNumberLabel);
            this.Controls.Add(this.timeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuildNumberForm";
            this.Text = "Build Number Calculator";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuildNumberForm_FormClosing);
            this.Load += new System.EventHandler(this.BuildNumberForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label buildNumberLabel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.CheckBox yesterdayCheckBox;
    }
}

