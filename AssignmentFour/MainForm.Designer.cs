namespace AssignmentFour
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
            this.components = new System.ComponentModel.Container();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpToDo = new System.Windows.Forms.GroupBox();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDescripition = new System.Windows.Forms.Label();
            this.lblPriotyri = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.MenuMain.SuspendLayout();
            this.grpToDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.helpToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(820, 24);
            this.MenuMain.TabIndex = 0;
            this.MenuMain.Text = "menuStrip1";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openDatafileToolStripMenuItem,
            this.saveDatafileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(37, 20);
            this.menuFileOpen.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newToolStripMenuItem.Text = "New ";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openDatafileToolStripMenuItem
            // 
            this.openDatafileToolStripMenuItem.Name = "openDatafileToolStripMenuItem";
            this.openDatafileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openDatafileToolStripMenuItem.Text = "Open datafile";
            this.openDatafileToolStripMenuItem.Click += new System.EventHandler(this.openDatafileToolStripMenuItem_Click);
            // 
            // saveDatafileToolStripMenuItem
            // 
            this.saveDatafileToolStripMenuItem.Name = "saveDatafileToolStripMenuItem";
            this.saveDatafileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveDatafileToolStripMenuItem.Text = "Save datafile";
            this.saveDatafileToolStripMenuItem.Click += new System.EventHandler(this.saveDatafileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // ToolTip1
            // 
            this.ToolTip1.Name = "contextMenuStrip1";
            this.ToolTip1.Size = new System.Drawing.Size(61, 4);
            this.toolTip2.SetToolTip(this.ToolTip1, "Click to open calander for date,write time here");
            this.ToolTip1.Opening += new System.ComponentModel.CancelEventHandler(this.ToolTip1_Opening);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
           // this.dateTimePicker1.Enter += new System.EventHandler(this.dateTimePicker1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date and Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To do";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(72, 61);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(487, 20);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(40, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(220, 102);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(162, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(429, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpToDo
            // 
            this.grpToDo.Controls.Add(this.lstTasks);
            this.grpToDo.Controls.Add(this.lblDate);
            this.grpToDo.Controls.Add(this.lblDescripition);
            this.grpToDo.Controls.Add(this.lblPriotyri);
            this.grpToDo.Controls.Add(this.label4);
            this.grpToDo.Location = new System.Drawing.Point(0, 131);
            this.grpToDo.Name = "grpToDo";
            this.grpToDo.Size = new System.Drawing.Size(643, 249);
            this.grpToDo.TabIndex = 9;
            this.grpToDo.TabStop = false;
            this.grpToDo.Text = "To Do";
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(15, 43);
            this.lstTasks.MultiColumn = true;
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(571, 199);
            this.lstTasks.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblDescripition
            // 
            this.lblDescripition.AutoSize = true;
            this.lblDescripition.Location = new System.Drawing.Point(343, 27);
            this.lblDescripition.Name = "lblDescripition";
            this.lblDescripition.Size = new System.Drawing.Size(60, 13);
            this.lblDescripition.TabIndex = 3;
            this.lblDescripition.Tag = "n";
            this.lblDescripition.Text = "Description";
            // 
            // lblPriotyri
            // 
            this.lblPriotyri.AutoSize = true;
            this.lblPriotyri.Location = new System.Drawing.Point(253, 27);
            this.lblPriotyri.Name = "lblPriotyri";
            this.lblPriotyri.Size = new System.Drawing.Size(36, 13);
            this.lblPriotyri.TabIndex = 2;
            this.lblPriotyri.Text = "Priorty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hour";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(479, 391);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 13);
            this.lblClock.TabIndex = 4;
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(529, 24);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbPriority.TabIndex = 10;
            this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Priority";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.grpToDo);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MenuMain);
            this.MainMenuStrip = this.MenuMain;
            this.Name = "MainForm";
            this.Text = "To Do Reminder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.grpToDo.ResumeLayout(false);
            this.grpToDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ToolTip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpToDo;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDescripition;
        private System.Windows.Forms.Label lblPriotyri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

