namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.MakePDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.X1Tx = new System.Windows.Forms.TextBox();
            this.X2Tx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Y2Tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Y1Tx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start.Location = new System.Drawing.Point(12, 8);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(64, 24);
            this.Start.TabIndex = 0;
            this.Start.Text = "Save";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // MakePDF
            // 
            this.MakePDF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MakePDF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MakePDF.Location = new System.Drawing.Point(89, 8);
            this.MakePDF.Name = "MakePDF";
            this.MakePDF.Size = new System.Drawing.Size(75, 24);
            this.MakePDF.TabIndex = 1;
            this.MakePDF.Text = "PDF作成";
            this.MakePDF.UseVisualStyleBackColor = true;
            this.MakePDF.Click += new System.EventHandler(this.MakePDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "X1";
            // 
            // X1Tx
            // 
            this.X1Tx.Location = new System.Drawing.Point(43, 38);
            this.X1Tx.MaxLength = 4;
            this.X1Tx.Name = "X1Tx";
            this.X1Tx.Size = new System.Drawing.Size(33, 19);
            this.X1Tx.TabIndex = 3;
            this.X1Tx.Text = "0";
            this.X1Tx.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.X1Tx.GotFocus += new System.EventHandler(this.TextBoxChanged);
            // 
            // X2Tx
            // 
            this.X2Tx.Location = new System.Drawing.Point(43, 63);
            this.X2Tx.MaxLength = 4;
            this.X2Tx.Name = "X2Tx";
            this.X2Tx.Size = new System.Drawing.Size(33, 19);
            this.X2Tx.TabIndex = 7;
            this.X2Tx.Text = "100";
            this.X2Tx.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.X2Tx.GotFocus += new System.EventHandler(this.TextBoxChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "W";
            // 
            // Y2Tx
            // 
            this.Y2Tx.Location = new System.Drawing.Point(117, 63);
            this.Y2Tx.MaxLength = 4;
            this.Y2Tx.Name = "Y2Tx";
            this.Y2Tx.Size = new System.Drawing.Size(33, 19);
            this.Y2Tx.TabIndex = 9;
            this.Y2Tx.Text = "100";
            this.Y2Tx.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.Y2Tx.GotFocus += new System.EventHandler(this.TextBoxChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "H";
            // 
            // Y1Tx
            // 
            this.Y1Tx.Location = new System.Drawing.Point(117, 38);
            this.Y1Tx.MaxLength = 4;
            this.Y1Tx.Name = "Y1Tx";
            this.Y1Tx.Size = new System.Drawing.Size(33, 19);
            this.Y1Tx.TabIndex = 5;
            this.Y1Tx.Text = "0";
            this.Y1Tx.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.Y1Tx.GotFocus += new System.EventHandler(this.TextBoxChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y1";
            // 
            // Form1
            // 
            this.AcceptButton = this.Start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(176, 92);
            this.Controls.Add(this.Y2Tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Y1Tx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.X2Tx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X1Tx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MakePDF);
            this.Controls.Add(this.Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(192, 131);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(192, 76);
            this.Name = "Form1";
            this.Text = "RenshaPDF";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button MakePDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox X1Tx;
        private System.Windows.Forms.TextBox X2Tx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Y2Tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Y1Tx;
        private System.Windows.Forms.Label label4;
    }
}

