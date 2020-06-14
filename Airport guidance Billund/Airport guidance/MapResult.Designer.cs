namespace Airport_guidance
{
    partial class MapResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapResult));
            this.btnSelectDest = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.timeest = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axMap1 = new AxMapWinGIS.AxMap();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectDest
            // 
            this.btnSelectDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnSelectDest.Location = new System.Drawing.Point(392, 635);
            this.btnSelectDest.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectDest.Name = "btnSelectDest";
            this.btnSelectDest.Size = new System.Drawing.Size(564, 157);
            this.btnSelectDest.TabIndex = 1;
            this.btnSelectDest.Text = "HOW DO I GET THERE";
            this.btnSelectDest.UseVisualStyleBackColor = true;
            this.btnSelectDest.Click += new System.EventHandler(this.btnSelectDest_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPassword.Location = new System.Drawing.Point(9, 773);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(18, 19);
            this.btnPassword.TabIndex = 2;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // timeest
            // 
            this.timeest.AutoSize = true;
            this.timeest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.timeest.Location = new System.Drawing.Point(168, 575);
            this.timeest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeest.Name = "timeest";
            this.timeest.Size = new System.Drawing.Size(526, 37);
            this.timeest.TabIndex = 3;
            this.timeest.Text = "Estimated time to reach destination:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axMap1
            // 
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(9, 9);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(1423, 566);
            this.axMap1.TabIndex = 4;
            this.axMap1.MouseDownEvent += new AxMapWinGIS._DMapEvents_MouseDownEventHandler(this.axMap1_MouseDownEvent);
            // 
            // MapResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 802);
            this.Controls.Add(this.axMap1);
            this.Controls.Add(this.timeest);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnSelectDest);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MapResult";
            this.Text = "MapResult";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MapResult_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapResult_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectDest;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label timeest;
        private System.Windows.Forms.Timer timer1;
        private AxMapWinGIS.AxMap axMap1;
    }
}