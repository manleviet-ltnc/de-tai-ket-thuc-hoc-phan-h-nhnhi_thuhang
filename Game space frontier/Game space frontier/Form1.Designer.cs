﻿namespace Game_space_frontier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pt6 = new System.Windows.Forms.PictureBox();
            this.pt5 = new System.Windows.Forms.PictureBox();
            this.pt4 = new System.Windows.Forms.PictureBox();
            this.pt3 = new System.Windows.Forms.PictureBox();
            this.pt1 = new System.Windows.Forms.PictureBox();
            this.pt2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Game_space_frontier.Properties.Resources._24171782_731403400387906_1730956268_n;
            this.pictureBox7.Location = new System.Drawing.Point(104, 31);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 405);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pt6
            // 
            this.pt6.Image = global::Game_space_frontier.Properties.Resources._24205089_731399947054918_1645669417_n;
            this.pt6.Location = new System.Drawing.Point(272, 97);
            this.pt6.Name = "pt6";
            this.pt6.Size = new System.Drawing.Size(15, 50);
            this.pt6.TabIndex = 7;
            this.pt6.TabStop = false;
            this.pt6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pt2_MouseDown);
            // 
            // pt5
            // 
            this.pt5.Image = global::Game_space_frontier.Properties.Resources._24252204_731392297055683_1430542226_n1;
            this.pt5.Location = new System.Drawing.Point(271, 141);
            this.pt5.Name = "pt5";
            this.pt5.Size = new System.Drawing.Size(17, 39);
            this.pt5.TabIndex = 6;
            this.pt5.TabStop = false;
            this.pt5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pt2_MouseDown);
            // 
            // pt4
            // 
            this.pt4.Image = global::Game_space_frontier.Properties.Resources._24252204_731392297055683_1430542226_n1;
            this.pt4.Location = new System.Drawing.Point(271, 177);
            this.pt4.Name = "pt4";
            this.pt4.Size = new System.Drawing.Size(19, 39);
            this.pt4.TabIndex = 5;
            this.pt4.TabStop = false;
            this.pt4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pt2_MouseDown);
            // 
            // pt3
            // 
            this.pt3.Image = global::Game_space_frontier.Properties.Resources._24171690_731396687055244_1674059907_n;
            this.pt3.Location = new System.Drawing.Point(259, 208);
            this.pt3.Name = "pt3";
            this.pt3.Size = new System.Drawing.Size(43, 79);
            this.pt3.TabIndex = 4;
            this.pt3.TabStop = false;
            this.pt3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pt2_MouseDown);
            // 
            // pt1
            // 
            this.pt1.Image = global::Game_space_frontier.Properties.Resources._24252000_731395973721982_1552960467_n;
            this.pt1.Location = new System.Drawing.Point(258, 281);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(49, 77);
            this.pt1.TabIndex = 3;
            this.pt1.TabStop = false;
            this.pt1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pt2_MouseDown);
            // 
            // pt2
            // 
            this.pt2.Image = global::Game_space_frontier.Properties.Resources._24172419_731391543722425_207069886_n;
            this.pt2.Location = new System.Drawing.Point(245, 346);
            this.pt2.Name = "pt2";
            this.pt2.Size = new System.Drawing.Size(77, 97);
            this.pt2.TabIndex = 2;
            this.pt2.TabStop = false;
            this.pt2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pt2_MouseDown);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(424, 366);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 34);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 461);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pt6);
            this.Controls.Add(this.pt5);
            this.Controls.Add(this.pt4);
            this.Controls.Add(this.pt3);
            this.Controls.Add(this.pt1);
            this.Controls.Add(this.pt2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Game Space Frontier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pt2;
        private System.Windows.Forms.PictureBox pt1;
        private System.Windows.Forms.PictureBox pt3;
        private System.Windows.Forms.PictureBox pt4;
        private System.Windows.Forms.PictureBox pt5;
        private System.Windows.Forms.PictureBox pt6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnStart;
    }
}

