namespace guessNumber
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
            this.tboxUserAnswer = new System.Windows.Forms.TextBox();
            this.lblEnterTheNumber = new System.Windows.Forms.Label();
            this.lblStepText = new System.Windows.Forms.Label();
            this.lblStepCount = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxUserAnswer
            // 
            this.tboxUserAnswer.Location = new System.Drawing.Point(64, 43);
            this.tboxUserAnswer.Name = "tboxUserAnswer";
            this.tboxUserAnswer.Size = new System.Drawing.Size(131, 20);
            this.tboxUserAnswer.TabIndex = 0;
            // 
            // lblEnterTheNumber
            // 
            this.lblEnterTheNumber.AutoSize = true;
            this.lblEnterTheNumber.Location = new System.Drawing.Point(61, 18);
            this.lblEnterTheNumber.Name = "lblEnterTheNumber";
            this.lblEnterTheNumber.Size = new System.Drawing.Size(35, 13);
            this.lblEnterTheNumber.TabIndex = 1;
            this.lblEnterTheNumber.Text = "label1";
            // 
            // lblStepText
            // 
            this.lblStepText.AutoSize = true;
            this.lblStepText.Location = new System.Drawing.Point(57, 119);
            this.lblStepText.Name = "lblStepText";
            this.lblStepText.Size = new System.Drawing.Size(35, 13);
            this.lblStepText.TabIndex = 2;
            this.lblStepText.Text = "label2";
            // 
            // lblStepCount
            // 
            this.lblStepCount.AutoSize = true;
            this.lblStepCount.Location = new System.Drawing.Point(173, 119);
            this.lblStepCount.Name = "lblStepCount";
            this.lblStepCount.Size = new System.Drawing.Size(35, 13);
            this.lblStepCount.TabIndex = 3;
            this.lblStepCount.Text = "label3";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(89, 80);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "button1";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 151);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblStepCount);
            this.Controls.Add(this.lblStepText);
            this.Controls.Add(this.lblEnterTheNumber);
            this.Controls.Add(this.tboxUserAnswer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxUserAnswer;
        private System.Windows.Forms.Label lblEnterTheNumber;
        private System.Windows.Forms.Label lblStepText;
        private System.Windows.Forms.Label lblStepCount;
        private System.Windows.Forms.Button btnCheck;
    }
}

