namespace Base64ImageTool
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
            this.txtBase64Text = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtBase64Text
            // 
            this.txtBase64Text.Location = new System.Drawing.Point(111, 12);
            this.txtBase64Text.MaxLength = 2147483647;
            this.txtBase64Text.Multiline = true;
            this.txtBase64Text.Name = "txtBase64Text";
            this.txtBase64Text.Size = new System.Drawing.Size(664, 453);
            this.txtBase64Text.TabIndex = 0;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(667, 471);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(108, 23);
            this.btnDecode.TabIndex = 1;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base64 Image String";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "tif";
            this.saveFileDialog1.Filter = "Tif files (*.tif)|*.tif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtBase64Text);
            this.Name = "Form1";
            this.Text = "Base 64 String Decode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase64Text;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

