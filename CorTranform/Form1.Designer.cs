namespace CorTranform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.单个转换 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clear = new System.Windows.Forms.Button();
            this.wgs84toHx = new System.Windows.Forms.Button();
            this.wgs84tobd = new System.Windows.Forms.Button();
            this.hx2bd = new System.Windows.Forms.Button();
            this.hx2wgs84 = new System.Windows.Forms.Button();
            this.bd2wgs84 = new System.Windows.Forms.Button();
            this.bd2hx = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_wgs84 = new System.Windows.Forms.TextBox();
            this.textBox_hx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_bd = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectCSV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.start_t = new System.Windows.Forms.Button();
            this.w84tohx = new System.Windows.Forms.Button();
            this.w84tobd = new System.Windows.Forms.Button();
            this.hx2bd_2 = new System.Windows.Forms.Button();
            this.hx2W84 = new System.Windows.Forms.Button();
            this.bd2W84 = new System.Windows.Forms.Button();
            this.bd2hx_2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.单个转换.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 单个转换
            // 
            this.单个转换.Controls.Add(this.tabPage1);
            this.单个转换.Controls.Add(this.tabPage2);
            this.单个转换.Dock = System.Windows.Forms.DockStyle.Fill;
            this.单个转换.Location = new System.Drawing.Point(0, 0);
            this.单个转换.Name = "单个转换";
            this.单个转换.SelectedIndex = 0;
            this.单个转换.Size = new System.Drawing.Size(365, 332);
            this.单个转换.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clear);
            this.tabPage1.Controls.Add(this.wgs84toHx);
            this.tabPage1.Controls.Add(this.wgs84tobd);
            this.tabPage1.Controls.Add(this.hx2bd);
            this.tabPage1.Controls.Add(this.hx2wgs84);
            this.tabPage1.Controls.Add(this.bd2wgs84);
            this.tabPage1.Controls.Add(this.bd2hx);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_wgs84);
            this.tabPage1.Controls.Add(this.textBox_hx);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_bd);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(357, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "单个转换";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(3, 274);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(346, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "清空";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button7_Click);
            // 
            // wgs84toHx
            // 
            this.wgs84toHx.Location = new System.Drawing.Point(6, 247);
            this.wgs84toHx.Name = "wgs84toHx";
            this.wgs84toHx.Size = new System.Drawing.Size(343, 23);
            this.wgs84toHx.TabIndex = 2;
            this.wgs84toHx.Text = "84转火星";
            this.wgs84toHx.UseVisualStyleBackColor = true;
            this.wgs84toHx.Click += new System.EventHandler(this.wgs84toHx_Click);
            // 
            // wgs84tobd
            // 
            this.wgs84tobd.Location = new System.Drawing.Point(6, 219);
            this.wgs84tobd.Name = "wgs84tobd";
            this.wgs84tobd.Size = new System.Drawing.Size(343, 23);
            this.wgs84tobd.TabIndex = 2;
            this.wgs84tobd.Text = "84转百度";
            this.wgs84tobd.UseVisualStyleBackColor = true;
            this.wgs84tobd.Click += new System.EventHandler(this.wgs84tobd_Click);
            // 
            // hx2bd
            // 
            this.hx2bd.Location = new System.Drawing.Point(6, 190);
            this.hx2bd.Name = "hx2bd";
            this.hx2bd.Size = new System.Drawing.Size(343, 23);
            this.hx2bd.TabIndex = 2;
            this.hx2bd.Text = "火星转百度";
            this.hx2bd.UseVisualStyleBackColor = true;
            this.hx2bd.Click += new System.EventHandler(this.hx2bd_Click);
            // 
            // hx2wgs84
            // 
            this.hx2wgs84.Location = new System.Drawing.Point(6, 161);
            this.hx2wgs84.Name = "hx2wgs84";
            this.hx2wgs84.Size = new System.Drawing.Size(343, 23);
            this.hx2wgs84.TabIndex = 2;
            this.hx2wgs84.Text = "火星转84";
            this.hx2wgs84.UseVisualStyleBackColor = true;
            this.hx2wgs84.Click += new System.EventHandler(this.hx2wgs84_Click);
            // 
            // bd2wgs84
            // 
            this.bd2wgs84.Location = new System.Drawing.Point(6, 132);
            this.bd2wgs84.Name = "bd2wgs84";
            this.bd2wgs84.Size = new System.Drawing.Size(343, 23);
            this.bd2wgs84.TabIndex = 2;
            this.bd2wgs84.Text = "百度转84";
            this.bd2wgs84.UseVisualStyleBackColor = true;
            this.bd2wgs84.Click += new System.EventHandler(this.bd2wgs84_Click);
            // 
            // bd2hx
            // 
            this.bd2hx.Location = new System.Drawing.Point(6, 103);
            this.bd2hx.Name = "bd2hx";
            this.bd2hx.Size = new System.Drawing.Size(343, 23);
            this.bd2hx.TabIndex = 2;
            this.bd2hx.Text = "百度转火星";
            this.bd2hx.UseVisualStyleBackColor = true;
            this.bd2hx.Click += new System.EventHandler(this.bd2hx_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "WGS84";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "火星坐标";
            // 
            // textBox_wgs84
            // 
            this.textBox_wgs84.Location = new System.Drawing.Point(83, 63);
            this.textBox_wgs84.Name = "textBox_wgs84";
            this.textBox_wgs84.Size = new System.Drawing.Size(266, 22);
            this.textBox_wgs84.TabIndex = 0;
            this.textBox_wgs84.Text = "128.543,37.065";
            // 
            // textBox_hx
            // 
            this.textBox_hx.Location = new System.Drawing.Point(83, 34);
            this.textBox_hx.Name = "textBox_hx";
            this.textBox_hx.Size = new System.Drawing.Size(266, 22);
            this.textBox_hx.TabIndex = 0;
            this.textBox_hx.Text = "128.543,37.065";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "百度坐标";
            // 
            // textBox_bd
            // 
            this.textBox_bd.Location = new System.Drawing.Point(83, 6);
            this.textBox_bd.Name = "textBox_bd";
            this.textBox_bd.Size = new System.Drawing.Size(266, 22);
            this.textBox_bd.TabIndex = 0;
            this.textBox_bd.Text = "128.543,37.065";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.selectCSV);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.start_t);
            this.tabPage2.Controls.Add(this.w84tohx);
            this.tabPage2.Controls.Add(this.w84tobd);
            this.tabPage2.Controls.Add(this.hx2bd_2);
            this.tabPage2.Controls.Add(this.hx2W84);
            this.tabPage2.Controls.Add(this.bd2W84);
            this.tabPage2.Controls.Add(this.bd2hx_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(357, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "文件转换";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "总条数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 15;
            // 
            // selectCSV
            // 
            this.selectCSV.Location = new System.Drawing.Point(78, 6);
            this.selectCSV.Name = "selectCSV";
            this.selectCSV.Size = new System.Drawing.Size(271, 23);
            this.selectCSV.TabIndex = 14;
            this.selectCSV.Text = "选择输入文件(csv文件)";
            this.selectCSV.UseVisualStyleBackColor = true;
            this.selectCSV.Click += new System.EventHandler(this.selectCSV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "转换类别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "输出坐标路径（默认在输入文件的同一目录）";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "输入坐标";
            // 
            // start_t
            // 
            this.start_t.Location = new System.Drawing.Point(12, 274);
            this.start_t.Name = "start_t";
            this.start_t.Size = new System.Drawing.Size(337, 23);
            this.start_t.TabIndex = 3;
            this.start_t.Text = "开始转换";
            this.start_t.UseVisualStyleBackColor = true;
            this.start_t.Click += new System.EventHandler(this.start_t_Click);
            // 
            // w84tohx
            // 
            this.w84tohx.Location = new System.Drawing.Point(12, 245);
            this.w84tohx.Name = "w84tohx";
            this.w84tohx.Size = new System.Drawing.Size(337, 23);
            this.w84tohx.TabIndex = 4;
            this.w84tohx.Text = "84转火星";
            this.w84tohx.UseVisualStyleBackColor = true;
            this.w84tohx.Click += new System.EventHandler(this.w84tohx_Click);
            // 
            // w84tobd
            // 
            this.w84tobd.Location = new System.Drawing.Point(12, 217);
            this.w84tobd.Name = "w84tobd";
            this.w84tobd.Size = new System.Drawing.Size(337, 23);
            this.w84tobd.TabIndex = 5;
            this.w84tobd.Text = "84转百度";
            this.w84tobd.UseVisualStyleBackColor = true;
            this.w84tobd.Click += new System.EventHandler(this.w84tobd_Click);
            // 
            // hx2bd_2
            // 
            this.hx2bd_2.Location = new System.Drawing.Point(12, 188);
            this.hx2bd_2.Name = "hx2bd_2";
            this.hx2bd_2.Size = new System.Drawing.Size(337, 23);
            this.hx2bd_2.TabIndex = 6;
            this.hx2bd_2.Text = "火星转百度";
            this.hx2bd_2.UseVisualStyleBackColor = true;
            this.hx2bd_2.Click += new System.EventHandler(this.hx2bd_2_Click);
            // 
            // hx2W84
            // 
            this.hx2W84.Location = new System.Drawing.Point(12, 159);
            this.hx2W84.Name = "hx2W84";
            this.hx2W84.Size = new System.Drawing.Size(337, 23);
            this.hx2W84.TabIndex = 7;
            this.hx2W84.Text = "火星转84";
            this.hx2W84.UseVisualStyleBackColor = true;
            this.hx2W84.Click += new System.EventHandler(this.hx2W84_Click);
            // 
            // bd2W84
            // 
            this.bd2W84.Location = new System.Drawing.Point(12, 130);
            this.bd2W84.Name = "bd2W84";
            this.bd2W84.Size = new System.Drawing.Size(337, 23);
            this.bd2W84.TabIndex = 8;
            this.bd2W84.Text = "百度转84";
            this.bd2W84.UseVisualStyleBackColor = true;
            this.bd2W84.Click += new System.EventHandler(this.bd2W84_Click);
            // 
            // bd2hx_2
            // 
            this.bd2hx_2.Location = new System.Drawing.Point(12, 101);
            this.bd2hx_2.Name = "bd2hx_2";
            this.bd2hx_2.Size = new System.Drawing.Size(337, 23);
            this.bd2hx_2.TabIndex = 9;
            this.bd2hx_2.Text = "百度转火星";
            this.bd2hx_2.UseVisualStyleBackColor = true;
            this.bd2hx_2.Click += new System.EventHandler(this.bd2hx_2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "已完成：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 332);
            this.Controls.Add(this.单个转换);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "坐标转换小工具";
            this.单个转换.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl 单个转换;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button wgs84toHx;
        private System.Windows.Forms.Button wgs84tobd;
        private System.Windows.Forms.Button hx2bd;
        private System.Windows.Forms.Button hx2wgs84;
        private System.Windows.Forms.Button bd2wgs84;
        private System.Windows.Forms.Button bd2hx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_wgs84;
        private System.Windows.Forms.TextBox textBox_hx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_bd;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button start_t;
        private System.Windows.Forms.Button w84tohx;
        private System.Windows.Forms.Button w84tobd;
        private System.Windows.Forms.Button hx2bd_2;
        private System.Windows.Forms.Button hx2W84;
        private System.Windows.Forms.Button bd2W84;
        private System.Windows.Forms.Button bd2hx_2;
        private System.Windows.Forms.Button selectCSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

