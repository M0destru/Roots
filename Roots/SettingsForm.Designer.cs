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
            this.tbFile = new System.Windows.Forms.TextBox();
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbLanguageFile.SuspendLayout();
            this.gbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(5, 20);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(408, 23);
            this.cbLanguage.TabIndex = 0;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // gbLanguageFile
            // 
            this.gbLanguageFile.Controls.Add(this.btnLoadLanguageFile);
            this.gbLanguageFile.Controls.Add(this.btnGetPath);
            this.gbLanguageFile.Controls.Add(this.tbFile);
            this.gbLanguageFile.Location = new System.Drawing.Point(0, 66);
            this.gbLanguageFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLanguageFile.Name = "gbLanguageFile";
            this.gbLanguageFile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLanguageFile.Size = new System.Drawing.Size(418, 88);
            this.gbLanguageFile.TabIndex = 1;
            this.gbLanguageFile.TabStop = false;
            this.gbLanguageFile.Text = "Языковой файл";
            // 
            // btnLoadLanguageFile
            // 
            this.btnLoadLanguageFile.Location = new System.Drawing.Point(230, 53);
            this.btnLoadLanguageFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadLanguageFile.Name = "btnLoadLanguageFile";
            this.btnLoadLanguageFile.Size = new System.Drawing.Size(182, 22);
            this.btnLoadLanguageFile.TabIndex = 2;
            this.btnLoadLanguageFile.Text = "Загрузить языковой файл";
            this.btnLoadLanguageFile.UseVisualStyleBackColor = true;
            this.btnLoadLanguageFile.Click += new System.EventHandler(this.btnLoadLanguageFile_Click);
            // 
            // btnGetPath
            // 
            this.btnGetPath.Location = new System.Drawing.Point(382, 26);
            this.btnGetPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetPath.Name = "btnGetPath";
            this.btnGetPath.Size = new System.Drawing.Size(32, 23);
            this.btnGetPath.TabIndex = 1;
            this.btnGetPath.Text = "...";
            this.btnGetPath.UseVisualStyleBackColor = true;
            this.btnGetPath.Click += new System.EventHandler(this.btnGetPath_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(5, 26);
            this.tbFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(372, 23);
            this.tbFile.TabIndex = 0;
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.cbLanguage);
            this.gbLanguage.Location = new System.Drawing.Point(0, 9);
            this.gbLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLanguage.Size = new System.Drawing.Size(415, 58);
            this.gbLanguage.TabIndex = 2;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Язык";
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOk.Location = new System.Drawing.Point(0, 163);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(417, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 186);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbLanguage);
            this.Controls.Add(this.gbLanguageFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.GroupBox gbLanguage;
        private System.Windows.Forms.Button btnOk;
    }
}