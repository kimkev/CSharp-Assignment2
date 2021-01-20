namespace Assignment2b
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblReviewer = new System.Windows.Forms.Label();
            this.lstBook = new System.Windows.Forms.ListBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtReviewer = new System.Windows.Forms.TextBox();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtReviews = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a book to review";
            // 
            // lblReviewer
            // 
            this.lblReviewer.AutoSize = true;
            this.lblReviewer.Location = new System.Drawing.Point(930, 110);
            this.lblReviewer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReviewer.Name = "lblReviewer";
            this.lblReviewer.Size = new System.Drawing.Size(98, 30);
            this.lblReviewer.TabIndex = 1;
            this.lblReviewer.Text = "Reviewer";
            this.lblReviewer.UseCompatibleTextRendering = true;
            // 
            // lstBook
            // 
            this.lstBook.FormattingEnabled = true;
            this.lstBook.HorizontalScrollbar = true;
            this.lstBook.ItemHeight = 25;
            this.lstBook.Location = new System.Drawing.Point(96, 104);
            this.lstBook.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstBook.Name = "lstBook";
            this.lstBook.Size = new System.Drawing.Size(770, 229);
            this.lstBook.TabIndex = 2;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Location = new System.Drawing.Point(924, 167);
            this.lblReview.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(82, 25);
            this.lblReview.TabIndex = 3;
            this.lblReview.Text = "Review";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(924, 225);
            this.lblId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 25);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(924, 292);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(924, 360);
            this.lblRating.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(170, 25);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Rating (optional)";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(924, 421);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(87, 25);
            this.lblBookId.TabIndex = 7;
            this.lblBookId.Text = "Book ID";
            // 
            // txtReviewer
            // 
            this.txtReviewer.Location = new System.Drawing.Point(1140, 104);
            this.txtReviewer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReviewer.Name = "txtReviewer";
            this.txtReviewer.Size = new System.Drawing.Size(218, 31);
            this.txtReviewer.TabIndex = 8;
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(1140, 162);
            this.txtReview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(218, 31);
            this.txtReview.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1140, 225);
            this.txtId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(218, 31);
            this.txtId.TabIndex = 10;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(1140, 287);
            this.txtDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(218, 31);
            this.txtDate.TabIndex = 11;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(1140, 354);
            this.txtRating.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(218, 31);
            this.txtRating.TabIndex = 12;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(1140, 415);
            this.txtBookId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(218, 31);
            this.txtBookId.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Review";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(942, 510);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 44);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(1208, 510);
            this.btnView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(150, 44);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(942, 590);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 44);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1208, 590);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 44);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtReviews
            // 
            this.txtReviews.Location = new System.Drawing.Point(96, 442);
            this.txtReviews.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReviews.Multiline = true;
            this.txtReviews.Name = "txtReviews";
            this.txtReviews.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReviews.Size = new System.Drawing.Size(645, 233);
            this.txtReviews.TabIndex = 19;
            this.txtReviews.WordWrap = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(318, 394);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(384, 25);
            this.lblNumber.TabIndex = 20;
            this.lblNumber.Text = "Number of Reviews added this session";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 722);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtReviews);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.txtReviewer);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.lstBook);
            this.Controls.Add(this.lblReviewer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReviewer;
        private System.Windows.Forms.ListBox lstBook;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtReviewer;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtReviews;
        private System.Windows.Forms.Label lblNumber;
    }
}

