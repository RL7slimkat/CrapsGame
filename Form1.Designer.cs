namespace CrapsGame
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.handGif = new System.Windows.Forms.PictureBox();
            this.diceBox2 = new System.Windows.Forms.PictureBox();
            this.diceBox1 = new System.Windows.Forms.PictureBox();
            this.handTimer = new System.Windows.Forms.Timer(this.components);
            this.diceThrowTimer = new System.Windows.Forms.Timer(this.components);
            this.dicePickupTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPointText = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.chipsBox1 = new System.Windows.Forms.PictureBox();
            this.chipsBox2 = new System.Windows.Forms.PictureBox();
            this.lammerBox10 = new System.Windows.Forms.PictureBox();
            this.lammerBox0 = new System.Windows.Forms.PictureBox();
            this.chipsOffTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.handGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chipsBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chipsBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lammerBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lammerBox0)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Gold;
            this.btnPlay.Location = new System.Drawing.Point(425, 410);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(377, 41);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(101, 410);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(326, 40);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(1, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.BackColor = System.Drawing.Color.Thistle;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(48, 410);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(53, 41);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // handGif
            // 
            this.handGif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.handGif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.handGif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.handGif.Image = global::CrapsGame.Properties.Resources.diceRoll1;
            this.handGif.Location = new System.Drawing.Point(351, 213);
            this.handGif.Name = "handGif";
            this.handGif.Size = new System.Drawing.Size(145, 148);
            this.handGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handGif.TabIndex = 4;
            this.handGif.TabStop = false;
            // 
            // diceBox2
            // 
            this.diceBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diceBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.diceBox2.Image = global::CrapsGame.Properties.Resources.rightDice5;
            this.diceBox2.Location = new System.Drawing.Point(411, 283);
            this.diceBox2.Name = "diceBox2";
            this.diceBox2.Size = new System.Drawing.Size(57, 61);
            this.diceBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceBox2.TabIndex = 5;
            this.diceBox2.TabStop = false;
            // 
            // diceBox1
            // 
            this.diceBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diceBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.diceBox1.Image = global::CrapsGame.Properties.Resources.leftDice6;
            this.diceBox1.Location = new System.Drawing.Point(363, 265);
            this.diceBox1.Name = "diceBox1";
            this.diceBox1.Size = new System.Drawing.Size(56, 56);
            this.diceBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceBox1.TabIndex = 6;
            this.diceBox1.TabStop = false;
            // 
            // handTimer
            // 
            this.handTimer.Interval = 2100;
            this.handTimer.Tick += new System.EventHandler(this.handTimer_Tick);
            // 
            // diceThrowTimer
            // 
            this.diceThrowTimer.Interval = 1000;
            this.diceThrowTimer.Tick += new System.EventHandler(this.diceThrowTimer_Tick);
            // 
            // dicePickupTimer
            // 
            this.dicePickupTimer.Interval = 2500;
            this.dicePickupTimer.Tick += new System.EventHandler(this.dicePickupTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(351, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 148);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblRes.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.ForeColor = System.Drawing.Color.Gold;
            this.lblRes.Location = new System.Drawing.Point(12, 9);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(131, 25);
            this.lblRes.TabIndex = 8;
            this.lblRes.Text = "OUTCOME:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(91)))));
            this.lblResult.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.Location = new System.Drawing.Point(10, 34);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(25, 28);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "0";
            // 
            // lblPointText
            // 
            this.lblPointText.AutoSize = true;
            this.lblPointText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblPointText.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointText.ForeColor = System.Drawing.Color.Gold;
            this.lblPointText.Location = new System.Drawing.Point(700, 9);
            this.lblPointText.Name = "lblPointText";
            this.lblPointText.Size = new System.Drawing.Size(88, 25);
            this.lblPointText.TabIndex = 10;
            this.lblPointText.Text = "POINT:";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblPoint.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPoint.Location = new System.Drawing.Point(763, 34);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(25, 28);
            this.lblPoint.TabIndex = 11;
            this.lblPoint.Text = "0";
            // 
            // chipsBox1
            // 
            this.chipsBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(78)))));
            this.chipsBox1.Image = global::CrapsGame.Properties.Resources.chipsFall;
            this.chipsBox1.Location = new System.Drawing.Point(1, 65);
            this.chipsBox1.Name = "chipsBox1";
            this.chipsBox1.Size = new System.Drawing.Size(53, 348);
            this.chipsBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chipsBox1.TabIndex = 12;
            this.chipsBox1.TabStop = false;
            // 
            // chipsBox2
            // 
            this.chipsBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(78)))));
            this.chipsBox2.Image = global::CrapsGame.Properties.Resources.chipsRise;
            this.chipsBox2.Location = new System.Drawing.Point(1, 65);
            this.chipsBox2.Name = "chipsBox2";
            this.chipsBox2.Size = new System.Drawing.Size(53, 348);
            this.chipsBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chipsBox2.TabIndex = 13;
            this.chipsBox2.TabStop = false;
            // 
            // lammerBox10
            // 
            this.lammerBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lammerBox10.Image = global::CrapsGame.Properties.Resources.onLammer;
            this.lammerBox10.Location = new System.Drawing.Point(592, 58);
            this.lammerBox10.Name = "lammerBox10";
            this.lammerBox10.Size = new System.Drawing.Size(53, 46);
            this.lammerBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lammerBox10.TabIndex = 14;
            this.lammerBox10.TabStop = false;
            // 
            // lammerBox0
            // 
            this.lammerBox0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lammerBox0.Image = global::CrapsGame.Properties.Resources.offLammer;
            this.lammerBox0.Location = new System.Drawing.Point(664, 58);
            this.lammerBox0.Name = "lammerBox0";
            this.lammerBox0.Size = new System.Drawing.Size(53, 46);
            this.lammerBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lammerBox0.TabIndex = 14;
            this.lammerBox0.TabStop = false;
            // 
            // chipsOffTimer
            // 
            this.chipsOffTimer.Interval = 5500;
            this.chipsOffTimer.Tick += new System.EventHandler(this.chipsOffTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.BackgroundImage = global::CrapsGame.Properties.Resources.layout1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lammerBox0);
            this.Controls.Add(this.lammerBox10);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblPointText);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.diceBox1);
            this.Controls.Add(this.diceBox2);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.handGif);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chipsBox1);
            this.Controls.Add(this.chipsBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " Craps";
            ((System.ComponentModel.ISupportInitialize)(this.handGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chipsBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chipsBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lammerBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lammerBox0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox handGif;
        private System.Windows.Forms.PictureBox diceBox2;
        private System.Windows.Forms.PictureBox diceBox1;
        private System.Windows.Forms.Timer handTimer;
        private System.Windows.Forms.Timer diceThrowTimer;
        private System.Windows.Forms.Timer dicePickupTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPointText;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.PictureBox chipsBox1;
        private System.Windows.Forms.PictureBox chipsBox2;
        private System.Windows.Forms.PictureBox lammerBox10;
        private System.Windows.Forms.PictureBox lammerBox0;
        private System.Windows.Forms.Timer chipsOffTimer;
    }
}

