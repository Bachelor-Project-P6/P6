namespace Airport_guidance
{
    partial class SetLocationMap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelNode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1833, 594);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelNode
            // 
            this.btnCancelNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnCancelNode.Location = new System.Drawing.Point(564, 785);
            this.btnCancelNode.Name = "btnCancelNode";
            this.btnCancelNode.Size = new System.Drawing.Size(616, 159);
            this.btnCancelNode.TabIndex = 1;
            this.btnCancelNode.Text = "CANCEL";
            this.btnCancelNode.UseVisualStyleBackColor = true;
            this.btnCancelNode.Click += new System.EventHandler(this.btnCancelNode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(415, 685);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(993, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the location for this device on the map.";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SetLocationMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 1013);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelNode);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SetLocationMap";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SetLocationMap_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SetLocationMap_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelNode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer1;
    }
}