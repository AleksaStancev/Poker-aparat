
namespace Poker.View
{
    partial class StartupForm
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
            this.nud_Points = new System.Windows.Forms.NumericUpDown();
            this.nud_Bet = new System.Windows.Forms.NumericUpDown();
            this.lbl_Points = new System.Windows.Forms.Label();
            this.lbl_Bet = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.lbl_Max = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Bet)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_Points
            // 
            this.nud_Points.Location = new System.Drawing.Point(71, 32);
            this.nud_Points.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Points.Name = "nud_Points";
            this.nud_Points.Size = new System.Drawing.Size(120, 22);
            this.nud_Points.TabIndex = 0;
            this.nud_Points.ThousandsSeparator = true;
            this.nud_Points.ValueChanged += new System.EventHandler(this.Nud_Points_ValueChanged);
            // 
            // nud_Bet
            // 
            this.nud_Bet.Location = new System.Drawing.Point(71, 71);
            this.nud_Bet.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud_Bet.Name = "nud_Bet";
            this.nud_Bet.Size = new System.Drawing.Size(120, 22);
            this.nud_Bet.TabIndex = 1;
            // 
            // lbl_Points
            // 
            this.lbl_Points.AutoSize = true;
            this.lbl_Points.Location = new System.Drawing.Point(17, 34);
            this.lbl_Points.Name = "lbl_Points";
            this.lbl_Points.Size = new System.Drawing.Size(48, 17);
            this.lbl_Points.TabIndex = 2;
            this.lbl_Points.Text = "Poeni:";
            // 
            // lbl_Bet
            // 
            this.lbl_Bet.AutoSize = true;
            this.lbl_Bet.Location = new System.Drawing.Point(24, 73);
            this.lbl_Bet.Name = "lbl_Bet";
            this.lbl_Bet.Size = new System.Drawing.Size(41, 17);
            this.lbl_Bet.TabIndex = 3;
            this.lbl_Bet.Text = "Ulog:";
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(85, 100);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(75, 32);
            this.btn_Play.TabIndex = 4;
            this.btn_Play.Text = "Igraj";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(71, 51);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(103, 17);
            this.lbl_Max.TabIndex = 5;
            this.lbl_Max.Text = "(Max 100_000)";
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 133);
            this.Controls.Add(this.lbl_Max);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.lbl_Bet);
            this.Controls.Add(this.lbl_Points);
            this.Controls.Add(this.nud_Bet);
            this.Controls.Add(this.nud_Points);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izaberite poene i ulog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartupForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartupForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Bet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_Points;
        private System.Windows.Forms.NumericUpDown nud_Bet;
        private System.Windows.Forms.Label lbl_Points;
        private System.Windows.Forms.Label lbl_Bet;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Label lbl_Max;
    }
}

