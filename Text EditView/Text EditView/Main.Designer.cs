
namespace TextEditView.App
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.StandartMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyTextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteTextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CutTextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllTextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseFontButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseBackgroundButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.FontChooserDialog = new System.Windows.Forms.FontDialog();
            this.SelectColorDialog = new System.Windows.Forms.ColorDialog();
            this.InputHelper = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyTextHelper = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteTextHelper = new System.Windows.Forms.ToolStripMenuItem();
            this.CutTextHelper = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllTextHelper = new System.Windows.Forms.ToolStripMenuItem();
            this.StandartMenu.SuspendLayout();
            this.InputHelper.SuspendLayout();
            this.SuspendLayout();
            // 
            // StandartMenu
            // 
            this.StandartMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.SettingsMenu});
            this.StandartMenu.Location = new System.Drawing.Point(0, 0);
            this.StandartMenu.Name = "StandartMenu";
            this.StandartMenu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.StandartMenu.Size = new System.Drawing.Size(764, 26);
            this.StandartMenu.TabIndex = 0;
            this.StandartMenu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileButton,
            this.OpenFileButton,
            this.SaveFileButton,
            this.SaveAsFileButton});
            this.FileMenu.Image = global::TextEditView.App.Icons.File;
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(53, 20);
            this.FileMenu.Text = "File";
            // 
            // NewFileButton
            // 
            this.NewFileButton.Image = global::TextEditView.App.Icons.NewFile;
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(180, 22);
            this.NewFileButton.Text = "New";
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Image = global::TextEditView.App.Icons.OpenFile;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(180, 22);
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Image = global::TextEditView.App.Icons.SaveFile;
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(180, 22);
            this.SaveFileButton.Text = "Save";
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // SaveAsFileButton
            // 
            this.SaveAsFileButton.Image = global::TextEditView.App.Icons.SaveAsFile;
            this.SaveAsFileButton.Name = "SaveAsFileButton";
            this.SaveAsFileButton.Size = new System.Drawing.Size(180, 22);
            this.SaveAsFileButton.Text = "Save as";
            this.SaveAsFileButton.Click += new System.EventHandler(this.SaveAsFileButton_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyTextButton,
            this.PasteTextButton,
            this.CutTextButton,
            this.SelectAllTextButton});
            this.EditMenu.Image = global::TextEditView.App.Icons.EditText;
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(55, 20);
            this.EditMenu.Text = "Edit";
            // 
            // CopyTextButton
            // 
            this.CopyTextButton.Image = global::TextEditView.App.Icons.CopyText;
            this.CopyTextButton.Name = "CopyTextButton";
            this.CopyTextButton.Size = new System.Drawing.Size(180, 22);
            this.CopyTextButton.Text = "Copy";
            this.CopyTextButton.Click += new System.EventHandler(this.CopyTextButton_Click);
            // 
            // PasteTextButton
            // 
            this.PasteTextButton.Image = global::TextEditView.App.Icons.PasteText;
            this.PasteTextButton.Name = "PasteTextButton";
            this.PasteTextButton.Size = new System.Drawing.Size(180, 22);
            this.PasteTextButton.Text = "Paste";
            this.PasteTextButton.Click += new System.EventHandler(this.PasteTextButton_Click);
            // 
            // CutTextButton
            // 
            this.CutTextButton.Image = global::TextEditView.App.Icons.CutText;
            this.CutTextButton.Name = "CutTextButton";
            this.CutTextButton.Size = new System.Drawing.Size(180, 22);
            this.CutTextButton.Text = "Cut";
            this.CutTextButton.Click += new System.EventHandler(this.CutTextButton_Click);
            // 
            // SelectAllTextButton
            // 
            this.SelectAllTextButton.Image = global::TextEditView.App.Icons.SelectAllText;
            this.SelectAllTextButton.Name = "SelectAllTextButton";
            this.SelectAllTextButton.Size = new System.Drawing.Size(180, 22);
            this.SelectAllTextButton.Text = "Select All";
            this.SelectAllTextButton.Click += new System.EventHandler(this.SelectAllTextButton_Click);
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseFontButton,
            this.ChooseBackgroundButton});
            this.SettingsMenu.Image = global::TextEditView.App.Icons.Settings;
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.Size = new System.Drawing.Size(77, 20);
            this.SettingsMenu.Text = "Settings";
            // 
            // ChooseFontButton
            // 
            this.ChooseFontButton.Image = global::TextEditView.App.Icons.ChooseFont;
            this.ChooseFontButton.Name = "ChooseFontButton";
            this.ChooseFontButton.Size = new System.Drawing.Size(181, 22);
            this.ChooseFontButton.Text = "Choose font";
            this.ChooseFontButton.Click += new System.EventHandler(this.ChooseFontButton_Click);
            // 
            // ChooseBackgroundButton
            // 
            this.ChooseBackgroundButton.Image = global::TextEditView.App.Icons.ChooseBackground;
            this.ChooseBackgroundButton.Name = "ChooseBackgroundButton";
            this.ChooseBackgroundButton.Size = new System.Drawing.Size(181, 22);
            this.ChooseBackgroundButton.Text = "Choose background";
            this.ChooseBackgroundButton.Click += new System.EventHandler(this.ChooseBackgroundButton_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            this.SaveFileDialog.RestoreDirectory = true;
            this.SaveFileDialog.Title = "Text EditView: Saving file";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            this.OpenFileDialog.Title = "Text EditView: Opening file";
            // 
            // InputText
            // 
            this.InputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputText.Location = new System.Drawing.Point(0, 26);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(764, 387);
            this.InputText.TabIndex = 1;
            this.InputText.Text = "";
            this.InputText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InputText_MouseUp);
            // 
            // SelectColorDialog
            // 
            this.SelectColorDialog.AnyColor = true;
            // 
            // InputHelper
            // 
            this.InputHelper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyTextHelper,
            this.PasteTextHelper,
            this.CutTextHelper,
            this.SelectAllTextHelper});
            this.InputHelper.Name = "InputHelper";
            this.InputHelper.Size = new System.Drawing.Size(123, 92);
            // 
            // CopyTextHelper
            // 
            this.CopyTextHelper.Image = global::TextEditView.App.Icons.CopyText;
            this.CopyTextHelper.Name = "CopyTextHelper";
            this.CopyTextHelper.Size = new System.Drawing.Size(122, 22);
            this.CopyTextHelper.Text = "Copy";
            this.CopyTextHelper.Click += new System.EventHandler(this.CopyTextHelper_Click);
            // 
            // PasteTextHelper
            // 
            this.PasteTextHelper.Image = global::TextEditView.App.Icons.PasteText;
            this.PasteTextHelper.Name = "PasteTextHelper";
            this.PasteTextHelper.Size = new System.Drawing.Size(122, 22);
            this.PasteTextHelper.Text = "Paste";
            this.PasteTextHelper.Click += new System.EventHandler(this.PasteTextHelper_Click);
            // 
            // CutTextHelper
            // 
            this.CutTextHelper.Image = global::TextEditView.App.Icons.CutText;
            this.CutTextHelper.Name = "CutTextHelper";
            this.CutTextHelper.Size = new System.Drawing.Size(122, 22);
            this.CutTextHelper.Text = "Cut";
            this.CutTextHelper.Click += new System.EventHandler(this.CutTextHelper_Click);
            // 
            // SelectAllTextHelper
            // 
            this.SelectAllTextHelper.Image = global::TextEditView.App.Icons.SelectAllText;
            this.SelectAllTextHelper.Name = "SelectAllTextHelper";
            this.SelectAllTextHelper.Size = new System.Drawing.Size(122, 22);
            this.SelectAllTextHelper.Text = "Select All";
            this.SelectAllTextHelper.Click += new System.EventHandler(this.SelectAllTextHelper_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 413);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.StandartMenu);
            this.Font = new System.Drawing.Font("Tekton Pro Ext", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.StandartMenu;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Main";
            this.Text = "Text EditView - Basic Edition";
            this.StandartMenu.ResumeLayout(false);
            this.StandartMenu.PerformLayout();
            this.InputHelper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StandartMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem NewFileButton;
        private System.Windows.Forms.ToolStripMenuItem OpenFileButton;
        private System.Windows.Forms.ToolStripMenuItem SaveFileButton;
        private System.Windows.Forms.ToolStripMenuItem SaveAsFileButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyTextButton;
        private System.Windows.Forms.ToolStripMenuItem PasteTextButton;
        private System.Windows.Forms.ToolStripMenuItem CutTextButton;
        private System.Windows.Forms.ToolStripMenuItem SelectAllTextButton;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem ChooseFontButton;
        private System.Windows.Forms.ToolStripMenuItem ChooseBackgroundButton;
        private System.Windows.Forms.FontDialog FontChooserDialog;
        private System.Windows.Forms.ColorDialog SelectColorDialog;
        private System.Windows.Forms.ContextMenuStrip InputHelper;
        private System.Windows.Forms.ToolStripMenuItem CopyTextHelper;
        private System.Windows.Forms.ToolStripMenuItem PasteTextHelper;
        private System.Windows.Forms.ToolStripMenuItem CutTextHelper;
        private System.Windows.Forms.ToolStripMenuItem SelectAllTextHelper;
    }
}