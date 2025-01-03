using System;

namespace RealDrumApp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrash1 = new System.Windows.Forms.Button();
            this.btnFloor = new System.Windows.Forms.Button();
            this.btnTom1 = new System.Windows.Forms.Button();
            this.bnTom2 = new System.Windows.Forms.Button();
            this.btnSnare = new System.Windows.Forms.Button();
            this.btnKick1 = new System.Windows.Forms.Button();
            this.btnKick2 = new System.Windows.Forms.Button();
            this.btnSplash = new System.Windows.Forms.Button();
            this.btnCrash2 = new System.Windows.Forms.Button();
            this.btnRide = new System.Windows.Forms.Button();
            this.btnTom3 = new System.Windows.Forms.Button();
            this.btnCloseHH = new System.Windows.Forms.Button();
            this.btnOpenHH = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStartRecord = new System.Windows.Forms.Button();
            this.btnPlayRecording = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStopRecord = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealDrumApp.Properties.Resources.drum;
            this.pictureBox1.Location = new System.Drawing.Point(30, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCrash1
            // 
            this.btnCrash1.BackColor = System.Drawing.Color.Transparent;
            this.btnCrash1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrash1.Location = new System.Drawing.Point(92, 44);
            this.btnCrash1.Name = "btnCrash1";
            this.btnCrash1.Size = new System.Drawing.Size(129, 144);
            this.btnCrash1.TabIndex = 1;
            this.btnCrash1.Text = "crash1";
            this.btnCrash1.UseVisualStyleBackColor = false;
            this.btnCrash1.Click += new System.EventHandler(this.btnCrash1_Click);
            // 
            // btnFloor
            // 
            this.btnFloor.Location = new System.Drawing.Point(30, 224);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(121, 137);
            this.btnFloor.TabIndex = 2;
            this.btnFloor.Text = "floor";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click_1);
            // 
            // btnTom1
            // 
            this.btnTom1.Location = new System.Drawing.Point(238, 158);
            this.btnTom1.Name = "btnTom1";
            this.btnTom1.Size = new System.Drawing.Size(72, 68);
            this.btnTom1.TabIndex = 3;
            this.btnTom1.Text = "tom1";
            this.btnTom1.UseVisualStyleBackColor = true;
            this.btnTom1.Click += new System.EventHandler(this.btnTom1_Click);
            // 
            // bnTom2
            // 
            this.bnTom2.Location = new System.Drawing.Point(354, 94);
            this.bnTom2.Name = "bnTom2";
            this.bnTom2.Size = new System.Drawing.Size(74, 94);
            this.bnTom2.TabIndex = 4;
            this.bnTom2.Text = "tom2";
            this.bnTom2.UseVisualStyleBackColor = true;
            this.bnTom2.Click += new System.EventHandler(this.bnTom2_Click);
            // 
            // btnSnare
            // 
            this.btnSnare.Location = new System.Drawing.Point(339, 195);
            this.btnSnare.Name = "btnSnare";
            this.btnSnare.Size = new System.Drawing.Size(116, 117);
            this.btnSnare.TabIndex = 5;
            this.btnSnare.Text = "snare";
            this.btnSnare.UseVisualStyleBackColor = true;
            this.btnSnare.Click += new System.EventHandler(this.btnSnare_Click);
            // 
            // btnKick1
            // 
            this.btnKick1.Location = new System.Drawing.Point(195, 272);
            this.btnKick1.Name = "btnKick1";
            this.btnKick1.Size = new System.Drawing.Size(134, 137);
            this.btnKick1.TabIndex = 6;
            this.btnKick1.Text = "kick1";
            this.btnKick1.UseVisualStyleBackColor = true;
            this.btnKick1.Click += new System.EventHandler(this.btnKick1_Click);
            // 
            // btnKick2
            // 
            this.btnKick2.Location = new System.Drawing.Point(445, 283);
            this.btnKick2.Name = "btnKick2";
            this.btnKick2.Size = new System.Drawing.Size(142, 126);
            this.btnKick2.TabIndex = 7;
            this.btnKick2.Text = "kick2";
            this.btnKick2.UseVisualStyleBackColor = true;
            this.btnKick2.Click += new System.EventHandler(this.btnKick2_Click);
            // 
            // btnSplash
            // 
            this.btnSplash.BackColor = System.Drawing.Color.White;
            this.btnSplash.Location = new System.Drawing.Point(254, 44);
            this.btnSplash.Name = "btnSplash";
            this.btnSplash.Size = new System.Drawing.Size(94, 75);
            this.btnSplash.TabIndex = 8;
            this.btnSplash.Text = "splash";
            this.btnSplash.UseVisualStyleBackColor = false;
            this.btnSplash.Click += new System.EventHandler(this.btnSplash_Click_1);
            // 
            // btnCrash2
            // 
            this.btnCrash2.Location = new System.Drawing.Point(434, 38);
            this.btnCrash2.Name = "btnCrash2";
            this.btnCrash2.Size = new System.Drawing.Size(105, 96);
            this.btnCrash2.TabIndex = 9;
            this.btnCrash2.Text = "crash2";
            this.btnCrash2.UseVisualStyleBackColor = true;
            this.btnCrash2.Click += new System.EventHandler(this.btnCrash2_Click);
            // 
            // btnRide
            // 
            this.btnRide.Location = new System.Drawing.Point(582, 44);
            this.btnRide.Name = "btnRide";
            this.btnRide.Size = new System.Drawing.Size(146, 130);
            this.btnRide.TabIndex = 10;
            this.btnRide.Text = "ride";
            this.btnRide.UseVisualStyleBackColor = true;
            this.btnRide.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnTom3
            // 
            this.btnTom3.Location = new System.Drawing.Point(473, 150);
            this.btnTom3.Name = "btnTom3";
            this.btnTom3.Size = new System.Drawing.Size(100, 88);
            this.btnTom3.TabIndex = 11;
            this.btnTom3.Text = "tom3";
            this.btnTom3.UseVisualStyleBackColor = true;
            this.btnTom3.Click += new System.EventHandler(this.btnTom3_Click);
            // 
            // btnCloseHH
            // 
            this.btnCloseHH.Location = new System.Drawing.Point(615, 203);
            this.btnCloseHH.Name = "btnCloseHH";
            this.btnCloseHH.Size = new System.Drawing.Size(113, 78);
            this.btnCloseHH.TabIndex = 12;
            this.btnCloseHH.Text = "close hh";
            this.btnCloseHH.UseVisualStyleBackColor = true;
            this.btnCloseHH.Click += new System.EventHandler(this.btnCloseHH_Click);
            // 
            // btnOpenHH
            // 
            this.btnOpenHH.Location = new System.Drawing.Point(636, 292);
            this.btnOpenHH.Name = "btnOpenHH";
            this.btnOpenHH.Size = new System.Drawing.Size(118, 80);
            this.btnOpenHH.TabIndex = 13;
            this.btnOpenHH.Text = "open hh";
            this.btnOpenHH.UseVisualStyleBackColor = true;
            this.btnOpenHH.Click += new System.EventHandler(this.btnOpenHH_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RealDrumApp.Properties.Resources.drum1;
            this.pictureBox2.Location = new System.Drawing.Point(30, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(725, 380);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.BackColor = System.Drawing.Color.Lime;
            this.btnStartRecord.Location = new System.Drawing.Point(41, 433);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.Size = new System.Drawing.Size(122, 28);
            this.btnStartRecord.TabIndex = 15;
            this.btnStartRecord.Text = "StartRecord";
            this.btnStartRecord.UseVisualStyleBackColor = false;
            this.btnStartRecord.Click += new System.EventHandler(this.btnStartRecord_Click);
            // 
            // btnPlayRecording
            // 
            this.btnPlayRecording.BackColor = System.Drawing.Color.Cyan;
            this.btnPlayRecording.Location = new System.Drawing.Point(333, 467);
            this.btnPlayRecording.Name = "btnPlayRecording";
            this.btnPlayRecording.Size = new System.Drawing.Size(122, 28);
            this.btnPlayRecording.TabIndex = 16;
            this.btnPlayRecording.Text = "PlayRecording";
            this.btnPlayRecording.UseVisualStyleBackColor = false;
            this.btnPlayRecording.Click += new System.EventHandler(this.btnPlayRecording_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 501);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(719, 13);
            this.progressBar1.TabIndex = 17;
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.BackColor = System.Drawing.Color.Red;
            this.btnStopRecord.Location = new System.Drawing.Point(633, 433);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(122, 28);
            this.btnStopRecord.TabIndex = 18;
            this.btnStopRecord.Text = "StopRecord";
            this.btnStopRecord.UseVisualStyleBackColor = false;
            this.btnStopRecord.Click += new System.EventHandler(this.btnStopRecord_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStatus.Location = new System.Drawing.Point(346, 431);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 16);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status: Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStopRecord);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnPlayRecording);
            this.Controls.Add(this.btnStartRecord);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOpenHH);
            this.Controls.Add(this.btnCloseHH);
            this.Controls.Add(this.btnTom3);
            this.Controls.Add(this.btnRide);
            this.Controls.Add(this.btnCrash2);
            this.Controls.Add(this.btnSplash);
            this.Controls.Add(this.btnKick2);
            this.Controls.Add(this.btnKick1);
            this.Controls.Add(this.btnSnare);
            this.Controls.Add(this.bnTom2);
            this.Controls.Add(this.btnTom1);
            this.Controls.Add(this.btnFloor);
            this.Controls.Add(this.btnCrash1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCrash1;
        private System.Windows.Forms.Button btnFloor;
        private System.Windows.Forms.Button btnTom1;
        private System.Windows.Forms.Button bnTom2;
        private System.Windows.Forms.Button btnSnare;
        private System.Windows.Forms.Button btnKick1;
        private System.Windows.Forms.Button btnKick2;
        private System.Windows.Forms.Button btnSplash;
        private System.Windows.Forms.Button btnCrash2;
        private System.Windows.Forms.Button btnRide;
        private System.Windows.Forms.Button btnTom3;
        private System.Windows.Forms.Button btnCloseHH;
        private System.Windows.Forms.Button btnOpenHH;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStartRecord;
        private System.Windows.Forms.Button btnPlayRecording;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStopRecord;
        private System.Windows.Forms.Label lblStatus;
    }
}

