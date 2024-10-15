namespace ZenToolsUI
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnZen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKey = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtCmdCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(36, 51);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(233, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(275, 49);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(106, 23);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Find Folder";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnZen
            // 
            this.btnZen.Location = new System.Drawing.Point(36, 217);
            this.btnZen.Name = "btnZen";
            this.btnZen.Size = new System.Drawing.Size(345, 23);
            this.btnZen.TabIndex = 6;
            this.btnZen.Text = "Extract Using ZenTools";
            this.btnZen.UseVisualStyleBackColor = true;
            this.btnZen.Click += new System.EventHandler(this.btnZen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input Folder (Where the games PAK files are located)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Output Folder (Where the files will be extracted to)";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(275, 105);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(106, 23);
            this.btnOutput.TabIndex = 9;
            this.btnOutput.Text = "Find Folder";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(36, 107);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(233, 20);
            this.txtOutput.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Encryption Key File";
            // 
            // btnKey
            // 
            this.btnKey.Location = new System.Drawing.Point(275, 161);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(106, 23);
            this.btnKey.TabIndex = 12;
            this.btnKey.Text = "Find File";
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(36, 163);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(233, 20);
            this.txtKey.TabIndex = 11;
            this.txtKey.Text = "Keys.json";
            // 
            // txtCmdCode
            // 
            this.txtCmdCode.Location = new System.Drawing.Point(36, 260);
            this.txtCmdCode.Multiline = true;
            this.txtCmdCode.Name = "txtCmdCode";
            this.txtCmdCode.Size = new System.Drawing.Size(345, 67);
            this.txtCmdCode.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 355);
            this.Controls.Add(this.txtCmdCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZen);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Zen Tools UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnZen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtCmdCode;
    }
}

