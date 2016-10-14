namespace Coding_Trainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ProcessList = new System.Windows.Forms.ListBox();
            this.lb_BlockedProcess = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lbl_credits = new System.Windows.Forms.Label();
            this.btn_ProcessRefresh = new System.Windows.Forms.Button();
            this.btn_ignore = new System.Windows.Forms.Button();
            this.lbl_Active = new System.Windows.Forms.Label();
            this.MenuFileStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileStop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileStart,
            this.MenuFileStop,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.about_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an item to block";
            // 
            // lb_ProcessList
            // 
            this.lb_ProcessList.FormattingEnabled = true;
            this.lb_ProcessList.Location = new System.Drawing.Point(15, 40);
            this.lb_ProcessList.Name = "lb_ProcessList";
            this.lb_ProcessList.Size = new System.Drawing.Size(190, 147);
            this.lb_ProcessList.Sorted = true;
            this.lb_ProcessList.TabIndex = 2;
            // 
            // lb_BlockedProcess
            // 
            this.lb_BlockedProcess.FormattingEnabled = true;
            this.lb_BlockedProcess.Location = new System.Drawing.Point(259, 40);
            this.lb_BlockedProcess.Name = "lb_BlockedProcess";
            this.lb_BlockedProcess.Size = new System.Drawing.Size(190, 147);
            this.lb_BlockedProcess.TabIndex = 2;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(211, 108);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(42, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = ">>";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(211, 137);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(42, 23);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "<<";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blocked List";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(374, 213);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(259, 213);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 4;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lbl_credits
            // 
            this.lbl_credits.AutoSize = true;
            this.lbl_credits.Location = new System.Drawing.Point(12, 190);
            this.lbl_credits.Name = "lbl_credits";
            this.lbl_credits.Size = new System.Drawing.Size(237, 13);
            this.lbl_credits.TabIndex = 5;
            this.lbl_credits.Text = "You currently have {value} Programming credit(s)";
            // 
            // btn_ProcessRefresh
            // 
            this.btn_ProcessRefresh.Location = new System.Drawing.Point(211, 79);
            this.btn_ProcessRefresh.Name = "btn_ProcessRefresh";
            this.btn_ProcessRefresh.Size = new System.Drawing.Size(42, 23);
            this.btn_ProcessRefresh.TabIndex = 3;
            this.btn_ProcessRefresh.Text = "Refr";
            this.btn_ProcessRefresh.UseVisualStyleBackColor = true;
            this.btn_ProcessRefresh.Click += new System.EventHandler(this.btn_ProcessRefresh_Click);
            // 
            // btn_ignore
            // 
            this.btn_ignore.Location = new System.Drawing.Point(211, 50);
            this.btn_ignore.Name = "btn_ignore";
            this.btn_ignore.Size = new System.Drawing.Size(42, 23);
            this.btn_ignore.TabIndex = 3;
            this.btn_ignore.Text = "Ign";
            this.btn_ignore.UseVisualStyleBackColor = true;
            this.btn_ignore.Click += new System.EventHandler(this.btn_ignore_Click);
            // 
            // lbl_Active
            // 
            this.lbl_Active.AutoSize = true;
            this.lbl_Active.Location = new System.Drawing.Point(12, 203);
            this.lbl_Active.Name = "lbl_Active";
            this.lbl_Active.Size = new System.Drawing.Size(35, 13);
            this.lbl_Active.TabIndex = 6;
            this.lbl_Active.Text = "label3";
            // 
            // MenuFileStart
            // 
            this.MenuFileStart.Name = "MenuFileStart";
            this.MenuFileStart.Size = new System.Drawing.Size(152, 22);
            this.MenuFileStart.Text = "Start";
            this.MenuFileStart.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // MenuFileStop
            // 
            this.MenuFileStop.Name = "MenuFileStop";
            this.MenuFileStop.Size = new System.Drawing.Size(152, 22);
            this.MenuFileStop.Text = "Stop";
            this.MenuFileStop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 248);
            this.Controls.Add(this.lbl_Active);
            this.Controls.Add(this.lbl_credits);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_ignore);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_ProcessRefresh);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_BlockedProcess);
            this.Controls.Add(this.lb_ProcessList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Coding Trainer";
            this.Load += new System.EventHandler(this.on_load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_ProcessList;
        private System.Windows.Forms.ListBox lb_BlockedProcess;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label lbl_credits;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_ProcessRefresh;
        private System.Windows.Forms.Button btn_ignore;
        private System.Windows.Forms.Label lbl_Active;
        private System.Windows.Forms.ToolStripMenuItem MenuFileStart;
        private System.Windows.Forms.ToolStripMenuItem MenuFileStop;
    }
}

