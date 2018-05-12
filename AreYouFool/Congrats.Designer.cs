namespace AreYouFool
{
    partial class Congrats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Congrats));
            this.next = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.next.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(259, 317);
            this.next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(137, 56);
            this.next.TabIndex = 0;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.SeaGreen;
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayBox.Font = new System.Drawing.Font("Lato Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.ForeColor = System.Drawing.Color.Snow;
            this.displayBox.Location = new System.Drawing.Point(197, 83);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.Size = new System.Drawing.Size(262, 57);
            this.displayBox.TabIndex = 2;
            this.displayBox.Text = "       CONGRATULATION!!!       YOU ARE SMART";
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.displayBox.TextChanged += new System.EventHandler(this.displayBox_TextChanged);
            // 
            // Congrats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.next);
            this.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Congrats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Congrats";
            this.Load += new System.EventHandler(this.Congrats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox displayBox;
    }
}