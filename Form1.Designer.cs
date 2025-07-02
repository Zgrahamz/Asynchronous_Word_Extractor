namespace Asynchronous_Word_Extractor
{
    partial class BookWordListerForm
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookBox2 = new System.Windows.Forms.GroupBox();
            this.displayBook2 = new System.Windows.Forms.RichTextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.browseBtn2 = new System.Windows.Forms.Button();
            this.selectedBook2 = new System.Windows.Forms.TextBox();
            this.bookLabel2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.bookLabel1 = new System.Windows.Forms.Label();
            this.selectedBook1 = new System.Windows.Forms.TextBox();
            this.browseBtn1 = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.bookBox1 = new System.Windows.Forms.GroupBox();
            this.displayBook1 = new System.Windows.Forms.RichTextBox();
            this.bookBox2.SuspendLayout();
            this.bookBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookBox2
            // 
            this.bookBox2.Controls.Add(this.displayBook2);
            this.bookBox2.Controls.Add(this.exitBtn);
            this.bookBox2.Controls.Add(this.browseBtn2);
            this.bookBox2.Controls.Add(this.selectedBook2);
            this.bookBox2.Controls.Add(this.bookLabel2);
            this.bookBox2.Location = new System.Drawing.Point(722, 12);
            this.bookBox2.Name = "bookBox2";
            this.bookBox2.Size = new System.Drawing.Size(675, 752);
            this.bookBox2.TabIndex = 1;
            this.bookBox2.TabStop = false;
            // 
            // displayBook2
            // 
            this.displayBook2.Location = new System.Drawing.Point(75, 178);
            this.displayBook2.Name = "displayBook2";
            this.displayBook2.Size = new System.Drawing.Size(426, 536);
            this.displayBook2.TabIndex = 5;
            this.displayBook2.Text = "";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitBtn.Location = new System.Drawing.Point(6, 108);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 35);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // browseBtn2
            // 
            this.browseBtn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.browseBtn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.browseBtn2.Location = new System.Drawing.Point(506, 54);
            this.browseBtn2.Name = "browseBtn2";
            this.browseBtn2.Size = new System.Drawing.Size(164, 32);
            this.browseBtn2.TabIndex = 3;
            this.browseBtn2.Text = "Browse";
            this.browseBtn2.UseVisualStyleBackColor = false;
            this.browseBtn2.Click += new System.EventHandler(this.browseBtn2_Click);
            // 
            // selectedBook2
            // 
            this.selectedBook2.Location = new System.Drawing.Point(75, 54);
            this.selectedBook2.Name = "selectedBook2";
            this.selectedBook2.Size = new System.Drawing.Size(426, 26);
            this.selectedBook2.TabIndex = 2;
            // 
            // bookLabel2
            // 
            this.bookLabel2.AutoSize = true;
            this.bookLabel2.Location = new System.Drawing.Point(6, 57);
            this.bookLabel2.Name = "bookLabel2";
            this.bookLabel2.Size = new System.Drawing.Size(59, 20);
            this.bookLabel2.TabIndex = 0;
            this.bookLabel2.Text = "Book 2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // bookLabel1
            // 
            this.bookLabel1.AutoSize = true;
            this.bookLabel1.Location = new System.Drawing.Point(6, 57);
            this.bookLabel1.Name = "bookLabel1";
            this.bookLabel1.Size = new System.Drawing.Size(59, 20);
            this.bookLabel1.TabIndex = 0;
            this.bookLabel1.Text = "Book 1";
            // 
            // selectedBook1
            // 
            this.selectedBook1.Location = new System.Drawing.Point(75, 54);
            this.selectedBook1.Name = "selectedBook1";
            this.selectedBook1.Size = new System.Drawing.Size(426, 26);
            this.selectedBook1.TabIndex = 1;
            // 
            // browseBtn1
            // 
            this.browseBtn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.browseBtn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.browseBtn1.Location = new System.Drawing.Point(506, 54);
            this.browseBtn1.Name = "browseBtn1";
            this.browseBtn1.Size = new System.Drawing.Size(164, 32);
            this.browseBtn1.TabIndex = 2;
            this.browseBtn1.Text = "Browse";
            this.browseBtn1.UseVisualStyleBackColor = false;
            this.browseBtn1.Click += new System.EventHandler(this.browseBtn1_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submitBtn.Location = new System.Drawing.Point(548, 108);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(122, 35);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // bookBox1
            // 
            this.bookBox1.Controls.Add(this.displayBook1);
            this.bookBox1.Controls.Add(this.submitBtn);
            this.bookBox1.Controls.Add(this.browseBtn1);
            this.bookBox1.Controls.Add(this.selectedBook1);
            this.bookBox1.Controls.Add(this.bookLabel1);
            this.bookBox1.Location = new System.Drawing.Point(12, 12);
            this.bookBox1.Name = "bookBox1";
            this.bookBox1.Size = new System.Drawing.Size(675, 752);
            this.bookBox1.TabIndex = 0;
            this.bookBox1.TabStop = false;
            // 
            // displayBook1
            // 
            this.displayBook1.Location = new System.Drawing.Point(75, 178);
            this.displayBook1.Name = "displayBook1";
            this.displayBook1.Size = new System.Drawing.Size(426, 536);
            this.displayBook1.TabIndex = 4;
            this.displayBook1.Text = "";
            // 
            // BookWordListerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 775);
            this.Controls.Add(this.bookBox2);
            this.Controls.Add(this.bookBox1);
            this.Name = "BookWordListerForm";
            this.Text = "Asynchronous Word Extractor";
            this.bookBox2.ResumeLayout(false);
            this.bookBox2.PerformLayout();
            this.bookBox1.ResumeLayout(false);
            this.bookBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox bookBox2;
        private System.Windows.Forms.Label bookLabel2;
        private System.Windows.Forms.TextBox selectedBook2;
        private System.Windows.Forms.Button browseBtn2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label bookLabel1;
        private System.Windows.Forms.TextBox selectedBook1;
        private System.Windows.Forms.Button browseBtn1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.GroupBox bookBox1;
        private System.Windows.Forms.RichTextBox displayBook2;
        private System.Windows.Forms.RichTextBox displayBook1;
    }
}

