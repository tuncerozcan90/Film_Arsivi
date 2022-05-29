using System;
using System.Windows.Forms;

namespace Film_Arsivi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.filmler = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.filmler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 148);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Let\'s watch a movie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(972, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(369, 141);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // filmler
            // 
            this.filmler.Controls.Add(this.dataGridView1);
            this.filmler.Location = new System.Drawing.Point(345, 156);
            this.filmler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.filmler.Name = "filmler";
            this.filmler.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.filmler.Size = new System.Drawing.Size(313, 413);
            this.filmler.TabIndex = 1;
            this.filmler.TabStop = false;
            this.filmler.Text = "Movie List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(305, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Location = new System.Drawing.Point(666, 156);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(596, 417);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Screen";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(4, 24);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 23);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(588, 390);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLink);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCategory);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(16, 156);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(321, 223);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add new movie";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(145, 154);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 41);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Link :";
            // 
            // txtLink
            // 
            this.txtLink.BackColor = System.Drawing.Color.Cyan;
            this.txtLink.Location = new System.Drawing.Point(145, 120);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(168, 28);
            this.txtLink.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category :";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.Cyan;
            this.txtCategory.Location = new System.Drawing.Point(145, 83);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(168, 28);
            this.txtCategory.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movie name :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Cyan;
            this.txtName.Location = new System.Drawing.Point(145, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 28);
            this.txtName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnAbout);
            this.groupBox3.Controls.Add(this.btnFullScreen);
            this.groupBox3.Location = new System.Drawing.Point(16, 387);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(321, 183);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(76, 118);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 41);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAbout.Location = new System.Drawing.Point(76, 71);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(168, 41);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "About us";
            this.btnAbout.UseVisualStyleBackColor = false;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFullScreen.Location = new System.Drawing.Point(76, 24);
            this.btnFullScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(168, 41);
            this.btnFullScreen.TabIndex = 10;
            this.btnFullScreen.Text = "Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1279, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filmler);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "FİLM ARŞİVİM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.filmler.ResumeLayout(false);
          
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox filmler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnFullScreen;
        private readonly EventHandler FilmArsivim_Load;
        private Button button1;
    }
}

