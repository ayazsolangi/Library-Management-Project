namespace LibraryManagement
{
    partial class studentcardprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentcardprint));
            this.printbutton = new System.Windows.Forms.Button();
            this.DVprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.DVprintDocument = new System.Drawing.Printing.PrintDocument();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelexpires = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelissuecard = new System.Windows.Forms.Label();
            this.labelrollno = new System.Windows.Forms.Label();
            this.labeldepartment = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.buttonPRINT = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printbutton
            // 
            this.printbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.printbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printbutton.Location = new System.Drawing.Point(613, 208);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(134, 53);
            this.printbutton.TabIndex = 0;
            this.printbutton.Text = "Print Preview";
            this.printbutton.UseVisualStyleBackColor = false;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // DVprintPreviewDialog
            // 
            this.DVprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DVprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DVprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.DVprintPreviewDialog.Enabled = true;
            this.DVprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("DVprintPreviewDialog.Icon")));
            this.DVprintPreviewDialog.Name = "DVprintPreviewDialog";
            this.DVprintPreviewDialog.Visible = false;
            // 
            // DVprintDocument
            // 
            this.DVprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DVprintDocument_PrintPage);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(133, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(143, 26);
            this.textBoxID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter Roll No";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(519, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(302, 8);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(134, 53);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LibraryManagement.Properties.Resources.frame;
            this.panel1.Controls.Add(this.labelexpires);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelissuecard);
            this.panel1.Controls.Add(this.labelrollno);
            this.panel1.Controls.Add(this.labeldepartment);
            this.panel1.Controls.Add(this.labelname);
            this.panel1.Location = new System.Drawing.Point(5, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 326);
            this.panel1.TabIndex = 1;
            // 
            // labelexpires
            // 
            this.labelexpires.AutoSize = true;
            this.labelexpires.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelexpires.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelexpires.Location = new System.Drawing.Point(140, 269);
            this.labelexpires.Name = "labelexpires";
            this.labelexpires.Size = new System.Drawing.Size(82, 25);
            this.labelexpires.TabIndex = 2;
            this.labelexpires.Text = "20/10/21";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement.Properties.Resources.b;
            this.pictureBox1.Location = new System.Drawing.Point(441, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelissuecard
            // 
            this.labelissuecard.AutoSize = true;
            this.labelissuecard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelissuecard.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelissuecard.Location = new System.Drawing.Point(140, 231);
            this.labelissuecard.Name = "labelissuecard";
            this.labelissuecard.Size = new System.Drawing.Size(82, 25);
            this.labelissuecard.TabIndex = 0;
            this.labelissuecard.Text = "20/10/21";
            // 
            // labelrollno
            // 
            this.labelrollno.AutoSize = true;
            this.labelrollno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelrollno.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrollno.Location = new System.Drawing.Point(140, 195);
            this.labelrollno.Name = "labelrollno";
            this.labelrollno.Size = new System.Drawing.Size(87, 25);
            this.labelrollno.TabIndex = 0;
            this.labelrollno.Text = "CS-00-00";
            // 
            // labeldepartment
            // 
            this.labeldepartment.AutoSize = true;
            this.labeldepartment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeldepartment.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldepartment.Location = new System.Drawing.Point(140, 154);
            this.labeldepartment.Name = "labeldepartment";
            this.labeldepartment.Size = new System.Drawing.Size(167, 25);
            this.labeldepartment.TabIndex = 0;
            this.labeldepartment.Text = "Computer Science";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelname.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(140, 116);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(103, 25);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Baqir Raza";
            // 
            // buttonPRINT
            // 
            this.buttonPRINT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPRINT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPRINT.Location = new System.Drawing.Point(613, 267);
            this.buttonPRINT.Name = "buttonPRINT";
            this.buttonPRINT.Size = new System.Drawing.Size(134, 53);
            this.buttonPRINT.TabIndex = 0;
            this.buttonPRINT.Text = "Print";
            this.buttonPRINT.UseVisualStyleBackColor = false;
            this.buttonPRINT.Click += new System.EventHandler(this.buttonPRINT_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(613, 333);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 53);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // studentcardprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 410);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPRINT);
            this.Controls.Add(this.printbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "studentcardprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Student Library Card";
            this.Load += new System.EventHandler(this.studentcardprint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.PrintPreviewDialog DVprintPreviewDialog;
        private System.Drawing.Printing.PrintDocument DVprintDocument;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelissuecard;
        private System.Windows.Forms.Label labelrollno;
        private System.Windows.Forms.Label labeldepartment;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelexpires;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonPRINT;
        private System.Windows.Forms.Button buttonCancel;
    }
}