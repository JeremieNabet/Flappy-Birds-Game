
namespace Flappy_Birds_Game
{
    partial class Form2
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.retryButton = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.scoreAndMoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // retryButton
            // 
            this.retryButton.BackColor = System.Drawing.SystemColors.Control;
            this.retryButton.Location = new System.Drawing.Point(142, 227);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(107, 64);
            this.retryButton.TabIndex = 0;
            this.retryButton.Text = "RETRY";
            this.retryButton.UseVisualStyleBackColor = false;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.Location = new System.Drawing.Point(490, 227);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(104, 64);
            this.CANCEL.TabIndex = 1;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.button2_Click);
            // 
            // scoreAndMoreLabel
            // 
            this.scoreAndMoreLabel.AutoSize = true;
            this.scoreAndMoreLabel.Location = new System.Drawing.Point(343, 114);
            this.scoreAndMoreLabel.Name = "scoreAndMoreLabel";
            this.scoreAndMoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreAndMoreLabel.TabIndex = 2;
            this.scoreAndMoreLabel.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreAndMoreLabel);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.retryButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Label scoreAndMoreLabel;
    }
}