namespace OrionStarProject
{
    partial class OrionStarProject
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
            this.StarShow = new System.Windows.Forms.Button();
            this.StarsClear = new System.Windows.Forms.Button();
            this.OrionClean = new System.Windows.Forms.PictureBox();
            this.OrionOverlay = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrionClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrionOverlay)).BeginInit();
            this.SuspendLayout();
            // 
            // StarShow
            // 
            this.StarShow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StarShow.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarShow.ForeColor = System.Drawing.Color.White;
            this.StarShow.Image = global::OrionStarProject.Properties.Resources.OrionClean;
            this.StarShow.Location = new System.Drawing.Point(12, 476);
            this.StarShow.Name = "StarShow";
            this.StarShow.Size = new System.Drawing.Size(153, 60);
            this.StarShow.TabIndex = 2;
            this.StarShow.Text = "Show Star info";
            this.StarShow.UseVisualStyleBackColor = true;
            this.StarShow.Click += new System.EventHandler(this.StarShow_Click);
            // 
            // StarsClear
            // 
            this.StarsClear.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StarsClear.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarsClear.ForeColor = System.Drawing.Color.White;
            this.StarsClear.Image = global::OrionStarProject.Properties.Resources.OrionClean;
            this.StarsClear.Location = new System.Drawing.Point(228, 476);
            this.StarsClear.Name = "StarsClear";
            this.StarsClear.Size = new System.Drawing.Size(161, 60);
            this.StarsClear.TabIndex = 1;
            this.StarsClear.Text = "Clear the sky";
            this.StarsClear.UseVisualStyleBackColor = true;
            this.StarsClear.Click += new System.EventHandler(this.StarsClear_Click);
            // 
            // OrionClean
            // 
            this.OrionClean.Image = global::OrionStarProject.Properties.Resources.OrionClean;
            this.OrionClean.Location = new System.Drawing.Point(0, 0);
            this.OrionClean.Name = "OrionClean";
            this.OrionClean.Size = new System.Drawing.Size(400, 470);
            this.OrionClean.TabIndex = 0;
            this.OrionClean.TabStop = false;
            // 
            // OrionOverlay
            // 
            this.OrionOverlay.Image = global::OrionStarProject.Properties.Resources.OrionOverlay;
            this.OrionOverlay.Location = new System.Drawing.Point(0, 0);
            this.OrionOverlay.Name = "OrionOverlay";
            this.OrionOverlay.Size = new System.Drawing.Size(400, 470);
            this.OrionOverlay.TabIndex = 3;
            this.OrionOverlay.TabStop = false;
            this.OrionOverlay.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(366, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 28);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OrionStarProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::OrionStarProject.Properties.Resources.OrionClean;
            this.ClientSize = new System.Drawing.Size(401, 540);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OrionOverlay);
            this.Controls.Add(this.StarShow);
            this.Controls.Add(this.StarsClear);
            this.Controls.Add(this.OrionClean);
            this.Name = "OrionStarProject";
            this.Text = "OrionStarProject";
            ((System.ComponentModel.ISupportInitialize)(this.OrionClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrionOverlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox OrionClean;
        private System.Windows.Forms.Button StarsClear;
        private System.Windows.Forms.Button StarShow;
        private System.Windows.Forms.PictureBox OrionOverlay;
        private System.Windows.Forms.Button CloseButton;
    }
}

