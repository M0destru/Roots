namespace Roots
{
    partial class SettingsForm
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
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.gbLanguageFile = new System.Windows.Forms.GroupBox();
            this.btnLoadLanguageFile = new System.Windows.Forms.Button();
            this.btnGetPath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.gbLanguageFile.SuspendLayout();
            this.gbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(6, 26);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(466, 28);
            this.cbLanguage.TabIndex = 0;
            // 
            // gbLanguageFile
            // 
            this.gbLanguageFile.Controls.Add(this.btnLoadLanguageFile);
            this.gbLanguageFile.Controls.Add(this.btnGetPath);
            this.gbLanguageFile.Controls.Add(this.textBox1);
            this.gbLanguageFile.Location = new System.Drawing.Point(0, 88);
            this.gbLanguageFile.Name = "gbLanguageFile";
            this.gbLanguageFile.Size = new System.Drawing.Size(478, 118);
            this.gbLanguageFile.TabIndex = 1;
            this.gbLanguageFile.TabStop = false;
            this.gbLanguageFile.Text = "Языковой файл";
            // 
            // btnLoadLanguageFile
            // 
            this.btnLoadLanguageFile.Location = new System.Drawing.Point(264, 78);
            this.btnLoadLanguageFile.Name = "btnLoadLanguageFile";
            this.btnLoadLanguageFile.Size = new System.Drawing.Size(208, 29);
            this.btnLoadLanguageFile.TabIndex = 2;
            this.btnLoadLanguageFile.Text = "Загрузить языковой файл";
            this.btnLoadLanguageFile.UseVisualStyleBackColor = true;
            // 
            // btnGetPath
            // 
            this.btnGetPath.Location = new System.Drawing.Point(436, 35);
            this.btnGetPath.Name = "btnGetPath";
            this.btnGetPath.Size = new System.Drawing.Size(36, 27);
            this.btnGetPath.TabIndex = 1;
            this.btnGetPath.Text = "...";
            this.btnGetPath.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 27);
            this.textBox1.TabIndex = 0;
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.cbLanguage);
            this.gbLanguage.Location = new System.Drawing.Point(0, 12);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(474, 78);
            this.gbLanguage.TabIndex = 2;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Язык";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 207);
            this.Controls.Add(this.gbLanguage);
            this.Controls.Add(this.gbLanguageFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.TopMost = true;
            this.gbLanguageFile.ResumeLayout(false);
            this.gbLanguageFile.PerformLayout();
            this.gbLanguage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.GroupBox gbLanguageFile;
        private System.Windows.Forms.Button btnLoadLanguageFile;
        private System.Windows.Forms.Button btnGetPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbLanguage;
    }
}