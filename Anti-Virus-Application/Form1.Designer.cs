namespace Anti_Virus_Application
{
    partial class Form
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
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.filePathTextbox = new System.Windows.Forms.TextBox();
            this.MD5Textbox = new System.Windows.Forms.TextBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.File_label = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(12, 27);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(56, 20);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "File(s):";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(12, 65);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(47, 20);
            this.label_2.TabIndex = 1;
            this.label_2.Text = "MD5:";
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextbox.Location = new System.Drawing.Point(74, 27);
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.Size = new System.Drawing.Size(201, 26);
            this.filePathTextbox.TabIndex = 2;
            // 
            // MD5Textbox
            // 
            this.MD5Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD5Textbox.Location = new System.Drawing.Point(74, 62);
            this.MD5Textbox.Name = "MD5Textbox";
            this.MD5Textbox.Size = new System.Drawing.Size(201, 26);
            this.MD5Textbox.TabIndex = 3;
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(164, 94);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(111, 32);
            this.uploadButton.TabIndex = 4;
            this.uploadButton.Text = "Upload File(s)";
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // File_label
            // 
            this.File_label.AutoSize = true;
            this.File_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_label.Location = new System.Drawing.Point(12, 30);
            this.File_label.Name = "File_label";
            this.File_label.Size = new System.Drawing.Size(52, 20);
            this.File_label.TabIndex = 5;
            this.File_label.Text = "File(s)";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(70, 99);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(56, 20);
            this.Status.TabIndex = 6;
            this.Status.Text = "Status";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(292, 151);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.File_label);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.MD5Textbox);
            this.Controls.Add(this.filePathTextbox);
            this.Controls.Add(this.label_2);
            this.Name = "Form";
            this.Text = "AntiVirus";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.TextBox filePathTextbox;
        private System.Windows.Forms.TextBox MD5Textbox;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label File_label;
        private System.Windows.Forms.Label Status;
    }
}

