namespace SimpleCalc
{
    partial class FormCalc
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
            this.Input_1 = new System.Windows.Forms.TextBox();
            this.Input_2 = new System.Windows.Forms.TextBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.AnswerTextbox = new System.Windows.Forms.TextBox();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input_1
            // 
            this.Input_1.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Input_1.Location = new System.Drawing.Point(105, 12);
            this.Input_1.Name = "Input_1";
            this.Input_1.Size = new System.Drawing.Size(100, 46);
            this.Input_1.TabIndex = 0;
            // 
            // Input_2
            // 
            this.Input_2.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Input_2.Location = new System.Drawing.Point(105, 79);
            this.Input_2.Name = "Input_2";
            this.Input_2.Size = new System.Drawing.Size(100, 46);
            this.Input_2.TabIndex = 1;
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ModeLabel.Location = new System.Drawing.Point(61, 82);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(38, 31);
            this.ModeLabel.TabIndex = 2;
            this.ModeLabel.Text = "÷";
            // 
            // AnswerTextbox
            // 
            this.AnswerTextbox.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AnswerTextbox.Location = new System.Drawing.Point(105, 153);
            this.AnswerTextbox.Name = "AnswerTextbox";
            this.AnswerTextbox.Size = new System.Drawing.Size(100, 46);
            this.AnswerTextbox.TabIndex = 4;
            // 
            // AnswerButton
            // 
            this.AnswerButton.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AnswerButton.Location = new System.Drawing.Point(36, 153);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(63, 40);
            this.AnswerButton.TabIndex = 5;
            this.AnswerButton.Text = "=";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 211);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.AnswerTextbox);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.Input_2);
            this.Controls.Add(this.Input_1);
            this.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCalc";
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_1;
        private System.Windows.Forms.TextBox Input_2;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.TextBox AnswerTextbox;
        private System.Windows.Forms.Button AnswerButton;
    }
}