namespace Airport_guidance
{
    partial class NoDest
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
            this.nodestination = new System.Windows.Forms.Label();
            this.nodestokay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nodestination
            // 
            this.nodestination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nodestination.AutoSize = true;
            this.nodestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodestination.Location = new System.Drawing.Point(153, 115);
            this.nodestination.Name = "nodestination";
            this.nodestination.Size = new System.Drawing.Size(514, 25);
            this.nodestination.TabIndex = 0;
            this.nodestination.Text = "Please select at least one destination to find a route.";
            // 
            // nodestokay
            // 
            this.nodestokay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nodestokay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodestokay.Location = new System.Drawing.Point(263, 173);
            this.nodestokay.Name = "nodestokay";
            this.nodestokay.Size = new System.Drawing.Size(268, 81);
            this.nodestokay.TabIndex = 1;
            this.nodestokay.Text = "OK";
            this.nodestokay.UseVisualStyleBackColor = true;
            this.nodestokay.Click += new System.EventHandler(this.nodestokay_Click);
            // 
            // NoDest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nodestokay);
            this.Controls.Add(this.nodestination);
            this.Name = "NoDest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NoDest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nodestination;
        private System.Windows.Forms.Button nodestokay;
    }
}