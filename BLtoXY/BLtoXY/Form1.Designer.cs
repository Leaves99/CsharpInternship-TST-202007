namespace BLtoXY
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Exit = new System.Windows.Forms.Button();
            this.SaveTXT = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Calculate = new System.Windows.Forms.Button();
            this.OpenBLTXT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ExitAll = new System.Windows.Forms.Button();
            this.SaveXYTxt = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.BandChange = new System.Windows.Forms.Button();
            this.OpenXYTxt = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ChangePages = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(66, 106);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1662, 492);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Exit);
            this.tabPage1.Controls.Add(this.SaveTXT);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.Calculate);
            this.tabPage1.Controls.Add(this.OpenBLTXT);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1654, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BL->XY";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(969, 399);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(393, 55);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SaveTXT
            // 
            this.SaveTXT.Location = new System.Drawing.Point(969, 319);
            this.SaveTXT.Name = "SaveTXT";
            this.SaveTXT.Size = new System.Drawing.Size(393, 55);
            this.SaveTXT.TabIndex = 4;
            this.SaveTXT.Text = "保存";
            this.SaveTXT.UseVisualStyleBackColor = true;
            this.SaveTXT.Click += new System.EventHandler(this.SaveTXT_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView2.Location = new System.Drawing.Point(782, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(754, 250);
            this.dataGridView2.TabIndex = 3;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(133, 399);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(393, 55);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "计算";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // OpenBLTXT
            // 
            this.OpenBLTXT.Location = new System.Drawing.Point(133, 319);
            this.OpenBLTXT.Name = "OpenBLTXT";
            this.OpenBLTXT.Size = new System.Drawing.Size(393, 55);
            this.OpenBLTXT.TabIndex = 1;
            this.OpenBLTXT.Text = "打开文件";
            this.OpenBLTXT.UseVisualStyleBackColor = true;
            this.OpenBLTXT.Click += new System.EventHandler(this.OpenBLTXT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(7, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(715, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ExitAll);
            this.tabPage2.Controls.Add(this.SaveXYTxt);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.BandChange);
            this.tabPage2.Controls.Add(this.OpenXYTxt);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1654, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "换带计算";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ExitAll
            // 
            this.ExitAll.Location = new System.Drawing.Point(1025, 378);
            this.ExitAll.Name = "ExitAll";
            this.ExitAll.Size = new System.Drawing.Size(393, 55);
            this.ExitAll.TabIndex = 11;
            this.ExitAll.Text = "退出";
            this.ExitAll.UseVisualStyleBackColor = true;
            this.ExitAll.Click += new System.EventHandler(this.ExitAll_Click);
            // 
            // SaveXYTxt
            // 
            this.SaveXYTxt.Location = new System.Drawing.Point(1025, 298);
            this.SaveXYTxt.Name = "SaveXYTxt";
            this.SaveXYTxt.Size = new System.Drawing.Size(393, 55);
            this.SaveXYTxt.TabIndex = 10;
            this.SaveXYTxt.Text = "保存";
            this.SaveXYTxt.UseVisualStyleBackColor = true;
            this.SaveXYTxt.Click += new System.EventHandler(this.SaveXYTxt_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView4.Location = new System.Drawing.Point(838, 27);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 30;
            this.dataGridView4.Size = new System.Drawing.Size(754, 250);
            this.dataGridView4.TabIndex = 9;
            // 
            // BandChange
            // 
            this.BandChange.Location = new System.Drawing.Point(189, 378);
            this.BandChange.Name = "BandChange";
            this.BandChange.Size = new System.Drawing.Size(393, 55);
            this.BandChange.TabIndex = 8;
            this.BandChange.Text = "换带计算";
            this.BandChange.UseVisualStyleBackColor = true;
            this.BandChange.Click += new System.EventHandler(this.BandChange_Click);
            // 
            // OpenXYTxt
            // 
            this.OpenXYTxt.Location = new System.Drawing.Point(189, 298);
            this.OpenXYTxt.Name = "OpenXYTxt";
            this.OpenXYTxt.Size = new System.Drawing.Size(393, 55);
            this.OpenXYTxt.TabIndex = 7;
            this.OpenXYTxt.Text = "打开文件";
            this.OpenXYTxt.UseVisualStyleBackColor = true;
            this.OpenXYTxt.Click += new System.EventHandler(this.OpenXYTxt_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView3.Location = new System.Drawing.Point(63, 27);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 30;
            this.dataGridView3.Size = new System.Drawing.Size(715, 250);
            this.dataGridView3.TabIndex = 6;
            // 
            // ChangePages
            // 
            this.ChangePages.Location = new System.Drawing.Point(70, 28);
            this.ChangePages.Name = "ChangePages";
            this.ChangePages.Size = new System.Drawing.Size(183, 45);
            this.ChangePages.TabIndex = 1;
            this.ChangePages.Text = "切换页面";
            this.ChangePages.UseVisualStyleBackColor = true;
            this.ChangePages.Click += new System.EventHandler(this.ChangePages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 661);
            this.Controls.Add(this.ChangePages);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ChangePages;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button OpenBLTXT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SaveTXT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ExitAll;
        private System.Windows.Forms.Button SaveXYTxt;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button BandChange;
        private System.Windows.Forms.Button OpenXYTxt;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

