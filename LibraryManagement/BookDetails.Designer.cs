namespace LibraryManagement
{
    partial class BookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetails));
            this.dataGridViewBookDetails = new System.Windows.Forms.DataGridView();
            this.Editing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortButton = new System.Windows.Forms.Button();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.ReturnButoon = new System.Windows.Forms.Button();
            this.TextBoxBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxstudentname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRollno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxsort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookDetails)).BeginInit();
            this.Editing.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBookDetails
            // 
            this.dataGridViewBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookDetails.ContextMenuStrip = this.Editing;
            this.dataGridViewBookDetails.Location = new System.Drawing.Point(22, 67);
            this.dataGridViewBookDetails.Name = "dataGridViewBookDetails";
            this.dataGridViewBookDetails.ReadOnly = true;
            this.dataGridViewBookDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookDetails.Size = new System.Drawing.Size(600, 280);
            this.dataGridViewBookDetails.TabIndex = 0;
            // 
            // Editing
            // 
            this.Editing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.Editing.Name = "Editing";
            this.Editing.Size = new System.Drawing.Size(153, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "&Return Book";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertToolStripMenuItem.Text = "&Edit";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SortButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SortButton.Location = new System.Drawing.Point(536, 16);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(86, 29);
            this.SortButton.TabIndex = 3;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.Location = new System.Drawing.Point(22, 18);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(183, 26);
            this.textBoxname.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.Location = new System.Drawing.Point(229, 17);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(86, 28);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.ReturnButoon);
            this.panel1.Controls.Add(this.TextBoxBookName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxstudentname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxRollno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxISBN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 165);
            this.panel1.TabIndex = 6;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClose.Location = new System.Drawing.Point(471, 87);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(86, 40);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ReturnButoon
            // 
            this.ReturnButoon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReturnButoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ReturnButoon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReturnButoon.Location = new System.Drawing.Point(321, 87);
            this.ReturnButoon.Name = "ReturnButoon";
            this.ReturnButoon.Size = new System.Drawing.Size(130, 40);
            this.ReturnButoon.TabIndex = 18;
            this.ReturnButoon.Text = "Return Book";
            this.ReturnButoon.UseVisualStyleBackColor = false;
            this.ReturnButoon.Click += new System.EventHandler(this.ReturnButoon_Click);
            // 
            // TextBoxBookName
            // 
            this.TextBoxBookName.Location = new System.Drawing.Point(127, 94);
            this.TextBoxBookName.Name = "TextBoxBookName";
            this.TextBoxBookName.ReadOnly = true;
            this.TextBoxBookName.Size = new System.Drawing.Size(179, 20);
            this.TextBoxBookName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Book Name";
            // 
            // textBoxstudentname
            // 
            this.textBoxstudentname.Location = new System.Drawing.Point(128, 68);
            this.textBoxstudentname.Name = "textBoxstudentname";
            this.textBoxstudentname.ReadOnly = true;
            this.textBoxstudentname.Size = new System.Drawing.Size(179, 20);
            this.textBoxstudentname.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Student Name";
            // 
            // textBoxRollno
            // 
            this.textBoxRollno.Location = new System.Drawing.Point(129, 42);
            this.textBoxRollno.Name = "textBoxRollno";
            this.textBoxRollno.ReadOnly = true;
            this.textBoxRollno.Size = new System.Drawing.Size(179, 20);
            this.textBoxRollno.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Student Roll No.";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(131, 16);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(179, 20);
            this.textBoxISBN.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ISBN";
            // 
            // comboBoxsort
            // 
            this.comboBoxsort.FormattingEnabled = true;
            this.comboBoxsort.Items.AddRange(new object[] {
            "ID",
            "ISBN",
            "NameS",
            "NameB"});
            this.comboBoxsort.Location = new System.Drawing.Point(417, 21);
            this.comboBoxsort.Name = "comboBoxsort";
            this.comboBoxsort.Size = new System.Drawing.Size(94, 21);
            this.comboBoxsort.TabIndex = 2;
            this.comboBoxsort.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(340, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sort By";
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.comboBoxsort);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridViewBookDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Details to whom Books are Issued";
            this.Load += new System.EventHandler(this.BookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookDetails)).EndInit();
            this.Editing.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBookDetails;
        private System.Windows.Forms.ContextMenuStrip Editing;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button ReturnButoon;
        private System.Windows.Forms.TextBox TextBoxBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxstudentname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRollno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxsort;
        private System.Windows.Forms.Label label5;
    }
}