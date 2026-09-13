namespace IndidntUI
{
    partial class Indidnt
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.convertIndentButton = new System.Windows.Forms.Button();
            this.convertBracketButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(1, 1);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputText.Size = new System.Drawing.Size(798, 389);
            this.inputText.TabIndex = 0;
            // 
            // convertIndentButton
            // 
            this.convertIndentButton.Location = new System.Drawing.Point(579, 396);
            this.convertIndentButton.Name = "convertIndentButton";
            this.convertIndentButton.Size = new System.Drawing.Size(209, 42);
            this.convertIndentButton.TabIndex = 1;
            this.convertIndentButton.Text = "Convert To Indent";
            this.convertIndentButton.UseVisualStyleBackColor = true;
            this.convertIndentButton.Click += new System.EventHandler(this.convertIndentButton_Click);
            // 
            // convertBracketButton
            // 
            this.convertBracketButton.Location = new System.Drawing.Point(579, 444);
            this.convertBracketButton.Name = "convertBracketButton";
            this.convertBracketButton.Size = new System.Drawing.Size(209, 42);
            this.convertBracketButton.TabIndex = 2;
            this.convertBracketButton.Text = "Convert To Bracketed";
            this.convertBracketButton.UseVisualStyleBackColor = true;
            this.convertBracketButton.Click += new System.EventHandler(this.convertBracketButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indidnt v1.0 - Created By Kevin Brothers";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(308, 467);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Indidnt Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Indidnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertBracketButton);
            this.Controls.Add(this.convertIndentButton);
            this.Controls.Add(this.inputText);
            this.Name = "Indidnt";
            this.ShowIcon = false;
            this.Text = "Indidnt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button convertIndentButton;
        private System.Windows.Forms.Button convertBracketButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

