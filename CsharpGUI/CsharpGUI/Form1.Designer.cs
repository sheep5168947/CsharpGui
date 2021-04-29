
namespace CsharpGUI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button4 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(275, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Controller";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(266, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "角度";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(266, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "時間(分鐘)";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(417, 109);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 25);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(417, 174);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 25);
			this.textBox2.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(270, 249);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "確認";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button2.Location = new System.Drawing.Point(417, 249);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 32);
			this.button2.TabIndex = 8;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(16, 392);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(191, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Arduino連線狀態：";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(16, 428);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(118, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "PortName：";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button3.Location = new System.Drawing.Point(15, 461);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(121, 32);
			this.button3.TabIndex = 10;
			this.button3.Text = "連線";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button4.Location = new System.Drawing.Point(152, 461);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(121, 32);
			this.button4.TabIndex = 13;
			this.button4.Text = "關閉連線";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(152, 425);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 23);
			this.comboBox1.TabIndex = 14;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 508);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

