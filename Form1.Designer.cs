namespace StringBuilder
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
			this.buttonString = new System.Windows.Forms.Button();
			this.buttonStringBuilder = new System.Windows.Forms.Button();
			this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
			this.buttonWithCollection = new System.Windows.Forms.Button();
			this.textBoxFolder = new System.Windows.Forms.TextBox();
			this.buttonChangeFolder = new System.Windows.Forms.Button();
			this.checkBoxUseIncludeFolders = new System.Windows.Forms.CheckBox();
			this.textBoxFindName = new System.Windows.Forms.TextBox();
			this.checkBoxCountNames = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// buttonString
			// 
			this.buttonString.Location = new System.Drawing.Point(10, 90);
			this.buttonString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonString.Name = "buttonString";
			this.buttonString.Size = new System.Drawing.Size(300, 29);
			this.buttonString.TabIndex = 10;
			this.buttonString.Text = "Read files to string";
			this.buttonString.UseVisualStyleBackColor = true;
			this.buttonString.Click += new System.EventHandler(this.buttonString_Click);
			// 
			// buttonStringBuilder
			// 
			this.buttonStringBuilder.Location = new System.Drawing.Point(355, 90);
			this.buttonStringBuilder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonStringBuilder.Name = "buttonStringBuilder";
			this.buttonStringBuilder.Size = new System.Drawing.Size(300, 29);
			this.buttonStringBuilder.TabIndex = 11;
			this.buttonStringBuilder.Text = "Read files to StringBuilder";
			this.buttonStringBuilder.UseVisualStyleBackColor = true;
			this.buttonStringBuilder.Click += new System.EventHandler(this.buttonStringBuilder_Click);
			// 
			// richTextBoxOut
			// 
			this.richTextBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxOut.BackColor = System.Drawing.SystemColors.Control;
			this.richTextBoxOut.Location = new System.Drawing.Point(10, 125);
			this.richTextBoxOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.richTextBoxOut.Name = "richTextBoxOut";
			this.richTextBoxOut.ReadOnly = true;
			this.richTextBoxOut.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBoxOut.Size = new System.Drawing.Size(984, 125);
			this.richTextBoxOut.TabIndex = 20;
			this.richTextBoxOut.Text = "";
			// 
			// buttonWithCollection
			// 
			this.buttonWithCollection.Location = new System.Drawing.Point(694, 90);
			this.buttonWithCollection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonWithCollection.Name = "buttonWithCollection";
			this.buttonWithCollection.Size = new System.Drawing.Size(300, 29);
			this.buttonWithCollection.TabIndex = 12;
			this.buttonWithCollection.Text = "Read files to Collection<string>";
			this.buttonWithCollection.UseVisualStyleBackColor = true;
			this.buttonWithCollection.Click += new System.EventHandler(this.buttonWithCollection_Click);
			// 
			// textBoxFolder
			// 
			this.textBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFolder.Location = new System.Drawing.Point(10, 50);
			this.textBoxFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxFolder.Name = "textBoxFolder";
			this.textBoxFolder.Size = new System.Drawing.Size(984, 27);
			this.textBoxFolder.TabIndex = 4;
			// 
			// buttonChangeFolder
			// 
			this.buttonChangeFolder.Location = new System.Drawing.Point(10, 10);
			this.buttonChangeFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonChangeFolder.Name = "buttonChangeFolder";
			this.buttonChangeFolder.Size = new System.Drawing.Size(99, 29);
			this.buttonChangeFolder.TabIndex = 0;
			this.buttonChangeFolder.Text = "Set folder";
			this.buttonChangeFolder.UseVisualStyleBackColor = true;
			this.buttonChangeFolder.Click += new System.EventHandler(this.buttonChangeFolder_Click);
			// 
			// checkBoxUseIncludeFolders
			// 
			this.checkBoxUseIncludeFolders.AutoSize = true;
			this.checkBoxUseIncludeFolders.Location = new System.Drawing.Point(120, 15);
			this.checkBoxUseIncludeFolders.Name = "checkBoxUseIncludeFolders";
			this.checkBoxUseIncludeFolders.Size = new System.Drawing.Size(124, 23);
			this.checkBoxUseIncludeFolders.TabIndex = 1;
			this.checkBoxUseIncludeFolders.Text = "Include folders";
			this.checkBoxUseIncludeFolders.UseVisualStyleBackColor = true;
			// 
			// textBoxFindName
			// 
			this.textBoxFindName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFindName.Location = new System.Drawing.Point(380, 12);
			this.textBoxFindName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxFindName.Name = "textBoxFindName";
			this.textBoxFindName.Size = new System.Drawing.Size(614, 27);
			this.textBoxFindName.TabIndex = 3;
			this.textBoxFindName.Text = "png";
			// 
			// checkBoxCountNames
			// 
			this.checkBoxCountNames.AutoSize = true;
			this.checkBoxCountNames.Checked = true;
			this.checkBoxCountNames.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCountNames.Location = new System.Drawing.Point(250, 15);
			this.checkBoxCountNames.Name = "checkBoxCountNames";
			this.checkBoxCountNames.Size = new System.Drawing.Size(126, 23);
			this.checkBoxCountNames.TabIndex = 2;
			this.checkBoxCountNames.Text = "Find file names";
			this.checkBoxCountNames.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 261);
			this.Controls.Add(this.checkBoxCountNames);
			this.Controls.Add(this.textBoxFindName);
			this.Controls.Add(this.checkBoxUseIncludeFolders);
			this.Controls.Add(this.buttonChangeFolder);
			this.Controls.Add(this.textBoxFolder);
			this.Controls.Add(this.buttonWithCollection);
			this.Controls.Add(this.richTextBoxOut);
			this.Controls.Add(this.buttonStringBuilder);
			this.Controls.Add(this.buttonString);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximumSize = new System.Drawing.Size(1024, 1300);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1024, 0);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "String, StringBuilder, Collection<String>";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonString;
        private System.Windows.Forms.Button buttonStringBuilder;
        private System.Windows.Forms.RichTextBox richTextBoxOut;
		private System.Windows.Forms.Button buttonWithCollection;
		private System.Windows.Forms.TextBox textBoxFolder;
		private System.Windows.Forms.Button buttonChangeFolder;
		private System.Windows.Forms.CheckBox checkBoxUseIncludeFolders;
		private System.Windows.Forms.TextBox textBoxFindName;
		private System.Windows.Forms.CheckBox checkBoxCountNames;
	}
}

