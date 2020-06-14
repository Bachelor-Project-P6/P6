namespace Airport_guidance
{
    partial class SelectDest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnGate = new System.Windows.Forms.Button();
            this.btnRestroom = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.btnSelectDest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(504, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnFood.Location = new System.Drawing.Point(205, 645);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(633, 156);
            this.btnFood.TabIndex = 16;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnGate
            // 
            this.btnGate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGate.Location = new System.Drawing.Point(205, 159);
            this.btnGate.Name = "btnGate";
            this.btnGate.Size = new System.Drawing.Size(633, 156);
            this.btnGate.TabIndex = 17;
            this.btnGate.Text = "Gate";
            this.btnGate.UseVisualStyleBackColor = true;
            this.btnGate.Click += new System.EventHandler(this.btnGate_Click);
            // 
            // btnRestroom
            // 
            this.btnRestroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnRestroom.Location = new System.Drawing.Point(205, 321);
            this.btnRestroom.Name = "btnRestroom";
            this.btnRestroom.Size = new System.Drawing.Size(633, 156);
            this.btnRestroom.TabIndex = 18;
            this.btnRestroom.Text = "Restroom";
            this.btnRestroom.UseVisualStyleBackColor = true;
            this.btnRestroom.Click += new System.EventHandler(this.btnRestroom_Click);
            // 
            // btnShop
            // 
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnShop.Location = new System.Drawing.Point(205, 483);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(633, 156);
            this.btnShop.TabIndex = 19;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnInfo.Location = new System.Drawing.Point(205, 807);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(633, 156);
            this.btnInfo.TabIndex = 20;
            this.btnInfo.Text = "Information Desk";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnShowResult
            // 
            this.btnShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnShowResult.Location = new System.Drawing.Point(1076, 267);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(633, 195);
            this.btnShowResult.TabIndex = 21;
            this.btnShowResult.Text = "Show route";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // btnSelectDest
            // 
            this.btnSelectDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnSelectDest.Location = new System.Drawing.Point(1076, 554);
            this.btnSelectDest.Name = "btnSelectDest";
            this.btnSelectDest.Size = new System.Drawing.Size(633, 195);
            this.btnSelectDest.TabIndex = 22;
            this.btnSelectDest.Text = "Cancel selection";
            this.btnSelectDest.UseVisualStyleBackColor = true;
            this.btnSelectDest.Click += new System.EventHandler(this.btnSelectDest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(196, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Please select where you would like to go.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(196, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1569, 46);
            this.label2.TabIndex = 24;
            this.label2.Text = "If more than one destionation is selected, a route will be shown in the order of " +
    "selection.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SelectDest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1055);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectDest);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnRestroom);
            this.Controls.Add(this.btnGate);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SelectDest";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SelectDest_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectDest_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnGate;
        private System.Windows.Forms.Button btnRestroom;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Button btnSelectDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

