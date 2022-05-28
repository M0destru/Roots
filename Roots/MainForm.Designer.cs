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
            this.tsMenuReference = new System.Windows.Forms.ToolStripMenuItem();
            this.numUpDownPrecision = new System.Windows.Forms.NumericUpDown();
            this.lbAccuracy = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbArithmetic = new System.Windows.Forms.RadioButton();
            this.rbAnalytical = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrecision)).BeginInit();
            this.gbInput.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetRoot
            // 
            this.btnGetRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRoot.Location = new System.Drawing.Point(6, 56);
            this.btnGetRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetRoot.Name = "btnGetRoot";
            this.btnGetRoot.Size = new System.Drawing.Size(97, 29);
            this.btnGetRoot.TabIndex = 0;
            this.btnGetRoot.Text = "Извлечь корень";
            this.btnGetRoot.UseVisualStyleBackColor = true;
            this.btnGetRoot.Click += new System.EventHandler(this.btnGetRoot_Click);
            // 
            // btnClearNum
            // 
            this.btnClearNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNum.Location = new System.Drawing.Point(109, 56);
            this.btnClearNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearNum.Name = "btnClearNum";
            this.btnClearNum.Size = new System.Drawing.Size(97, 29);
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
            this.tbNum.PlaceholderText = "Введите число";
            this.tbNum.Size = new System.Drawing.Size(200, 25);
            this.tbNum.TabIndex = 2;
            this.tbNum.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuSettings,
            this.tsMenuReference});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
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
            // tsMenuReference
            // 
            this.tsMenuReference.Name = "tsMenuReference";
            this.tsMenuReference.Size = new System.Drawing.Size(65, 20);
            this.tsMenuReference.Text = "Справка";
            this.tsMenuReference.Click += new System.EventHandler(this.tsMenuReference_Click);
            // 
            // numUpDownPrecision
            // 
            this.numUpDownPrecision.Location = new System.Drawing.Point(274, 28);
            this.numUpDownPrecision.Name = "numUpDownPrecision";
            this.numUpDownPrecision.Size = new System.Drawing.Size(31, 25);
            this.numUpDownPrecision.TabIndex = 4;
            this.numUpDownPrecision.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUpDownPrecision.ValueChanged += new System.EventHandler(this.numUpDownPrecision_ValueChanged);
            // 
            // lbAccuracy
            // 
            this.lbAccuracy.AutoSize = true;
            this.lbAccuracy.Location = new System.Drawing.Point(211, 0);
            this.lbAccuracy.Name = "lbAccuracy";
            this.lbAccuracy.Size = new System.Drawing.Size(161, 17);
            this.lbAccuracy.TabIndex = 5;
            this.lbAccuracy.Text = "Разрядов после запятой";
            // 
            // tbResult
            // 
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.Enabled = false;
            this.tbResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbResult.Location = new System.Drawing.Point(3, 21);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(524, 41);
            this.tbResult.TabIndex = 6;
            // 
            // gbInput
            // 
            this.gbInput.AutoSize = true;
            this.gbInput.Controls.Add(this.label1);
            this.gbInput.Controls.Add(this.rbArithmetic);
            this.gbInput.Controls.Add(this.rbAnalytical);
            this.gbInput.Controls.Add(this.btnGetRoot);
            this.gbInput.Controls.Add(this.tbNum);
            this.gbInput.Controls.Add(this.btnClearNum);
            this.gbInput.Controls.Add(this.lbAccuracy);
            this.gbInput.Controls.Add(this.numUpDownPrecision);
            this.gbInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbInput.Location = new System.Drawing.Point(0, 24);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(530, 108);
            this.gbInput.TabIndex = 7;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Ввод числа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вывод корня";
            // 
            // rbArithmetic
            // 
            this.rbArithmetic.AutoSize = true;
            this.rbArithmetic.Checked = true;
            this.rbArithmetic.Location = new System.Drawing.Point(389, 28);
            this.rbArithmetic.Name = "rbArithmetic";
            this.rbArithmetic.Size = new System.Drawing.Size(135, 21);
            this.rbArithmetic.TabIndex = 7;
            this.rbArithmetic.TabStop = true;
            this.rbArithmetic.Text = "Арифметический";
            this.rbArithmetic.UseVisualStyleBackColor = true;
            // 
            // rbAnalytical
            // 
            this.rbAnalytical.AutoSize = true;
            this.rbAnalytical.Location = new System.Drawing.Point(389, 55);
            this.rbAnalytical.Name = "rbAnalytical";
            this.rbAnalytical.Size = new System.Drawing.Size(123, 21);
            this.rbAnalytical.TabIndex = 6;
            this.rbAnalytical.Text = "Аналитический";
            this.rbAnalytical.UseVisualStyleBackColor = true;
            this.rbAnalytical.CheckedChanged += new System.EventHandler(this.rbAnalytical_CheckedChanged);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.tbResult);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbResult.Location = new System.Drawing.Point(0, 132);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(530, 65);
            this.gbResult.TabIndex = 9;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 209);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyRoots";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrecision)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numUpDownPrecision;
        private System.Windows.Forms.Label lbAccuracy;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.GroupBox gbInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.RadioButton rbArithmetic;
        private System.Windows.Forms.RadioButton rbAnalytical;
        private System.Windows.Forms.ToolStripMenuItem tsMenuReference;
        private System.Windows.Forms.Label label1;
    }
}
