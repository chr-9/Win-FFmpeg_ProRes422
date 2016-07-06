namespace prores
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proRes422HQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proRes422ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proRes422ProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proRes422LTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.q5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.q9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.q11ToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.q13ToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.q20ToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.QuitToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.AddToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddToolStripMenuItem.Text = "Add";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.QuitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.QuitToolStripMenuItem.Text = "Quit";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CodecToolStripMenuItem,
            this.QualityToolStripMenuItem});
            this.SettingsToolStripMenuItem.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // CodecToolStripMenuItem
            // 
            this.CodecToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CodecToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CodecToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proRes422HQToolStripMenuItem,
            this.proRes422ToolStripMenuItem,
            this.proRes422ProxyToolStripMenuItem,
            this.proRes422LTToolStripMenuItem});
            this.CodecToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CodecToolStripMenuItem.Name = "CodecToolStripMenuItem";
            this.CodecToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CodecToolStripMenuItem.Text = "Codec";
            // 
            // proRes422HQToolStripMenuItem
            // 
            this.proRes422HQToolStripMenuItem.AutoToolTip = true;
            this.proRes422HQToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.proRes422HQToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.proRes422HQToolStripMenuItem.Name = "proRes422HQToolStripMenuItem";
            this.proRes422HQToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.proRes422HQToolStripMenuItem.Text = "ProRes 422 HQ";
            this.proRes422HQToolStripMenuItem.ToolTipText = resources.GetString("proRes422HQToolStripMenuItem.ToolTipText");
            this.proRes422HQToolStripMenuItem.Click += new System.EventHandler(this.proRes422HQToolStripMenuItem_Click);
            // 
            // proRes422ToolStripMenuItem
            // 
            this.proRes422ToolStripMenuItem.AutoToolTip = true;
            this.proRes422ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.proRes422ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.proRes422ToolStripMenuItem.Name = "proRes422ToolStripMenuItem";
            this.proRes422ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.proRes422ToolStripMenuItem.Text = "ProRes 422";
            this.proRes422ToolStripMenuItem.ToolTipText = resources.GetString("proRes422ToolStripMenuItem.ToolTipText");
            this.proRes422ToolStripMenuItem.Click += new System.EventHandler(this.proRes422ToolStripMenuItem_Click);
            // 
            // proRes422ProxyToolStripMenuItem
            // 
            this.proRes422ProxyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.proRes422ProxyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.proRes422ProxyToolStripMenuItem.Name = "proRes422ProxyToolStripMenuItem";
            this.proRes422ProxyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.proRes422ProxyToolStripMenuItem.Text = "ProRes 422 Proxy";
            this.proRes422ProxyToolStripMenuItem.ToolTipText = resources.GetString("proRes422ProxyToolStripMenuItem.ToolTipText");
            this.proRes422ProxyToolStripMenuItem.Click += new System.EventHandler(this.proRes422ProxyToolStripMenuItem_Click);
            // 
            // proRes422LTToolStripMenuItem
            // 
            this.proRes422LTToolStripMenuItem.AutoToolTip = true;
            this.proRes422LTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.proRes422LTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.proRes422LTToolStripMenuItem.Name = "proRes422LTToolStripMenuItem";
            this.proRes422LTToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.proRes422LTToolStripMenuItem.Text = "ProRes 422 LT";
            this.proRes422LTToolStripMenuItem.ToolTipText = resources.GetString("proRes422LTToolStripMenuItem.ToolTipText");
            this.proRes422LTToolStripMenuItem.Click += new System.EventHandler(this.proRes422LTToolStripMenuItem_Click);
            // 
            // QualityToolStripMenuItem
            // 
            this.QualityToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.QualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.q5ToolStripMenuItem,
            this.q9ToolStripMenuItem,
            this.q11ToolStripMenu,
            this.q13ToolStripMenu,
            this.q20ToolStripMenu});
            this.QualityToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.QualityToolStripMenuItem.Name = "QualityToolStripMenuItem";
            this.QualityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.QualityToolStripMenuItem.Text = "Quality";
            // 
            // q5ToolStripMenuItem
            // 
            this.q5ToolStripMenuItem.AutoToolTip = true;
            this.q5ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.q5ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.q5ToolStripMenuItem.Name = "q5ToolStripMenuItem";
            this.q5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.q5ToolStripMenuItem.Text = "5 (best)";
            this.q5ToolStripMenuItem.ToolTipText = "qscale=5";
            this.q5ToolStripMenuItem.Click += new System.EventHandler(this.q5ToolStripMenuItem_Click);
            // 
            // q9ToolStripMenuItem
            // 
            this.q9ToolStripMenuItem.AutoToolTip = true;
            this.q9ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.q9ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.q9ToolStripMenuItem.Name = "q9ToolStripMenuItem";
            this.q9ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.q9ToolStripMenuItem.Text = "9";
            this.q9ToolStripMenuItem.ToolTipText = "qscale=9";
            this.q9ToolStripMenuItem.Click += new System.EventHandler(this.q9ToolStripMenuItem_Click);
            // 
            // q11ToolStripMenu
            // 
            this.q11ToolStripMenu.AutoToolTip = true;
            this.q11ToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.q11ToolStripMenu.ForeColor = System.Drawing.Color.White;
            this.q11ToolStripMenu.Name = "q11ToolStripMenu";
            this.q11ToolStripMenu.Size = new System.Drawing.Size(152, 22);
            this.q11ToolStripMenu.Text = "11";
            this.q11ToolStripMenu.ToolTipText = "qscale=11";
            this.q11ToolStripMenu.Click += new System.EventHandler(this.q11ToolStripMenu_Click);
            // 
            // q13ToolStripMenu
            // 
            this.q13ToolStripMenu.AutoToolTip = true;
            this.q13ToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.q13ToolStripMenu.ForeColor = System.Drawing.Color.White;
            this.q13ToolStripMenu.Name = "q13ToolStripMenu";
            this.q13ToolStripMenu.Size = new System.Drawing.Size(152, 22);
            this.q13ToolStripMenu.Text = "13";
            this.q13ToolStripMenu.ToolTipText = "qscale=13";
            this.q13ToolStripMenu.Click += new System.EventHandler(this.q13ToolStripMenu_Click);
            // 
            // q20ToolStripMenu
            // 
            this.q20ToolStripMenu.AutoToolTip = true;
            this.q20ToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.q20ToolStripMenu.ForeColor = System.Drawing.Color.White;
            this.q20ToolStripMenu.Name = "q20ToolStripMenu";
            this.q20ToolStripMenu.Size = new System.Drawing.Size(152, 22);
            this.q20ToolStripMenu.Text = "20 (lowest)";
            this.q20ToolStripMenu.ToolTipText = "qscale=20";
            this.q20ToolStripMenu.Click += new System.EventHandler(this.q20ToolStripMenu_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AllowDrop = true;
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(11, 30);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(639, 268);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDrop);
            this.checkedListBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(425, 303);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(540, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Encode";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.progressBar1.Location = new System.Drawing.Point(11, 341);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(638, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(11, 303);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 26);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add File";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(661, 363);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ffmpeg-prores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CodecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proRes422HQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proRes422ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proRes422LTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proRes422ProxyToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem QualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q11ToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem q13ToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem q20ToolStripMenu;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

