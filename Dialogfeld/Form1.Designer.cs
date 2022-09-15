namespace Dialogfeld
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnInput = new System.Windows.Forms.Button();
            this.BtnLotto = new System.Windows.Forms.Button();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnInformation = new System.Windows.Forms.Button();
            this.BtnYesNo = new System.Windows.Forms.Button();
            this.BtnYesNoCancel = new System.Windows.Forms.Button();
            this.BtnRetryCancel = new System.Windows.Forms.Button();
            this.BtnAbortRetryIgnore = new System.Windows.Forms.Button();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.BtnSelectFolder = new System.Windows.Forms.Button();
            this.BtnSelectColor = new System.Windows.Forms.Button();
            this.BtnSelectFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInput
            // 
            this.BtnInput.Location = new System.Drawing.Point(12, 12);
            this.BtnInput.Name = "BtnInput";
            this.BtnInput.Size = new System.Drawing.Size(75, 23);
            this.BtnInput.TabIndex = 0;
            this.BtnInput.Text = "Input";
            this.BtnInput.UseVisualStyleBackColor = true;
            this.BtnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // BtnLotto
            // 
            this.BtnLotto.Location = new System.Drawing.Point(93, 12);
            this.BtnLotto.Name = "BtnLotto";
            this.BtnLotto.Size = new System.Drawing.Size(75, 23);
            this.BtnLotto.TabIndex = 0;
            this.BtnLotto.Text = "Lotto";
            this.BtnLotto.UseVisualStyleBackColor = true;
            this.BtnLotto.Click += new System.EventHandler(this.BtnLotto_Click);
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.Location = new System.Drawing.Point(12, 167);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(123, 15);
            this.LblDisplay.TabIndex = 1;
            this.LblDisplay.Text = "Das ist ein Beispieltext";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(210, 12);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(87, 23);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnInformation
            // 
            this.BtnInformation.Location = new System.Drawing.Point(303, 12);
            this.BtnInformation.Name = "BtnInformation";
            this.BtnInformation.Size = new System.Drawing.Size(112, 23);
            this.BtnInformation.TabIndex = 2;
            this.BtnInformation.Text = "Information";
            this.BtnInformation.UseVisualStyleBackColor = true;
            this.BtnInformation.Click += new System.EventHandler(this.BtnInformation_Click);
            // 
            // BtnYesNo
            // 
            this.BtnYesNo.Location = new System.Drawing.Point(210, 50);
            this.BtnYesNo.Name = "BtnYesNo";
            this.BtnYesNo.Size = new System.Drawing.Size(87, 23);
            this.BtnYesNo.TabIndex = 3;
            this.BtnYesNo.Text = "Yes No";
            this.BtnYesNo.UseVisualStyleBackColor = true;
            this.BtnYesNo.Click += new System.EventHandler(this.BtnYesNo_Click);
            // 
            // BtnYesNoCancel
            // 
            this.BtnYesNoCancel.Location = new System.Drawing.Point(303, 50);
            this.BtnYesNoCancel.Name = "BtnYesNoCancel";
            this.BtnYesNoCancel.Size = new System.Drawing.Size(112, 23);
            this.BtnYesNoCancel.TabIndex = 4;
            this.BtnYesNoCancel.Text = "Yes No Cancel";
            this.BtnYesNoCancel.UseVisualStyleBackColor = true;
            this.BtnYesNoCancel.Click += new System.EventHandler(this.BtnYesNoCancel_Click);
            // 
            // BtnRetryCancel
            // 
            this.BtnRetryCancel.Location = new System.Drawing.Point(210, 89);
            this.BtnRetryCancel.Name = "BtnRetryCancel";
            this.BtnRetryCancel.Size = new System.Drawing.Size(87, 23);
            this.BtnRetryCancel.TabIndex = 5;
            this.BtnRetryCancel.Text = "Retry Cancel";
            this.BtnRetryCancel.UseVisualStyleBackColor = true;
            this.BtnRetryCancel.Click += new System.EventHandler(this.BtnRetryCancel_Click);
            // 
            // BtnAbortRetryIgnore
            // 
            this.BtnAbortRetryIgnore.Location = new System.Drawing.Point(303, 89);
            this.BtnAbortRetryIgnore.Name = "BtnAbortRetryIgnore";
            this.BtnAbortRetryIgnore.Size = new System.Drawing.Size(112, 23);
            this.BtnAbortRetryIgnore.TabIndex = 6;
            this.BtnAbortRetryIgnore.Text = "Abort Retry Ignore";
            this.BtnAbortRetryIgnore.UseVisualStyleBackColor = true;
            this.BtnAbortRetryIgnore.Click += new System.EventHandler(this.BtnAbortRetryIgnore_Click);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(210, 128);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(87, 23);
            this.BtnOpenFile.TabIndex = 7;
            this.BtnOpenFile.Text = "Open File";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // BtnSelectFolder
            // 
            this.BtnSelectFolder.Location = new System.Drawing.Point(303, 128);
            this.BtnSelectFolder.Name = "BtnSelectFolder";
            this.BtnSelectFolder.Size = new System.Drawing.Size(112, 23);
            this.BtnSelectFolder.TabIndex = 8;
            this.BtnSelectFolder.Text = "Select Folder";
            this.BtnSelectFolder.UseVisualStyleBackColor = true;
            this.BtnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolder_Click);
            // 
            // BtnSelectColor
            // 
            this.BtnSelectColor.Location = new System.Drawing.Point(210, 167);
            this.BtnSelectColor.Name = "BtnSelectColor";
            this.BtnSelectColor.Size = new System.Drawing.Size(87, 23);
            this.BtnSelectColor.TabIndex = 9;
            this.BtnSelectColor.Text = "Select Color";
            this.BtnSelectColor.UseVisualStyleBackColor = true;
            this.BtnSelectColor.Click += new System.EventHandler(this.BtnSelectColor_Click);
            // 
            // BtnSelectFont
            // 
            this.BtnSelectFont.Location = new System.Drawing.Point(303, 167);
            this.BtnSelectFont.Name = "BtnSelectFont";
            this.BtnSelectFont.Size = new System.Drawing.Size(112, 23);
            this.BtnSelectFont.TabIndex = 10;
            this.BtnSelectFont.Text = "Select Font";
            this.BtnSelectFont.UseVisualStyleBackColor = true;
            this.BtnSelectFont.Click += new System.EventHandler(this.BtnSelectFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 201);
            this.Controls.Add(this.BtnSelectFont);
            this.Controls.Add(this.BtnSelectColor);
            this.Controls.Add(this.BtnSelectFolder);
            this.Controls.Add(this.BtnOpenFile);
            this.Controls.Add(this.BtnAbortRetryIgnore);
            this.Controls.Add(this.BtnRetryCancel);
            this.Controls.Add(this.BtnYesNoCancel);
            this.Controls.Add(this.BtnYesNo);
            this.Controls.Add(this.BtnInformation);
            this.Controls.Add(this.LblDisplay);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnLotto);
            this.Controls.Add(this.BtnInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnInput;
        private Button BtnLotto;
        private Label LblDisplay;
        private Button BtnOk;
        private Button BtnInformation;
        private Button BtnYesNo;
        private Button BtnYesNoCancel;
        private Button BtnRetryCancel;
        private Button BtnAbortRetryIgnore;
        private Button BtnOpenFile;
        private Button BtnSelectFolder;
        private Button BtnSelectColor;
        private Button BtnSelectFont;
    }
}