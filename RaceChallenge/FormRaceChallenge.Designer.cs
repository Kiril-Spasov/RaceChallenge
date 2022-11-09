namespace RaceChallenge
{
    partial class FormRaceChallenge
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
            this.PicRedCar = new System.Windows.Forms.PictureBox();
            this.PicYellowCar = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicRedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYellowCar)).BeginInit();
            this.SuspendLayout();
            // 
            // PicRedCar
            // 
            this.PicRedCar.BackColor = System.Drawing.Color.Transparent;
            this.PicRedCar.Location = new System.Drawing.Point(12, 139);
            this.PicRedCar.Name = "PicRedCar";
            this.PicRedCar.Size = new System.Drawing.Size(157, 125);
            this.PicRedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRedCar.TabIndex = 0;
            this.PicRedCar.TabStop = false;
            // 
            // PicYellowCar
            // 
            this.PicYellowCar.BackColor = System.Drawing.Color.Transparent;
            this.PicYellowCar.Location = new System.Drawing.Point(12, 270);
            this.PicYellowCar.Name = "PicYellowCar";
            this.PicYellowCar.Size = new System.Drawing.Size(157, 122);
            this.PicYellowCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicYellowCar.TabIndex = 1;
            this.PicYellowCar.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(26, 493);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(121, 33);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(169, 493);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(115, 33);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(307, 492);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(100, 33);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FormRaceChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::RaceChallenge.Properties.Resources.asphalt_road_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 544);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.PicYellowCar);
            this.Controls.Add(this.PicRedCar);
            this.Name = "FormRaceChallenge";
            this.Text = "Race Challenge";
            this.Load += new System.EventHandler(this.FormRaceChallenge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicRedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYellowCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicRedCar;
        private System.Windows.Forms.PictureBox PicYellowCar;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnReset;
    }
}

