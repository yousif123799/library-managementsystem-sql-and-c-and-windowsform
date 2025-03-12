namespace library_management_system
{
    partial class AppBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoff = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SlidingPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.sliding_panel = new System.Windows.Forms.Panel();
            this.sliding_panel_toggle = new System.Windows.Forms.Button();
            this.BorrowersTabButton = new System.Windows.Forms.Button();
            this.bookstabbutton = new System.Windows.Forms.Button();
            this.TransactionTabButton = new System.Windows.Forms.Button();
            this.AboutTabButton = new System.Windows.Forms.Button();
            this.SettingsTabButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.sliding_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.logoff);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 28);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // logoff
            // 
            this.logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoff.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoff.ForeColor = System.Drawing.Color.DimGray;
            this.logoff.Location = new System.Drawing.Point(707, 3);
            this.logoff.Name = "logoff";
            this.logoff.Size = new System.Drawing.Size(23, 20);
            this.logoff.TabIndex = 2;
            this.logoff.Text = "!";
            this.logoff.UseVisualStyleBackColor = true;
            this.logoff.Click += new System.EventHandler(this.logoff_Click);
            // 
            // minimize
            // 
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.Ivory;
            this.minimize.Location = new System.Drawing.Point(736, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(23, 20);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "-----";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Crimson;
            this.close.Location = new System.Drawing.Point(765, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 20);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // SlidingPanelTimer
            // 
            this.SlidingPanelTimer.Tick += new System.EventHandler(this.SlidingPanelTimer_Tick);
            // 
            // sliding_panel
            // 
            this.sliding_panel.BackColor = System.Drawing.Color.SkyBlue;
            this.sliding_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliding_panel.BackgroundImage")));
            this.sliding_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sliding_panel.Controls.Add(this.TransactionTabButton);
            this.sliding_panel.Controls.Add(this.bookstabbutton);
            this.sliding_panel.Controls.Add(this.SettingsTabButton);
            this.sliding_panel.Controls.Add(this.AboutTabButton);
            this.sliding_panel.Controls.Add(this.BorrowersTabButton);
            this.sliding_panel.Controls.Add(this.sliding_panel_toggle);
            this.sliding_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sliding_panel.Location = new System.Drawing.Point(0, 28);
            this.sliding_panel.Name = "sliding_panel";
            this.sliding_panel.Size = new System.Drawing.Size(300, 475);
            this.sliding_panel.TabIndex = 3;
            // 
            // sliding_panel_toggle
            // 
            this.sliding_panel_toggle.BackColor = System.Drawing.Color.Transparent;
            this.sliding_panel_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sliding_panel_toggle.Location = new System.Drawing.Point(0, 0);
            this.sliding_panel_toggle.Name = "sliding_panel_toggle";
            this.sliding_panel_toggle.Size = new System.Drawing.Size(300, 61);
            this.sliding_panel_toggle.TabIndex = 0;
            this.sliding_panel_toggle.UseVisualStyleBackColor = false;
            this.sliding_panel_toggle.Click += new System.EventHandler(this.sliding_panel_toggle_Click);
            // 
            // BorrowersTabButton
            // 
            this.BorrowersTabButton.BackColor = System.Drawing.Color.Transparent;
            this.BorrowersTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowersTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowersTabButton.Location = new System.Drawing.Point(0, 116);
            this.BorrowersTabButton.Name = "BorrowersTabButton";
            this.BorrowersTabButton.Size = new System.Drawing.Size(300, 61);
            this.BorrowersTabButton.TabIndex = 1;
            this.BorrowersTabButton.Text = "BORROWERS";
            this.BorrowersTabButton.UseVisualStyleBackColor = false;
            this.BorrowersTabButton.Click += new System.EventHandler(this.BorrowersTabButton_Click);
            // 
            // bookstabbutton
            // 
            this.bookstabbutton.BackColor = System.Drawing.Color.Transparent;
            this.bookstabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookstabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookstabbutton.Location = new System.Drawing.Point(0, 58);
            this.bookstabbutton.Name = "bookstabbutton";
            this.bookstabbutton.Size = new System.Drawing.Size(300, 61);
            this.bookstabbutton.TabIndex = 2;
            this.bookstabbutton.Text = "BOOKS";
            this.bookstabbutton.UseVisualStyleBackColor = false;
            this.bookstabbutton.Click += new System.EventHandler(this.bookstabbutton_Click);
            // 
            // TransactionTabButton
            // 
            this.TransactionTabButton.BackColor = System.Drawing.Color.Transparent;
            this.TransactionTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionTabButton.Location = new System.Drawing.Point(0, 172);
            this.TransactionTabButton.Name = "TransactionTabButton";
            this.TransactionTabButton.Size = new System.Drawing.Size(300, 61);
            this.TransactionTabButton.TabIndex = 3;
            this.TransactionTabButton.Text = "TRANSACTION";
            this.TransactionTabButton.UseVisualStyleBackColor = false;
            this.TransactionTabButton.Click += new System.EventHandler(this.TransactionTabButton_Click);
            // 
            // AboutTabButton
            // 
            this.AboutTabButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTabButton.Location = new System.Drawing.Point(0, 286);
            this.AboutTabButton.Name = "AboutTabButton";
            this.AboutTabButton.Size = new System.Drawing.Size(300, 61);
            this.AboutTabButton.TabIndex = 6;
            this.AboutTabButton.Text = "ABOUT";
            this.AboutTabButton.UseVisualStyleBackColor = false;
            // 
            // SettingsTabButton
            // 
            this.SettingsTabButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTabButton.Location = new System.Drawing.Point(0, 228);
            this.SettingsTabButton.Name = "SettingsTabButton";
            this.SettingsTabButton.Size = new System.Drawing.Size(300, 61);
            this.SettingsTabButton.TabIndex = 4;
            this.SettingsTabButton.Text = "SETTINGS";
            this.SettingsTabButton.UseVisualStyleBackColor = false;
            this.SettingsTabButton.Click += new System.EventHandler(this.SettingsTabButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(298, 28);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(502, 475);
            this.ContentPanel.TabIndex = 7;
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.sliding_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.panel1.ResumeLayout(false);
            this.sliding_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button logoff;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Timer SlidingPanelTimer;
        private System.Windows.Forms.Panel sliding_panel;
        private System.Windows.Forms.Button sliding_panel_toggle;
        private System.Windows.Forms.Button TransactionTabButton;
        private System.Windows.Forms.Button bookstabbutton;
        private System.Windows.Forms.Button SettingsTabButton;
        private System.Windows.Forms.Button AboutTabButton;
        private System.Windows.Forms.Button BorrowersTabButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}