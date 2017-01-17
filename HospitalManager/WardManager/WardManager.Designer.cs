namespace WMS
{
    partial class WardManager
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
            this.SuspendLayout();
            // 
            // WardManager
            // 
            this.Name = "WardManager";
            this.Text = "List of Wards";
            this.ResumeLayout(false);
            this.deleteButton.Text = "Delete Ward";
            this.addButton.Text = "Add Ward";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.searchTextBox.KeyDown +=
               new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);


        }

        #endregion
    }
}