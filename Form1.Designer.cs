namespace Background_Remover
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImageLoaderButton = new System.Windows.Forms.Button();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.RemoveBackgButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageLoaderButton
            // 
            this.ImageLoaderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageLoaderButton.Location = new System.Drawing.Point(12, 359);
            this.ImageLoaderButton.Name = "ImageLoaderButton";
            this.ImageLoaderButton.Size = new System.Drawing.Size(94, 43);
            this.ImageLoaderButton.TabIndex = 0;
            this.ImageLoaderButton.Text = "Load File";
            this.ImageLoaderButton.UseVisualStyleBackColor = true;
            this.ImageLoaderButton.Click += new System.EventHandler(this.ImageLoaderButton_Click);
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewPictureBox.Location = new System.Drawing.Point(12, 12);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(525, 288);
            this.PreviewPictureBox.TabIndex = 1;
            this.PreviewPictureBox.TabStop = false;
            // 
            // RemoveBackgButton
            // 
            this.RemoveBackgButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBackgButton.Enabled = false;
            this.RemoveBackgButton.Location = new System.Drawing.Point(443, 359);
            this.RemoveBackgButton.Name = "RemoveBackgButton";
            this.RemoveBackgButton.Size = new System.Drawing.Size(94, 43);
            this.RemoveBackgButton.TabIndex = 2;
            this.RemoveBackgButton.Text = "Remove Background";
            this.RemoveBackgButton.UseVisualStyleBackColor = true;
            this.RemoveBackgButton.Click += new System.EventHandler(this.RemoveBackgButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 414);
            this.Controls.Add(this.RemoveBackgButton);
            this.Controls.Add(this.PreviewPictureBox);
            this.Controls.Add(this.ImageLoaderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Background Remover";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImageLoaderButton;
        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private System.Windows.Forms.Button RemoveBackgButton;
    }
}

