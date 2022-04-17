
namespace Poker.View
{
    partial class GameForm
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
            this.pb_Card1 = new System.Windows.Forms.PictureBox();
            this.pb_Card2 = new System.Windows.Forms.PictureBox();
            this.pb_Card3 = new System.Windows.Forms.PictureBox();
            this.pb_Card4 = new System.Windows.Forms.PictureBox();
            this.pb_Card5 = new System.Windows.Forms.PictureBox();
            this.lbl_Points = new System.Windows.Forms.Label();
            this.lbl_Bet = new System.Windows.Forms.Label();
            this.btn_Deli = new System.Windows.Forms.Button();
            this.btn_Zameni = new System.Windows.Forms.Button();
            this.tm_AnimateTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_PointsTxt = new System.Windows.Forms.Label();
            this.lbl_BetTxt = new System.Windows.Forms.Label();
            this.lbl_InstructionsTxt = new System.Windows.Forms.Label();
            this.lbl_PossibleWinTxt = new System.Windows.Forms.Label();
            this.lbl_PossibleWin = new System.Windows.Forms.Label();
            this.btn_Izlaz = new System.Windows.Forms.Button();
            this.lbl_Instructions = new System.Windows.Forms.TextBox();
            this.lbl_WinTxt = new System.Windows.Forms.Label();
            this.lbl_Win = new System.Windows.Forms.Label();
            this.lbl_WinPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card5)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Card1
            // 
            this.pb_Card1.Location = new System.Drawing.Point(19, 150);
            this.pb_Card1.Name = "pb_Card1";
            this.pb_Card1.Size = new System.Drawing.Size(90, 130);
            this.pb_Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Card1.TabIndex = 0;
            this.pb_Card1.TabStop = false;
            this.pb_Card1.Tag = "0";
            this.pb_Card1.Click += new System.EventHandler(this.Pb_Card_Click);
            // 
            // pb_Card2
            // 
            this.pb_Card2.Location = new System.Drawing.Point(149, 150);
            this.pb_Card2.Name = "pb_Card2";
            this.pb_Card2.Size = new System.Drawing.Size(90, 130);
            this.pb_Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Card2.TabIndex = 1;
            this.pb_Card2.TabStop = false;
            this.pb_Card2.Tag = "1";
            this.pb_Card2.Click += new System.EventHandler(this.Pb_Card_Click);
            // 
            // pb_Card3
            // 
            this.pb_Card3.Location = new System.Drawing.Point(279, 150);
            this.pb_Card3.Name = "pb_Card3";
            this.pb_Card3.Size = new System.Drawing.Size(90, 130);
            this.pb_Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Card3.TabIndex = 2;
            this.pb_Card3.TabStop = false;
            this.pb_Card3.Tag = "2";
            this.pb_Card3.Click += new System.EventHandler(this.Pb_Card_Click);
            // 
            // pb_Card4
            // 
            this.pb_Card4.Location = new System.Drawing.Point(409, 150);
            this.pb_Card4.Name = "pb_Card4";
            this.pb_Card4.Size = new System.Drawing.Size(90, 130);
            this.pb_Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Card4.TabIndex = 3;
            this.pb_Card4.TabStop = false;
            this.pb_Card4.Tag = "3";
            this.pb_Card4.Click += new System.EventHandler(this.Pb_Card_Click);
            // 
            // pb_Card5
            // 
            this.pb_Card5.Location = new System.Drawing.Point(539, 150);
            this.pb_Card5.Name = "pb_Card5";
            this.pb_Card5.Size = new System.Drawing.Size(90, 130);
            this.pb_Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Card5.TabIndex = 4;
            this.pb_Card5.TabStop = false;
            this.pb_Card5.Tag = "4";
            this.pb_Card5.Click += new System.EventHandler(this.Pb_Card_Click);
            // 
            // lbl_Points
            // 
            this.lbl_Points.AutoSize = true;
            this.lbl_Points.Location = new System.Drawing.Point(16, 41);
            this.lbl_Points.Name = "lbl_Points";
            this.lbl_Points.Size = new System.Drawing.Size(46, 17);
            this.lbl_Points.TabIndex = 5;
            this.lbl_Points.Text = "points";
            // 
            // lbl_Bet
            // 
            this.lbl_Bet.AutoSize = true;
            this.lbl_Bet.Location = new System.Drawing.Point(87, 41);
            this.lbl_Bet.Name = "lbl_Bet";
            this.lbl_Bet.Size = new System.Drawing.Size(28, 17);
            this.lbl_Bet.TabIndex = 6;
            this.lbl_Bet.Text = "bet";
            // 
            // btn_Deli
            // 
            this.btn_Deli.Location = new System.Drawing.Point(12, 285);
            this.btn_Deli.Name = "btn_Deli";
            this.btn_Deli.Size = new System.Drawing.Size(250, 56);
            this.btn_Deli.TabIndex = 9;
            this.btn_Deli.Text = "Deli";
            this.btn_Deli.UseVisualStyleBackColor = true;
            this.btn_Deli.Click += new System.EventHandler(this.Btn_Deli_Click);
            // 
            // btn_Zameni
            // 
            this.btn_Zameni.Enabled = false;
            this.btn_Zameni.Location = new System.Drawing.Point(409, 286);
            this.btn_Zameni.Name = "btn_Zameni";
            this.btn_Zameni.Size = new System.Drawing.Size(250, 56);
            this.btn_Zameni.TabIndex = 10;
            this.btn_Zameni.Text = "Zameni";
            this.btn_Zameni.UseVisualStyleBackColor = true;
            this.btn_Zameni.Click += new System.EventHandler(this.Btn_Zameni_Click);
            // 
            // tm_AnimateTimer
            // 
            this.tm_AnimateTimer.Interval = 10;
            this.tm_AnimateTimer.Tick += new System.EventHandler(this.Tm_AnimateTimer_Tick);
            // 
            // lbl_PointsTxt
            // 
            this.lbl_PointsTxt.AutoSize = true;
            this.lbl_PointsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PointsTxt.Location = new System.Drawing.Point(16, 21);
            this.lbl_PointsTxt.Name = "lbl_PointsTxt";
            this.lbl_PointsTxt.Size = new System.Drawing.Size(54, 17);
            this.lbl_PointsTxt.TabIndex = 11;
            this.lbl_PointsTxt.Text = "Poeni:";
            // 
            // lbl_BetTxt
            // 
            this.lbl_BetTxt.AutoSize = true;
            this.lbl_BetTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BetTxt.Location = new System.Drawing.Point(87, 21);
            this.lbl_BetTxt.Name = "lbl_BetTxt";
            this.lbl_BetTxt.Size = new System.Drawing.Size(46, 17);
            this.lbl_BetTxt.TabIndex = 12;
            this.lbl_BetTxt.Text = "Ulog:";
            // 
            // lbl_InstructionsTxt
            // 
            this.lbl_InstructionsTxt.AutoSize = true;
            this.lbl_InstructionsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InstructionsTxt.Location = new System.Drawing.Point(16, 66);
            this.lbl_InstructionsTxt.Name = "lbl_InstructionsTxt";
            this.lbl_InstructionsTxt.Size = new System.Drawing.Size(87, 17);
            this.lbl_InstructionsTxt.TabIndex = 13;
            this.lbl_InstructionsTxt.Text = "Instrukcije:";
            // 
            // lbl_PossibleWinTxt
            // 
            this.lbl_PossibleWinTxt.AutoSize = true;
            this.lbl_PossibleWinTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PossibleWinTxt.Location = new System.Drawing.Point(227, 21);
            this.lbl_PossibleWinTxt.Name = "lbl_PossibleWinTxt";
            this.lbl_PossibleWinTxt.Size = new System.Drawing.Size(271, 17);
            this.lbl_PossibleWinTxt.TabIndex = 14;
            this.lbl_PossibleWinTxt.Text = "Moguci dobitak sa trenutnom rukom:";
            // 
            // lbl_PossibleWin
            // 
            this.lbl_PossibleWin.AutoSize = true;
            this.lbl_PossibleWin.Location = new System.Drawing.Point(230, 42);
            this.lbl_PossibleWin.Name = "lbl_PossibleWin";
            this.lbl_PossibleWin.Size = new System.Drawing.Size(32, 17);
            this.lbl_PossibleWin.TabIndex = 15;
            this.lbl_PossibleWin.Text = "Win";
            this.lbl_PossibleWin.Visible = false;
            // 
            // btn_Izlaz
            // 
            this.btn_Izlaz.Location = new System.Drawing.Point(268, 286);
            this.btn_Izlaz.Name = "btn_Izlaz";
            this.btn_Izlaz.Size = new System.Drawing.Size(135, 55);
            this.btn_Izlaz.TabIndex = 17;
            this.btn_Izlaz.Text = "Izlaz";
            this.btn_Izlaz.UseVisualStyleBackColor = true;
            this.btn_Izlaz.Click += new System.EventHandler(this.Btn_Izlaz_Click);
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Instructions.Location = new System.Drawing.Point(19, 88);
            this.lbl_Instructions.Multiline = true;
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.ReadOnly = true;
            this.lbl_Instructions.Size = new System.Drawing.Size(640, 43);
            this.lbl_Instructions.TabIndex = 18;
            // 
            // lbl_WinTxt
            // 
            this.lbl_WinTxt.AutoSize = true;
            this.lbl_WinTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WinTxt.Location = new System.Drawing.Point(522, 21);
            this.lbl_WinTxt.Name = "lbl_WinTxt";
            this.lbl_WinTxt.Size = new System.Drawing.Size(137, 17);
            this.lbl_WinTxt.TabIndex = 19;
            this.lbl_WinTxt.Text = "Poslednji dobitak:";
            // 
            // lbl_Win
            // 
            this.lbl_Win.AutoSize = true;
            this.lbl_Win.Location = new System.Drawing.Point(522, 42);
            this.lbl_Win.Name = "lbl_Win";
            this.lbl_Win.Size = new System.Drawing.Size(54, 17);
            this.lbl_Win.TabIndex = 20;
            this.lbl_Win.Text = "dobitak";
            // 
            // lbl_WinPoints
            // 
            this.lbl_WinPoints.AutoSize = true;
            this.lbl_WinPoints.Location = new System.Drawing.Point(522, 59);
            this.lbl_WinPoints.Name = "lbl_WinPoints";
            this.lbl_WinPoints.Size = new System.Drawing.Size(54, 17);
            this.lbl_WinPoints.TabIndex = 21;
            this.lbl_WinPoints.Text = "dobitak";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.lbl_WinPoints);
            this.Controls.Add(this.lbl_Win);
            this.Controls.Add(this.lbl_WinTxt);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.btn_Izlaz);
            this.Controls.Add(this.lbl_PossibleWin);
            this.Controls.Add(this.lbl_PossibleWinTxt);
            this.Controls.Add(this.lbl_InstructionsTxt);
            this.Controls.Add(this.lbl_BetTxt);
            this.Controls.Add(this.lbl_PointsTxt);
            this.Controls.Add(this.btn_Zameni);
            this.Controls.Add(this.btn_Deli);
            this.Controls.Add(this.lbl_Bet);
            this.Controls.Add(this.lbl_Points);
            this.Controls.Add(this.pb_Card5);
            this.Controls.Add(this.pb_Card4);
            this.Controls.Add(this.pb_Card3);
            this.Controls.Add(this.pb_Card2);
            this.Controls.Add(this.pb_Card1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Card1;
        private System.Windows.Forms.PictureBox pb_Card2;
        private System.Windows.Forms.PictureBox pb_Card3;
        private System.Windows.Forms.PictureBox pb_Card4;
        private System.Windows.Forms.PictureBox pb_Card5;
        private System.Windows.Forms.Label lbl_Points;
        private System.Windows.Forms.Label lbl_Bet;
        private System.Windows.Forms.Button btn_Deli;
        private System.Windows.Forms.Button btn_Zameni;
        private System.Windows.Forms.Timer tm_AnimateTimer;
        private System.Windows.Forms.Label lbl_PointsTxt;
        private System.Windows.Forms.Label lbl_BetTxt;
        private System.Windows.Forms.Label lbl_InstructionsTxt;
        private System.Windows.Forms.Label lbl_PossibleWinTxt;
        private System.Windows.Forms.Label lbl_PossibleWin;
        private System.Windows.Forms.Button btn_Izlaz;
        private System.Windows.Forms.TextBox lbl_Instructions;
        private System.Windows.Forms.Label lbl_WinTxt;
        private System.Windows.Forms.Label lbl_Win;
        private System.Windows.Forms.Label lbl_WinPoints;
    }
}