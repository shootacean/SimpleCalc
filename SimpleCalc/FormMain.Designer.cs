namespace SimpleCalc
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddButton.Location = new System.Drawing.Point(14, 16);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 56);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinusButton.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinusButton.Location = new System.Drawing.Point(157, 16);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(120, 56);
            this.MinusButton.TabIndex = 1;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // MultiButton
            // 
            this.MultiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MultiButton.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MultiButton.Location = new System.Drawing.Point(14, 98);
            this.MultiButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MultiButton.Name = "MultiButton";
            this.MultiButton.Size = new System.Drawing.Size(120, 56);
            this.MultiButton.TabIndex = 2;
            this.MultiButton.Text = "✕";
            this.MultiButton.UseVisualStyleBackColor = true;
            this.MultiButton.Click += new System.EventHandler(this.MultiButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DivButton.Font = new System.Drawing.Font("游ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DivButton.Location = new System.Drawing.Point(157, 98);
            this.DivButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(120, 56);
            this.DivButton.TabIndex = 3;
            this.DivButton.Text = "÷";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 170);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.MultiButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "四則演算";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiButton;
        private System.Windows.Forms.Button DivButton;
    }
}

