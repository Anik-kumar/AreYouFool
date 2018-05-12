namespace AreYouFool
{
    partial class Game
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
            this.accept = new System.Windows.Forms.Button();
            this.decline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "--------------   ARE YOU A FOOL?   -----------";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.YellowGreen;
            this.accept.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.Location = new System.Drawing.Point(377, 139);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(143, 45);
            this.accept.TabIndex = 2;
            this.accept.Text = "YES";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // decline
            // 
            this.decline.BackColor = System.Drawing.Color.Coral;
            this.decline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.decline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.decline.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decline.Location = new System.Drawing.Point(225, 146);
            this.decline.Name = "decline";
            this.decline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.decline.Size = new System.Drawing.Size(110, 37);
            this.decline.TabIndex = 3;
            this.decline.Text = "NO";
            this.decline.UseVisualStyleBackColor = false;
            this.decline.Click += new System.EventHandler(this.decline_Click);
            this.decline.MouseHover += new System.EventHandler(this.declineHover);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(742, 431);
            this.Controls.Add(this.decline);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button decline;
    }
}

