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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetLocationMap));
            this.btnCancelNode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.axMap1 = new AxMapWinGIS.AxMap();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelNode
            // 
            this.btnCancelNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnCancelNode.Location = new System.Drawing.Point(423, 638);
            this.btnCancelNode.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelNode.Name = "btnCancelNode";
            this.btnCancelNode.Size = new System.Drawing.Size(462, 129);
            this.btnCancelNode.TabIndex = 1;
            this.btnCancelNode.Text = "CANCEL";
            this.btnCancelNode.UseVisualStyleBackColor = true;
            this.btnCancelNode.Click += new System.EventHandler(this.btnCancelNode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(311, 557);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the location for this device on the map.";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // axMap1
            // 
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(7, 9);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(1385, 548);
            this.axMap1.TabIndex = 3;
            this.axMap1.MouseDownEvent += new AxMapWinGIS._DMapEvents_MouseDownEventHandler(this.axMap1_MouseDownEvent);
            // 
            // SetLocationMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 823);
            this.Controls.Add(this.axMap1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelNode);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SetLocationMap";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SetLocationMap_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SetLocationMap_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelNode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AxMapWinGIS.AxMap axMap1;
    }
}