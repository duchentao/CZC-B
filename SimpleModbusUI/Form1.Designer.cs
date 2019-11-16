namespace SimpleModbusUI
{
	partial class Form1
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnF8 = new System.Windows.Forms.Button();
			this.btnF9 = new System.Windows.Forms.Button();
			this.btnF11 = new System.Windows.Forms.Button();
			this.btnF10 = new System.Windows.Forms.Button();
			this.btnF5 = new System.Windows.Forms.Button();
			this.btnF6 = new System.Windows.Forms.Button();
			this.btnF7 = new System.Windows.Forms.Button();
			this.btnF1 = new System.Windows.Forms.Button();
			this.btnF2 = new System.Windows.Forms.Button();
			this.btnF3 = new System.Windows.Forms.Button();
			this.btnF4 = new System.Windows.Forms.Button();
			this.btnRead = new System.Windows.Forms.Button();
			this.btnF16 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(26, 98);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "启动";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
			this.comboBox1.Location = new System.Drawing.Point(26, 46);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(75, 20);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// btnF8
			// 
			this.btnF8.Location = new System.Drawing.Point(415, 219);
			this.btnF8.Name = "btnF8";
			this.btnF8.Size = new System.Drawing.Size(49, 39);
			this.btnF8.TabIndex = 2;
			this.btnF8.Text = "前进1";
			this.btnF8.UseVisualStyleBackColor = true;
			this.btnF8.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnF9
			// 
			this.btnF9.Location = new System.Drawing.Point(415, 158);
			this.btnF9.Name = "btnF9";
			this.btnF9.Size = new System.Drawing.Size(49, 39);
			this.btnF9.TabIndex = 3;
			this.btnF9.Text = "前进2";
			this.btnF9.UseVisualStyleBackColor = true;
			this.btnF9.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnF11
			// 
			this.btnF11.Location = new System.Drawing.Point(415, 36);
			this.btnF11.Name = "btnF11";
			this.btnF11.Size = new System.Drawing.Size(49, 39);
			this.btnF11.TabIndex = 5;
			this.btnF11.Text = "前进4";
			this.btnF11.UseVisualStyleBackColor = true;
			this.btnF11.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnF10
			// 
			this.btnF10.Location = new System.Drawing.Point(415, 97);
			this.btnF10.Name = "btnF10";
			this.btnF10.Size = new System.Drawing.Size(49, 39);
			this.btnF10.TabIndex = 4;
			this.btnF10.Text = "前进3";
			this.btnF10.UseVisualStyleBackColor = true;
			this.btnF10.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnF5
			// 
			this.btnF5.Location = new System.Drawing.Point(221, 280);
			this.btnF5.Name = "btnF5";
			this.btnF5.Size = new System.Drawing.Size(49, 39);
			this.btnF5.TabIndex = 7;
			this.btnF5.Text = "完车";
			this.btnF5.UseVisualStyleBackColor = true;
			this.btnF5.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnF6
			// 
			this.btnF6.Location = new System.Drawing.Point(318, 280);
			this.btnF6.Name = "btnF6";
			this.btnF6.Size = new System.Drawing.Size(49, 39);
			this.btnF6.TabIndex = 6;
			this.btnF6.Text = "停车";
			this.btnF6.UseVisualStyleBackColor = true;
			this.btnF6.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnF7
			// 
			this.btnF7.Location = new System.Drawing.Point(415, 280);
			this.btnF7.Name = "btnF7";
			this.btnF7.Size = new System.Drawing.Size(49, 39);
			this.btnF7.TabIndex = 12;
			this.btnF7.Text = "备车";
			this.btnF7.UseVisualStyleBackColor = true;
			this.btnF7.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnF1
			// 
			this.btnF1.Location = new System.Drawing.Point(221, 36);
			this.btnF1.Name = "btnF1";
			this.btnF1.Size = new System.Drawing.Size(49, 39);
			this.btnF1.TabIndex = 11;
			this.btnF1.Text = "后退4";
			this.btnF1.UseVisualStyleBackColor = true;
			this.btnF1.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnF2
			// 
			this.btnF2.Location = new System.Drawing.Point(221, 97);
			this.btnF2.Name = "btnF2";
			this.btnF2.Size = new System.Drawing.Size(49, 39);
			this.btnF2.TabIndex = 10;
			this.btnF2.Text = "后退3";
			this.btnF2.UseVisualStyleBackColor = true;
			this.btnF2.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnF3
			// 
			this.btnF3.Location = new System.Drawing.Point(221, 158);
			this.btnF3.Name = "btnF3";
			this.btnF3.Size = new System.Drawing.Size(49, 39);
			this.btnF3.TabIndex = 9;
			this.btnF3.Text = "后退2";
			this.btnF3.UseVisualStyleBackColor = true;
			this.btnF3.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnF4
			// 
			this.btnF4.Location = new System.Drawing.Point(221, 219);
			this.btnF4.Name = "btnF4";
			this.btnF4.Size = new System.Drawing.Size(49, 39);
			this.btnF4.TabIndex = 8;
			this.btnF4.Text = "后退1";
			this.btnF4.UseVisualStyleBackColor = true;
			this.btnF4.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(26, 149);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(75, 23);
			this.btnRead.TabIndex = 13;
			this.btnRead.Text = "读取";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.button8_Click);
			// 
			// btnF16
			// 
			this.btnF16.Location = new System.Drawing.Point(318, 347);
			this.btnF16.Name = "btnF16";
			this.btnF16.Size = new System.Drawing.Size(49, 39);
			this.btnF16.TabIndex = 14;
			this.btnF16.Text = "蜂鸣器";
			this.btnF16.UseVisualStyleBackColor = true;
			this.btnF16.Click += new System.EventHandler(this.btnFx_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 450);
			this.Controls.Add(this.btnF16);
			this.Controls.Add(this.btnRead);
			this.Controls.Add(this.btnF7);
			this.Controls.Add(this.btnF1);
			this.Controls.Add(this.btnF2);
			this.Controls.Add(this.btnF3);
			this.Controls.Add(this.btnF4);
			this.Controls.Add(this.btnF5);
			this.Controls.Add(this.btnF6);
			this.Controls.Add(this.btnF11);
			this.Controls.Add(this.btnF10);
			this.Controls.Add(this.btnF9);
			this.Controls.Add(this.btnF8);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnF8;
		private System.Windows.Forms.Button btnF9;
		private System.Windows.Forms.Button btnF11;
		private System.Windows.Forms.Button btnF10;
		private System.Windows.Forms.Button btnF5;
		private System.Windows.Forms.Button btnF6;
		private System.Windows.Forms.Button btnF7;
		private System.Windows.Forms.Button btnF1;
		private System.Windows.Forms.Button btnF2;
		private System.Windows.Forms.Button btnF3;
		private System.Windows.Forms.Button btnF4;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.Button btnF16;
		private System.Windows.Forms.Timer timer1;
	}
}

