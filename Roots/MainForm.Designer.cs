namespace Roots
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGetRoot = new System.Windows.Forms.Button();
            this.btnClearNum = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbAccuracy = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbInput.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetRoot
            // 
            this.btnGetRoot.Location = new System.Drawing.Point(6, 55);
            this.btnGetRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetRoot.Name = "btnGetRoot";
            this.btnGetRoot.Size = new System.Drawing.Size(82, 22);
            this.btnGetRoot.TabIndex = 0;
            this.btnGetRoot.Text = "Извлечь корень";
            this.btnGetRoot.UseVisualStyleBackColor = true;
            this.btnGetRoot.Click += new System.EventHandler(this.btnGetRoot_Click);
            // 
            // btnClearNum
            // 
            this.btnClearNum.Location = new System.Drawing.Point(94, 55);
            this.btnClearNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearNum.Name = "btnClearNum";
            this.btnClearNum.Size = new System.Drawing.Size(82, 22);
            this.btnClearNum.TabIndex = 1;
            this.btnClearNum.Text = "Очистить";
            this.btnClearNum.UseVisualStyleBackColor = true;
            this.btnClearNum.Click += new System.EventHandler(this.btnClearNum_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(6, 28);
            this.tbNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(170, 23);
            this.tbNum.TabIndex = 2;
            this.tbNum.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenuSettings
            // 
            this.tsMenuSettings.Name = "tsMenuSettings";
            this.tsMenuSettings.Size = new System.Drawing.Size(79, 20);
            this.tsMenuSettings.Text = "Настройки";
            this.tsMenuSettings.Click += new System.EventHandler(this.tsMenuSettings_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(214, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(31, 23);
            this.numericUpDown1.TabIndex = 4;
            // 
            // lbAccuracy
            // 
            this.lbAccuracy.AutoSize = true;
            this.lbAccuracy.Location = new System.Drawing.Point(196, 11);
            this.lbAccuracy.Name = "lbAccuracy";
            this.lbAccuracy.Size = new System.Drawing.Size(58, 15);
            this.lbAccuracy.TabIndex = 5;
            this.lbAccuracy.Text = "Точность";
            // 
            // tbResult
            // 
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.Enabled = false;
            this.tbResult.Location = new System.Drawing.Point(3, 19);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(470, 78);
            this.tbResult.TabIndex = 6;
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.radioButton2);
            this.gbInput.Controls.Add(this.radioButton1);
            this.gbInput.Controls.Add(this.tbNum);
            this.gbInput.Controls.Add(this.btnGetRoot);
            this.gbInput.Controls.Add(this.btnClearNum);
            this.gbInput.Controls.Add(this.lbAccuracy);
            this.gbInput.Controls.Add(this.numericUpDown1);
            this.gbInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInput.Location = new System.Drawing.Point(0, 24);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(476, 115);
            this.gbInput.TabIndex = 7;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Ввод числа";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(342, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 19);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Арифметический";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(342, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 19);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Аналитический";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.tbResult);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbResult.Location = new System.Drawing.Point(0, 139);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(476, 100);
            this.gbResult.TabIndex = 9;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 238);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MyRoots";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetRoot;
        private System.Windows.Forms.Button btnClearNum;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSettings;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbAccuracy;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.GroupBox gbInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
