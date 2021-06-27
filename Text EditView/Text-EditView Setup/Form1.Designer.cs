
namespace Text_EditView_Setup
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RunAppBeforeInstall = new System.Windows.Forms.CheckBox();
            this.SelectEdition = new System.Windows.Forms.ComboBox();
            this.InstallButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunAppBeforeInstall
            // 
            this.RunAppBeforeInstall.AutoSize = true;
            this.RunAppBeforeInstall.Location = new System.Drawing.Point(52, 98);
            this.RunAppBeforeInstall.Name = "RunAppBeforeInstall";
            this.RunAppBeforeInstall.Size = new System.Drawing.Size(179, 17);
            this.RunAppBeforeInstall.TabIndex = 0;
            this.RunAppBeforeInstall.Text = "Run Text EditView before install.";
            this.RunAppBeforeInstall.UseVisualStyleBackColor = true;
            // 
            // SelectEdition
            // 
            this.SelectEdition.FormattingEnabled = true;
            this.SelectEdition.Location = new System.Drawing.Point(52, 71);
            this.SelectEdition.Name = "SelectEdition";
            this.SelectEdition.Size = new System.Drawing.Size(129, 21);
            this.SelectEdition.TabIndex = 2;
            this.SelectEdition.Text = "Edition (coming soon).";
            // 
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(227, 206);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(130, 30);
            this.InstallButton.TabIndex = 3;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(42, 206);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 30);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 249);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.SelectEdition);
            this.Controls.Add(this.RunAppBeforeInstall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Installer Text-EditView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RunAppBeforeInstall;
        private System.Windows.Forms.ComboBox SelectEdition;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

